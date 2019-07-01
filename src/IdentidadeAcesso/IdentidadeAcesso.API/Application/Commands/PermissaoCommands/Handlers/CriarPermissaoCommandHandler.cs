﻿using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.ValueObjects;
using IdentidadeAcesso.Domain.Events.PermissaoEvents;
using IdentidadeAcesso.Domain.SeedOfWork.Commands.CommandHandler;
using IdentidadeAcesso.Domain.SeedOfWork.interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Commands.PermissaoCommands.Handlers
{
    public class CriarPermissaoCommandHandler : CommandHandler, IRequestHandler<CriarPermissaoCommand, bool>
    {
        private readonly IPermissaoRepository _permissaoRepository;
        private readonly IMediator _mediator;

        public CriarPermissaoCommandHandler(IMediator mediator, IUnitOfWork unitOfWork,
            INotificationHandler<DomainNotification> notifications, IPermissaoRepository permissaoRepository) : base(mediator, unitOfWork, notifications)
        {
            _permissaoRepository = permissaoRepository;
            _mediator = mediator;
        }

        public async Task<bool> Handle(CriarPermissaoCommand request, CancellationToken cancellationToken)
        {
            if (!ValidarCommand(request)) return await Task.FromResult(false);

            var permissaoBusca = await _permissaoRepository.Buscar(p => p.Atribuicao.Tipo == request.Tipo && p.Atribuicao.Valor == request.Valor);
            if(permissaoBusca.Any())
            {
                await _mediator.Publish(new DomainNotification(request.GetType().Name, $"Uma permissão com Tipo {request.Tipo} e Valor {request.Valor} já foi cadastrada. "));
                return await Task.FromResult(false);
            }

            var permissao = DefinirPermissao(request);

            _permissaoRepository.Adicionar(permissao);

            if(await Commit())
            {
                await _mediator.Publish(new PermissaoCriadaEvent(permissao));
            }

            return await Task.FromResult(true);
        }

        private Permissao DefinirPermissao(CriarPermissaoCommand request)
        {
            var atr = new Atribuicao(request.Tipo, request.Valor);
            return new Permissao(atr);
        }
    }
}