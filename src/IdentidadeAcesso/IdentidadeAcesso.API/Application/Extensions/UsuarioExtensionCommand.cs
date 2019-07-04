﻿using IdentidadeAcesso.API.Application.Commands.UsuarioCommands;
using IdentidadeAcesso.API.Application.Commands.UsuarioCommands.Handlers;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects;
using IdentidadeAcesso.Domain.SeedOfWork.Commands.CommandHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Extensions
{
    public static class UsuarioExtensionCommand
    {
        public static Usuario DefinirUsuario<T>(this CommandHandler command, BaseUsuarioCommand<T> request) where T : BaseUsuarioCommand<T>
        {
            var nome = new NomeCompleto(request.Nome, request.Sobrenome);
            var sexo = request.Sexo.Equals("M") ? Sexo.Masculino : Sexo.Feminino;
            var email = new Email(request.Email);
            var cpf = new CPF(request.CPF);
            var dataNascimento = new DataDeNascimento(request.DateDeNascimento);
            var endereco = new Endereco(request.Logradouro, request.Numero, request.Bairro, request.Cidade, request.Estado, request.Complemento);
            var celular = new Celular(request.Celular);
            var telefone = request.Telefone == null ? null : new Telefone(request.Telefone);
            var usuario = Usuario.UsuarioFactory.CriarUsuario(request.Id, nome, sexo, email, cpf, dataNascimento,
                request.PerfilId, celular, telefone, endereco);

            return usuario;
        }
    }
}