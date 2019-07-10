﻿using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Repository;
using IdentidadeAcesso.Domain.SeedOfWork.interfaces;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Domain.Sevices
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IPerfilRepository _perfilRepository;
        private readonly IUsuarioRepository _repository;
        private readonly IMediator _mediator;

        public UsuarioService(IUsuarioRepository repository, IPerfilRepository perfilRepository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
            _perfilRepository = perfilRepository;
        }

        public async Task<bool> VincularAoPerfilAsync(Guid perfilId, Usuario usuario)
        {
            var perfil = await _perfilRepository.ObterPorId(perfilId);

            if (perfil == null)
            {
                await _mediator.Publish(new DomainNotification(GetType().Name, "O Perfil fornecido para definir ao usuário não foi encontrado."));
            }
            else
            {
                usuario.SetarPerfil(perfil.Id);
                return true;
            }

            return false;
        }

        public async Task<Usuario> DeletarUsuarioAsync(Guid usuarioId)
        {
            var usuario = await _repository.ObterPorId(usuarioId);

            if (usuario == null)
            {
                await _mediator.Publish(new DomainNotification(GetType().Name, "Não foi possível localizar este usuário."));
                return null;
            }

            usuario.Deletar();

            _repository.Atualizar(usuario);

            return await Task.FromResult(usuario);
        }

        public async Task<Usuario> DesativarUsuarioAsync(Guid usuarioId)
        {
            var usuario = await _repository.ObterPorId(usuarioId);

            if(usuario == null)
            {
                await _mediator.Publish(new DomainNotification(GetType().Name, "Não foi possível localizar este usuário."));
                return null;
            }

            usuario.DesativarUsuario();

            return await Task.FromResult(usuario);
        }
    }
}
