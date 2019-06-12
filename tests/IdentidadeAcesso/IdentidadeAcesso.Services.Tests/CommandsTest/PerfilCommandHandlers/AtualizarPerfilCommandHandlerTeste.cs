﻿using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Repository;
using IdentidadeAcesso.Domain.SeedOfWork.interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using IdentidadeAcesso.Services.UnitTests.CommandsTest.PerfilCommandHandlers.Builders;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentidadeAcesso.Services.UnitTests.CommandsTest.PerfilCommandHandlers
{
    public class AtualizarPerfilCommandHandlerTeste
    {
        private readonly Mock<IMediator> _mediator;
        private readonly Mock<IPerfilRepository> _perfilRepositoryMock;
        private readonly Mock<IUnitOfWork> _uow;
        private readonly Mock<DomainNotificationHandler> _notifications;

        public AtualizarPerfilCommandHandlerTeste()
        {
            _mediator = new Mock<IMediator>();
            _perfilRepositoryMock = new Mock<IPerfilRepository>();
            _uow = new Mock<IUnitOfWork>();
            _notifications = new Mock<DomainNotificationHandler>();


            _perfilRepositoryMock.Setup(perfil => perfil.BuscarPorNome(TestBuilder.PerfilFalso().Identifacao.Nome)).Returns(TestBuilder.PerfilFalso());

            _perfilRepositoryMock.Setup(perfil => perfil.ObterPorId(It.IsAny<Guid>())).Returns(TestBuilder.PerfilFalso());
        }
    }
}
