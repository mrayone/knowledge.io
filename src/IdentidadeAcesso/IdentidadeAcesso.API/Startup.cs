﻿using IdentidadeAcesso.API.Infrastrucuture.IoC;
using IdentidadeAcesso.CrossCutting.Identity.Configuration;
using IdentidadeAcesso.CrossCutting.Identity.Options;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace IdentidadeAcesso.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var configBuilder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"mailsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

            Configuration = configBuilder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddMediatR(typeof(Startup).GetType().Assembly)
                .AddValidationBehavior()
                .AddDomainServices()
                .AddDataDependencies()
                .AddDomainNotifications()
                .AddApplicationQueries()
                .AddApplicationHandlers()
                .AddIdentityConfig();

            services.Configure<AppOptions>(Configuration);

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
            });

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info()
                {
                    Version = "v1",
                    Title = "Knowledge.IO.API",
                    Description = "API do site Knowledge.IO",
                    TermsOfService = "Nenhum",
                    Contact = new Contact()
                    {
                        Name = "Desenvolver Maycon Rayone Rodrigues Xavier",
                        Email = "maycon.rayone@gmail.com",
                        Url = ""
                    },
                    License = new License()
                    {
                        Name = "MIT",
                        Url = "http://eventos.io/license"
                    }
                });

                var filePath = Path.Combine(System.AppContext.BaseDirectory, "IdentidadeAcesso.API.xml");
                s.IncludeXmlComments(filePath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            IdentityModelEventSource.ShowPII = true; //Add this line
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Knowledge.IO API V1");
            });

            // app.UseHttpsRedirection();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseMvc();
        }
    }
}
