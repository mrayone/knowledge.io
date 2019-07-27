﻿// <auto-generated />
using System;
using Knowledge.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentidadeAcesso.Infra.Data.Migrations
{
    [DbContext(typeof(IdentidadeAcessoDbContext))]
    partial class IdentidadeAcessoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DeletadoEm");

                    b.HasKey("Id");

                    b.ToTable("perfis","dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709")
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.PermissaoAssinada", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PerfilId");

                    b.Property<Guid>("PermissaoId");

                    b.Property<bool>("Status")
                        .HasColumnName("Ativo");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.HasIndex("PermissaoId");

                    b.ToTable("permissoes_assinadas","dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b3adfec-ad5a-47bd-8fe0-f350fab1d6de"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("4cf679e7-ef92-49e4-b677-2ec8d4e91453"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("c384a0fc-5748-4e75-862a-6fa4d9f60592"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("99e90c66-a791-42d6-a24a-f4bc1235a576"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("9b7f7378-1d1b-4547-a0b2-240b58310450"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("20f04a05-7732-428c-a5f2-1a5765256808"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("580a232f-5297-42b2-a21e-c706fb54b515"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("f40ed114-8191-4621-8836-21aaf60eecf4"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("a79f106f-05b9-4f13-9cac-501f0a8c757b"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("0440c348-12c2-435a-a027-f81636e71faa"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("54ed99d1-7cf1-46a1-8523-36d9b3c90ae9"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("1503b73e-4db3-4122-ac1f-b8ce7a0214ee"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("3588bbdc-a7a7-4318-a6e9-e21187a8e047"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("170a49c2-5f0f-4552-b8cc-bf679e96bcbe"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("01f51fa7-a5fa-4d67-a67d-1e5b23d22d52"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("cec6f99f-4c3f-483c-ba53-954d79a553e0"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("5c5e6663-7396-4929-a872-d011f8bcf8d4"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("fc7cc8f8-0fd8-4067-ba34-f8c06e02f57c"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("27066fa7-3e59-4193-bcda-ec5bd2f73883"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("f2c056c9-9320-492e-9d6a-563bd5788a8a"),
                            Status = true
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Permissao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DeletadoEm");

                    b.HasKey("Id");

                    b.ToTable("permissoes","dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4cf679e7-ef92-49e4-b677-2ec8d4e91453")
                        },
                        new
                        {
                            Id = new Guid("99e90c66-a791-42d6-a24a-f4bc1235a576")
                        },
                        new
                        {
                            Id = new Guid("20f04a05-7732-428c-a5f2-1a5765256808")
                        },
                        new
                        {
                            Id = new Guid("f40ed114-8191-4621-8836-21aaf60eecf4")
                        },
                        new
                        {
                            Id = new Guid("0440c348-12c2-435a-a027-f81636e71faa")
                        },
                        new
                        {
                            Id = new Guid("1503b73e-4db3-4122-ac1f-b8ce7a0214ee")
                        },
                        new
                        {
                            Id = new Guid("170a49c2-5f0f-4552-b8cc-bf679e96bcbe")
                        },
                        new
                        {
                            Id = new Guid("cec6f99f-4c3f-483c-ba53-954d79a553e0")
                        },
                        new
                        {
                            Id = new Guid("fc7cc8f8-0fd8-4067-ba34-f8c06e02f57c")
                        },
                        new
                        {
                            Id = new Guid("f2c056c9-9320-492e-9d6a-563bd5788a8a")
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DeletadoEm");

                    b.Property<Guid>("PerfilId");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("usuarios","dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            Status = true
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil", b =>
                {
                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.ValueObjects.Identificacao", "Identifacao", b1 =>
                        {
                            b1.Property<Guid>("PerfilId");

                            b1.Property<string>("Descricao")
                                .IsRequired()
                                .HasColumnName("Descricao");

                            b1.Property<string>("Nome")
                                .IsRequired()
                                .HasColumnName("Nome");

                            b1.HasKey("PerfilId");

                            b1.ToTable("perfis","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil")
                                .WithOne("Identifacao")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.ValueObjects.Identificacao", "PerfilId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                                    Descricao = "Perfil de super usuário",
                                    Nome = "Super"
                                });
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.PermissaoAssinada", b =>
                {
                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil")
                        .WithMany("PermissoesAssinadas")
                        .HasForeignKey("PerfilId");

                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Permissao")
                        .WithMany()
                        .HasForeignKey("PermissaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Permissao", b =>
                {
                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.ValueObjects.Atribuicao", "Atribuicao", b1 =>
                        {
                            b1.Property<Guid>("PermissaoId");

                            b1.Property<string>("Tipo")
                                .IsRequired();

                            b1.Property<string>("Valor")
                                .IsRequired();

                            b1.HasKey("PermissaoId");

                            b1.ToTable("permissoes","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Permissao")
                                .WithOne("Atribuicao")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.ValueObjects.Atribuicao", "PermissaoId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    PermissaoId = new Guid("4cf679e7-ef92-49e4-b677-2ec8d4e91453"),
                                    Tipo = "Perfil",
                                    Valor = "Visualizar Perfis"
                                },
                                new
                                {
                                    PermissaoId = new Guid("99e90c66-a791-42d6-a24a-f4bc1235a576"),
                                    Tipo = "Perfil",
                                    Valor = "Desativar Permissões"
                                },
                                new
                                {
                                    PermissaoId = new Guid("20f04a05-7732-428c-a5f2-1a5765256808"),
                                    Tipo = "Perfil",
                                    Valor = "Atribuir Permissões"
                                },
                                new
                                {
                                    PermissaoId = new Guid("f40ed114-8191-4621-8836-21aaf60eecf4"),
                                    Tipo = "Perfil",
                                    Valor = "Criar Perfil"
                                },
                                new
                                {
                                    PermissaoId = new Guid("0440c348-12c2-435a-a027-f81636e71faa"),
                                    Tipo = "Perfil",
                                    Valor = "Editar Perfil"
                                },
                                new
                                {
                                    PermissaoId = new Guid("1503b73e-4db3-4122-ac1f-b8ce7a0214ee"),
                                    Tipo = "Perfil",
                                    Valor = "Excluir Perfil"
                                },
                                new
                                {
                                    PermissaoId = new Guid("170a49c2-5f0f-4552-b8cc-bf679e96bcbe"),
                                    Tipo = "Permissão",
                                    Valor = "Criar Permissão"
                                },
                                new
                                {
                                    PermissaoId = new Guid("cec6f99f-4c3f-483c-ba53-954d79a553e0"),
                                    Tipo = "Permissão",
                                    Valor = "Editar Permissão"
                                },
                                new
                                {
                                    PermissaoId = new Guid("fc7cc8f8-0fd8-4067-ba34-f8c06e02f57c"),
                                    Tipo = "Permissão",
                                    Valor = "Visualizar Permissões"
                                },
                                new
                                {
                                    PermissaoId = new Guid("f2c056c9-9320-492e-9d6a-563bd5788a8a"),
                                    Tipo = "Permissão",
                                    Valor = "Excluir Permissão"
                                });
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario", b =>
                {
                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.CPF", "CPF", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Digitos")
                                .IsRequired()
                                .HasColumnName("CPF");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("CPF")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.CPF", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                                    Digitos = "28999953084"
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.DataDeNascimento", "DataDeNascimento", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<DateTime>("Data");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("DataDeNascimento")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.DataDeNascimento", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                                    Data = new DateTime(1993, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Endereco")
                                .IsRequired()
                                .HasColumnName("Email");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("Email")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Email", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                                    Endereco = "maycon.rayone@gmail.com"
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Bairro");

                            b1.Property<string>("Cep");

                            b1.Property<string>("Cidade");

                            b1.Property<string>("Complemento");

                            b1.Property<string>("Estado");

                            b1.Property<string>("Logradouro");

                            b1.Property<string>("Numero");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuario_endereco","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("Endereco")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Endereco", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.NomeCompleto", "Nome", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("PrimeiroNome")
                                .IsRequired()
                                .HasColumnName("PrimeiroNome");

                            b1.Property<string>("Sobrenome")
                                .IsRequired()
                                .HasColumnName("Sobrenome");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("Nome")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.NomeCompleto", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                                    PrimeiroNome = "Maycon Rayone",
                                    Sobrenome = "Rodrigues Xavier"
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.NumerosContato", "NumerosContato", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("NumeroCel")
                                .HasColumnName("Celular");

                            b1.Property<string>("NumeroTelefone")
                                .HasColumnName("Telefone");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("NumerosContato")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.NumerosContato", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb")
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Senha", "Senha", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Caracteres")
                                .IsRequired()
                                .HasColumnName("Senha");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("Senha")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Senha", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                                    Caracteres = "AA/mq7/o0FzgHhO/xE4+rJ1tO6JKmiZYxe9c7SjI6LI1j6aDxDhcNjbznfrsTU3y3g=="
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Sexo", "Sexo", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Tipo")
                                .IsRequired()
                                .HasColumnName("Sexo");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("usuarios","dbo");

                            b1.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                                .WithOne("Sexo")
                                .HasForeignKey("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Sexo", "UsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("51ff5809-e464-45f6-81e4-682ab201b3bb"),
                                    Tipo = "Masculino"
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}