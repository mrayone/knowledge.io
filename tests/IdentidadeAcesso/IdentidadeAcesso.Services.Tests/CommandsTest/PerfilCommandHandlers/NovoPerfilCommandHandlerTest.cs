﻿using FluentAssertions;
using IdentidadeAcesso.API.Application.Commands.PerfilCommands;
using IdentidadeAcesso.API.Application.Commands.PerfilCommands.Handlers;
using IdentidadeAcesso.API.Application.DomainEventHandlers.DomainNotifications;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.ValueObjects;
using IdentidadeAcesso.Domain.SeedOfWork;
using IdentidadeAcesso.Domain.SeedOfWork.Interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using IdentidadeAcesso.Services.UnitTests.CommandsTest.PerfilCommandHandlers.Builder;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IdentidadeAcesso.Services.Tests.CommandsTest.PerfilCommandHandlers
{
    public class NovoPerfilCommandHandlerTest
    {

        private readonly Mock<IMediator> _mediator;
        private readonly Mock<IPerfilRepository> _perfilRepositoryMock;
        private readonly Mock<IUnitOfWork> _uow;
        private readonly Mock<IPerfilService> _perfilService;
        private readonly DomainNotificationHandler _notifications;
        private readonly IList<Perfil>_listMock;
        private readonly CriarPerfilCommandHandler _handler;

        public NovoPerfilCommandHandlerTest()
        {
            _mediator = new Mock<IMediator>();
            _perfilRepositoryMock = new Mock<IPerfilRepository>();
            _uow = new Mock<IUnitOfWork>();
            _perfilService = new Mock<IPerfilService>();
            _notifications = new DomainNotificationHandler();

            _listMock = new List<Perfil>()
            { 
                TestBuilder.PerfilFalso()
            };

            _perfilRepositoryMock.Setup(perfil => perfil.ObterPorIdAsync(It.IsAny<Guid>())).ReturnsAsync(TestBuilder.PerfilFalso());
            _handler = new CriarPerfilCommandHandler(_mediator.Object, _perfilRepositoryMock.Object, _perfilService.Object, _uow.Object, _notifications);
        }

        [Fact(DisplayName = "O Handle deve disparar evento se um perfil com mesmo nome ja existir.")]
        [Trait("Handler - Perfil", "NovoPerfil")]
        public async Task Handle_deve_disparar_evento_se_um_perfil_como_mesmo_nome_ja_existir()
        {
            var command = TestBuilder.FalsoAtualizarPerfilRequestComNomeExistente();
            _perfilRepositoryMock.Setup(perfil => perfil.Buscar(It.IsAny<Expression<Func<Perfil, bool>>>()))
             .ReturnsAsync(_listMock);
            _uow.Setup(u => u.Commit()).ReturnsAsync(CommandResponse.Fail);

            var cancelToken = new System.Threading.CancellationToken();

            //act
            var result = await _handler.Handle(command, cancelToken);

            //assert
            _mediator.Verify(m => m.Publish(It.IsAny<DomainNotification>(), default), Times.Once());
            result.Success.Should().BeFalse();
        }


        [Fact(DisplayName = "O Handle deve persistir um perfil com sucesso.")]
        [Trait("Handler - Perfil", "NovoPerfil")]
        public async Task Handle_deve_persistir_um_perfil_com_sucesso()
        {
            var command = TestBuilder.FalsoPerfilRequestOk();
            _uow.Setup(u => u.Commit()).ReturnsAsync(CommandResponse.Ok);
            
            var cancelToken = new System.Threading.CancellationToken();

            //act
            var result = await _handler.Handle(command, cancelToken);

            //assert
            result.Success.Should().BeTrue();
        }
    }
}
