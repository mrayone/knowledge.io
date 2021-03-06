﻿using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentidadeAcesso.Infra.Data.Context.Seed
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permissao>(p =>
            {
                p.HasData(new
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
                }
                );
                p.OwnsOne(prop => prop.Atribuicao)
                .HasData(
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

            modelBuilder.Entity<Perfil>(p =>
            {
                p.HasData(new
                {
                    Id = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709")
                });

                p.OwnsOne(prop => prop.Identifacao)
                .HasData(
                        new
                        {
                            PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                            Nome = "Administrador",
                            Descricao = "Perfil de super usuário"
                        });
            });
            modelBuilder.Entity<AtribuicaoPerfil>(p => 
            {
                p.HasData(new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("4cf679e7-ef92-49e4-b677-2ec8d4e91453"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("99e90c66-a791-42d6-a24a-f4bc1235a576"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("20f04a05-7732-428c-a5f2-1a5765256808"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("f40ed114-8191-4621-8836-21aaf60eecf4"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("0440c348-12c2-435a-a027-f81636e71faa"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("1503b73e-4db3-4122-ac1f-b8ce7a0214ee"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("170a49c2-5f0f-4552-b8cc-bf679e96bcbe"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("cec6f99f-4c3f-483c-ba53-954d79a553e0"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("fc7cc8f8-0fd8-4067-ba34-f8c06e02f57c"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("f2c056c9-9320-492e-9d6a-563bd5788a8a"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("e8d085f3-ebc1-4bc1-83c7-1cdc41d3dc49"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("bc6e96ae-c6af-40ca-8c11-cd11fb8a3e27"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("9f688e0a-a29f-4713-be45-c2a25df474b1"),
                    Status =  true,
                },new
                {
                    Id = Guid.NewGuid(),
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    PermissaoId = new Guid("a6eb8dd5-cfe6-4154-8a29-f3cf66dc5cd0"),
                    Status =  true,
                });
            });
            modelBuilder.Entity<Usuario>(u => 
            {
                var uId = Guid.NewGuid();
                u.HasData(new
                {
                    Id = uId,
                    PerfilId = new Guid("8cd6c8ca-7db7-4551-b6c5-f7a724286709"),
                    Status =  true
                });

                u.OwnsOne(p => p.CPF).HasData(new
                {
                    UsuarioId = uId,
                    Digitos = "28999953084"
                });

                u.OwnsOne(p => p.Sexo).HasData(new
                {
                    UsuarioId = uId,
                    Tipo = "Masculino"
                });

                u.OwnsOne(p => p.DataDeNascimento).HasData(new
                {
                    UsuarioId = uId,
                    Data = new DateTime(1993, 7, 22)
                });

                u.OwnsOne(p => p.Email).HasData(new
                {
                    UsuarioId = uId,
                    Endereco = "adminfake@mozej.com"
                });

                u.OwnsOne(p => p.Nome).HasData(new
                {
                    UsuarioId = uId,
                    PrimeiroNome = "Admin",
                    Sobrenome = "Fake"
                });

                u.OwnsOne(p => p.Senha).HasData(new
                {
                    UsuarioId = uId,
                    Caracteres = Senha.GerarSenha("123456@IO").Caracteres.ToString()
                });

                u.OwnsOne(p => p.NumerosContato).HasData(new { UsuarioId = uId });

                u.OwnsOne(p => p.Endereco).HasData(new { UsuarioId = uId });
            });
        }
    }
}
