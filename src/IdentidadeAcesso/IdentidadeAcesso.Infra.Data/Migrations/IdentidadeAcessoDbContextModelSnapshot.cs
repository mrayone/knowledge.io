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

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.AtribuicaoPerfil", b =>
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

                    b.ToTable("atribuicoes_perfil","dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("71ef947d-2f1d-47de-b651-6c2ffd0c9ee4"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("4cf679e7-ef92-49e4-b677-2ec8d4e91453"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("17cb75eb-177a-424d-91d7-18ff251408f5"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("99e90c66-a791-42d6-a24a-f4bc1235a576"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("29cfa08b-d1fd-48ed-9b96-fa249e0e1285"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("20f04a05-7732-428c-a5f2-1a5765256808"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("1c181735-a7be-4ed3-83d9-eaf2de07fb41"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("f40ed114-8191-4621-8836-21aaf60eecf4"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("aa843f65-f247-43b1-a856-ff0276f0d359"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("0440c348-12c2-435a-a027-f81636e71faa"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("692b5b0d-5f72-41cb-80f8-99f5a930adcc"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("1503b73e-4db3-4122-ac1f-b8ce7a0214ee"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("5643bffb-2c44-4e21-b410-fe10fc011b35"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("170a49c2-5f0f-4552-b8cc-bf679e96bcbe"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("aafdd070-d1ac-4fe8-94b5-5511d9d9c6a2"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("cec6f99f-4c3f-483c-ba53-954d79a553e0"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("ff2f1b56-dea9-47ca-b9fe-8bf7159f94d2"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("fc7cc8f8-0fd8-4067-ba34-f8c06e02f57c"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("5cd49434-923a-4a8a-8e76-f3abb20032f7"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("f2c056c9-9320-492e-9d6a-563bd5788a8a"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("119059ec-ae7e-4104-81c3-b3988b9d4bb2"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("e8d085f3-ebc1-4bc1-83c7-1cdc41d3dc49"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("a75234d8-eccc-4490-a45d-7cf97e5ceebc"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("bc6e96ae-c6af-40ca-8c11-cd11fb8a3e27"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("5a0b362f-af22-43a3-9a1b-74dc4cad85e4"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("9f688e0a-a29f-4713-be45-c2a25df474b1"),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("623e2781-1a60-4367-9ae6-294570053f47"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            PermissaoId = new Guid("a6eb8dd5-cfe6-4154-8a29-f3cf66dc5cd0"),
                            Status = true
                        });
                });

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
                        },
                        new
                        {
                            Id = new Guid("e8d085f3-ebc1-4bc1-83c7-1cdc41d3dc49")
                        },
                        new
                        {
                            Id = new Guid("bc6e96ae-c6af-40ca-8c11-cd11fb8a3e27")
                        },
                        new
                        {
                            Id = new Guid("9f688e0a-a29f-4713-be45-c2a25df474b1")
                        },
                        new
                        {
                            Id = new Guid("a6eb8dd5-cfe6-4154-8a29-f3cf66dc5cd0")
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.TokenRedefinicaoSenha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CriadoEm");

                    b.Property<string>("Email");

                    b.Property<string>("Token");

                    b.Property<Guid>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("tokens_de_redefinicao","dbo");
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DeletadoEm");

                    b.Property<Guid?>("PerfilId");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("usuarios","dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            Status = true
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.AtribuicaoPerfil", b =>
                {
                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil")
                        .WithMany("Atribuicoes")
                        .HasForeignKey("PerfilId");

                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Permissao")
                        .WithMany()
                        .HasForeignKey("PermissaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil", b =>
                {
                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.ValueObjects.Identificacao", "Identifacao", b1 =>
                        {
                            b1.Property<Guid>("PerfilId");

                            b1.Property<string>("Descricao")
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
                                    Nome = "Administrador"
                                });
                        });
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
                                    Valor = "Revogar Permissões"
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
                                },
                                new
                                {
                                    PermissaoId = new Guid("e8d085f3-ebc1-4bc1-83c7-1cdc41d3dc49"),
                                    Tipo = "Usuário",
                                    Valor = "Visualizar Usuários"
                                },
                                new
                                {
                                    PermissaoId = new Guid("bc6e96ae-c6af-40ca-8c11-cd11fb8a3e27"),
                                    Tipo = "Usuário",
                                    Valor = "Criar Usuário"
                                },
                                new
                                {
                                    PermissaoId = new Guid("9f688e0a-a29f-4713-be45-c2a25df474b1"),
                                    Tipo = "Usuário",
                                    Valor = "Atualizar Usuário"
                                },
                                new
                                {
                                    PermissaoId = new Guid("a6eb8dd5-cfe6-4154-8a29-f3cf66dc5cd0"),
                                    Tipo = "Usuário",
                                    Valor = "Excluir Usuário"
                                });
                        });
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.TokenRedefinicaoSenha", b =>
                {
                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Usuario", b =>
                {
                    b.HasOne("IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.CPF", "CPF", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Digitos")
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
                                    Endereco = "adminfake@mozej.com"
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

                            b1.HasData(
                                new
                                {
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b")
                                });
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
                                    PrimeiroNome = "Admin",
                                    Sobrenome = "Fake"
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b")
                                });
                        });

                    b.OwnsOne("IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects.Senha", "Senha", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId");

                            b1.Property<string>("Caracteres")
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
                                    Caracteres = "ABVrq8U9AvkSPMDrPsFcL8ZtINCALRi3S8lYCOpFJ/rSGdec96oOqy6uNT6QybcalQ=="
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
                                    UsuarioId = new Guid("2b630a43-a4bc-4673-8bfc-e81e2eb6b89b"),
                                    Tipo = "Masculino"
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
