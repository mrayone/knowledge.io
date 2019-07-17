﻿using IdentidadeAcesso.API.Application.Commands.PerfilCommands;
using IdentidadeAcesso.API.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentidadeAcesso.Services.UnitTests.ControllersTest
{
    public static class ViewModelBuilder
    {
        public static PermissaoViewModel PermissaoViewFake()
        {
            var list = new List<string>()
            {
                "Cadastrar",
                "Excluir",
                "Visualizar",
                "Editar"
            };
            var random = new Random();

            return new PermissaoViewModel()
            {
                Id = Guid.NewGuid(),
                Tipo = "Usuário",
                Valor = list[random.Next(0, 4)]
            };
        }

        internal static UsuarioViewModel UsuarioFake()
        {
            return new UsuarioViewModel()
            {
                Nome = "Fake",
                Sobrenome = "News",
                Sexo = "M",
                DateDeNascimento = new DateTime(1993,7, 22),
                Email = "email@gmail.com",
                Celular = "+5511999948663"
            };
        }
    }
}
