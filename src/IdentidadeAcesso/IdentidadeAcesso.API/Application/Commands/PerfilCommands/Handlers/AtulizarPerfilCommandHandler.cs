﻿using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.ValueObjects;
using IdentidadeAcesso.Domain.Events.PerfilEvents;
using IdentidadeAcesso.Domain.SeedOfWork.Commands.CommandHandler;
using IdentidadeAcesso.Domain.SeedOfWork.interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Commands.PerfilCommands.Handlers
{
    public class AtulizarPerfilCommandHandler : CommandHandler, IRequestHandler<AtualizarPerfilCommand, bool>
    {
        private readonly IMediator _mediator;
        private readonly IPerfilRepository _perfilRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AtulizarPerfilCommandHandler(IMediator mediator, 
            IPerfilRepository perfilRepository, 
            IUnitOfWork unitOfWork,
            INotificationHandler<DomainNotification> notifications) : base(mediator, unitOfWork, notifications )
        {
            _mediator = mediator;
            _perfilRepository = perfilRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AtualizarPerfilCommand request, CancellationToken cancellationToken)
        {
            if (!ValidarCommand(request)) return await Task.FromResult(false);

            if ( !await PerfilExitente(request)) return await Task.FromResult(false);

            var perfil = DefinirPerfil(request);

            if (!ValidarEntity(perfil)) return await Task.FromResult(false);

            var perfilExistente = _perfilRepository.Buscar(p => p.Identifacao.Nome == request.Nome);
            if (perfilExistente.Any())
            {
                await _mediator.Publish(new DomainNotification(request.GetType().Name, $"Um perfil com o nome {request.Nome} já existe."));
                return await Task.FromResult(false);
            }

            _perfilRepository.Atualizar(perfil);

            if (await Commit())
            {
                await _mediator.Publish(new PerfilAtualizadoEvent(perfil));
            }

            return await Task.FromResult(true);
        }

        private async Task<bool> PerfilExitente(AtualizarPerfilCommand request)
        {
            var perfil = _perfilRepository.ObterPorId(request.Id);
            if (perfil != null) return await Task.FromResult(true);

            await _mediator.Publish(new DomainNotification(request.GetType().Name, "Perfil não encontrado."));
            return await Task.FromResult(true);
        }

        private Perfil DefinirPerfil(AtualizarPerfilCommand request)
        {
            var perfil = Perfil.PerfilFactory.NovoPerfil(request.Id,request.Nome, request.Descricao);

            foreach (var item in request.PermissoesAssinadas)
            {
                perfil.AssinarPermissao(item.PermissaoId);
            }

            return perfil;
        }
    }
}
