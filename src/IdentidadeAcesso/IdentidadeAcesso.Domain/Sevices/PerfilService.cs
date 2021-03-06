﻿using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Repository;
using IdentidadeAcesso.Domain.SeedOfWork.Interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Domain.Sevices
{
    public sealed class PerfilService : IPerfilService
    {
        private readonly IPerfilRepository _perfilRepo;
        private readonly IMediator _mediator;
        private readonly IPermissaoRepository _permissaoRepo;
        private readonly IUsuarioRepository _usuarioRepo;

        public PerfilService(IPerfilRepository perfilRepo, IPermissaoRepository permissaoRepo, IUsuarioRepository usuarioRepository,
            IMediator mediator)
        {
            _perfilRepo = perfilRepo;
            _mediator = mediator;
            _permissaoRepo = permissaoRepo;
            _usuarioRepo = usuarioRepository;
        }

        public async Task<Perfil> AtribuirPermissaoAsync(Perfil perfil, Guid permissaoId)
        {
            var permissao = await _permissaoRepo.ObterPorIdAsync(permissaoId);

            if (permissao == null)
            {
                await _mediator.Publish(new DomainNotification(GetType().Name, "Permissão não encontrada."));

            }
            else
            {
                perfil.AssinarPermissao(permissao.Id);
            }

            return await Task.FromResult(perfil);
        }

        public async Task<Perfil> RevogarPermissaoAsync(Perfil perfil, Guid permissaoId)
        {
            var permissao = await _permissaoRepo.ObterPorIdAsync(permissaoId);

            if (permissao == null)
            {
                await _mediator.Publish(new DomainNotification(GetType().Name, "Permissão não encontrada."));

            }
            else
            {
                perfil.CancelarPermissao(permissao.Id);
            }

            return await Task.FromResult(perfil);
        }

        public async Task<bool> DeletarPerfilAsync(Perfil perfil)
        {
            var usuariosComPerfil = await _usuarioRepo.Buscar(u => u.PerfilId == perfil.Id);
            if (usuariosComPerfil.Any())
            {
                await _mediator.Publish(new DomainNotification(GetType().Name, "O perfil esta em uso e não pode ser deletado."));
                return await Task.FromResult(false);
            }

            if(perfil.Atribuicoes.Any())
            {
                perfil.Deletar();
                _perfilRepo.Atualizar(perfil);
                return await Task.FromResult(true);
            }

            _perfilRepo.Deletar(perfil);
            return await Task.FromResult(true);
        }
    }
}
