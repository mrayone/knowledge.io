﻿using IdentidadeAcesso.API.Application.Commands.PerfilCommands;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentidadeAcesso.Services.UnitTests.CommandsTest.PerfilCommandHandlers.Builder
{
    public class TestBuilder
    {
        public static Perfil PerfilFalso()
        {
            var identificacao = new Identificacao("Perfil RH 01", "Perfil de acesso nível 1");
            return new Perfil(identificacao);
        }

        public static Perfil PerfilFalsoComPermissoes()
        {
            var identificacao = new Identificacao("Perfil RH 01", "Perfil de acesso nível 1");
            var perfil = new Perfil(identificacao);

            perfil.AssinarPermissao(Guid.NewGuid());
            perfil.AssinarPermissao(Guid.NewGuid());

            return perfil;
        }

        public static CriarPerfilCommand FalsoPerfilRequestComPermissoes()
        {
            return new CriarPerfilCommand(
                nome: "1",
                descricao: "a",
                status: true
                );
        }

        public static AtualizarPerfilCommand FalsoAtualizarPerfilRequestComPermissoes()
        {
            return new AtualizarPerfilCommand(
                id: Guid.NewGuid(),
                nome: "1",
                descricao: "a",
                status: true
                );
        }

        public static CriarPerfilCommand FalsoAtualizarPerfilRequestComNomeExistente()
        {
            return new CriarPerfilCommand(
                nome: "Perfil RH 01",
                descricao: "Perfil de acesso nível 1",
                status: true
                );
        }

        public static AtualizarPerfilCommand FalsoPerfilRequestComNomeExistente()
        {
            return new AtualizarPerfilCommand(
                id: Guid.NewGuid(),
                nome: "Perfil RH 01",
                descricao: "Perfil de acesso nível 1",
                status: true
                );
        }



        public static AtualizarPerfilCommand AtualizarPerfilFalsoRequestComPermissoes()
        {
            return new AtualizarPerfilCommand(
                id: Guid.NewGuid(),
                nome: "Perfil RH 01",
                descricao: "Perfil de acesso nível 1",
                status: true
                );
        }

        public static CriarPerfilCommand FalsoPerfilRequestOk()
        {
            return new CriarPerfilCommand(
                nome: "Perfil RH 02",
                descricao: "Perfil de acesso nível 1",
                status: true
                );
        }

        public static AtualizarPerfilCommand AtualizarPerfilRequestOk()
        {
            return new AtualizarPerfilCommand(
                id: Guid.NewGuid(),
                nome: "Perfil RH 02",
                descricao: "Perfil de acesso nível 1",
                status: true
                );
        }
    }
}
