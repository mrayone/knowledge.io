﻿using FluentAssertions;
using IdentidadeAcesso.API.Application.DomainEventHandlers.DomainNotifications;
using IdentidadeAcesso.API.Application.Models;
using IdentidadeAcesso.API.Application.Queries;
using IdentidadeAcesso.API.Controllers;
using IdentidadeAcesso.Domain.SeedOfWork;
using IdentidadeAcesso.Domain.SeedOfWork.Interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IdentidadeAcesso.Services.UnitTests.ControllersTest
{
    public class UsuarioControllerTest
    {
        private readonly Mock<IMediator> _mediator;
        private readonly DomainNotificationHandler _notifications;
        private readonly UsuariosController _controller;
        public UsuarioControllerTest()
        {
            _mediator = new Mock<IMediator>();
            _notifications = new DomainNotificationHandler();

            _controller = new UsuariosController(_mediator.Object,
                _notifications, new Mock<IHttpContextAccessor>().Object);
        }

        [Trait("Controller","UsuariosController")]
        [Fact(DisplayName = "Deve retornar lista de usuários cadastrados.")]
        public async Task Deve_Retornar_Lista_De_Usuarios_Cadastrados()
        {
            //arrange
            var list = new List<UsuarioViewModel>()
            {
                ViewModelBuilder.UsuarioFake(),
                ViewModelBuilder.UsuarioFake(),
                ViewModelBuilder.UsuarioFake(),
            };
            _mediator.Setup(s => s.Send(It.IsAny<IRequest<IEnumerable<UsuarioViewModel>>>(), new System.Threading.CancellationToken()))
                .ReturnsAsync(list).Verifiable();
            //act
            var result = await _controller.GetUsuariosAsync();

            //assert
            result.Should().BeAssignableTo<OkObjectResult>();
            var vr = result as OkObjectResult;
            vr.Value.Should().Be(list);
            vr.StatusCode.Should().Be(StatusCodes.Status200OK);
            _mediator.Verify();
        }

        [Trait("Controller", "UsuariosController")]
        [Fact(DisplayName = "Deve retonar um usuário ao passar o Id por parametro.")]
        public async Task Deve_Retornar_Um_Usuario_Ao_Passar_O_Id_Por_Parametro()
        {
            //arrange
            var usuarioFake = ViewModelBuilder.UsuarioFake();
            _mediator.Setup(s => s.Send(It.IsAny<IRequest<UsuarioViewModel>>(), new System.Threading.CancellationToken()))
                .ReturnsAsync(usuarioFake);
            //act
            var result = await _controller.GetUsuarioAsync(Guid.NewGuid());

            //assert
            result.Should().BeAssignableTo<OkObjectResult>();
            var vr = result as OkObjectResult;
            vr.Value.Should().Be(usuarioFake);
            vr.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact(DisplayName = "Deve cadastrar novo usuário e retornar ok.")]
        [Trait("Controller", "UsuariosController")]
        public async Task Deve_Cadastrar_Novo_Usuario_E_Retornar_Ok()
        {
            //arrange
            var usuario = ViewModelBuilder.UsuarioCommand();
            _mediator.Setup(s => s.Send(It.IsAny<IRequest<CommandResponse>>(), new System.Threading.CancellationToken()))
                .ReturnsAsync(CommandResponse.Ok).Verifiable();
            //act
            var result = await _controller.CriarUsuarioAsync(usuario);

            //assert
            result.Should().BeAssignableTo<OkResult>();
            var vr = result as OkResult;
            vr.StatusCode.Should().Be(StatusCodes.Status200OK);
            _mediator.Verify();
        }

        [Fact(DisplayName = "Deve atualizar usuário e retornar ok.")]
        [Trait("Controller", "UsuariosController")]
        public async Task Deve_Atualizar_Usuario_E_Retornar_Ok()
        {
            //arrange
            var usuario = ViewModelBuilder.AtualizarUsuarioCommand();
            _mediator.Setup(s => s.Send(It.IsAny<IRequest<CommandResponse>>(), new System.Threading.CancellationToken()))
                .ReturnsAsync(CommandResponse.Ok).Verifiable();
            //act
            var result = await _controller.AtualizarUsuarioAsync(usuario);

            //assert
            result.Should().BeAssignableTo<OkResult>();
            var vr = result as OkResult;
            vr.StatusCode.Should().Be(StatusCodes.Status200OK);
            _mediator.Verify();
        }
    }
}
