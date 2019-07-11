﻿using FluentAssertions;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.Repository;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.Repository;
using IdentidadeAcesso.Domain.SeedOfWork.Notifications;
using IdentidadeAcesso.Domain.Sevices;
using IdentidadeAcesso.Domain.UnitTests.Builders.PerfilBuilders;
using IdentidadeAcesso.Domain.UnitTests.Builders.PermissaoBuilders;
using IdentidadeAcesso.Domain.UnitTests.Builders.UsuarioBuilders;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IdentidadeAcesso.Domain.UnitTests.Services
{
    public class PerfilServiceTest
    {
        private readonly Mock<IPerfilRepository> _perfilRepo;
        private readonly Mock<IPermissaoRepository> _permRepo;
        private readonly Mock<IUsuarioRepository> _usuRepo;
        private readonly Mock<IMediator> _mediator;
        private readonly PerfilService _perfilService;
        private readonly Perfil _perfil;
        private readonly Usuario _usuario;

        public PerfilServiceTest()
        {
            _perfilRepo = new Mock<IPerfilRepository>();
            _permRepo = new Mock<IPermissaoRepository>();
            _usuRepo = new Mock<IUsuarioRepository>();
            _mediator = new Mock<IMediator>();
            _perfilService = new PerfilService(_perfilRepo.Object, _permRepo.Object, _usuRepo.Object, _mediator.Object);

            _perfil = PerfilBuilder.ObterPerfil();
            _usuario = UsuarioBuilder.ObterUsuarioCompletoValido();

            _perfilRepo.Setup(p => p.ObterPorId(It.IsAny<Guid>())).ReturnsAsync(_perfil);
        }

        [Fact(DisplayName = "Deve cancelar permissões e retornar perfil modificado.")]
        [Trait("Services", "Perfil")]
        public async Task Deve_Cancelar_Permissoes_E_Retornar_Perfil()
        {
            //arrange
            var permissao = PermissaoBuilder.ObterPermissaoFake();
            _perfil.AssinarPermissao(permissao.Id);
            var permissaoAssinadaFake = _perfil.PermissoesAssinadas.Where(p => p.PermissaoId == permissao.Id).Single();
            //act
            var act = await _perfilService.CancelarPermissoesAsync(permissao.Id, _perfil.Id);
            var permissaoAssinada = act.PermissoesAssinadas.Where(p => p.PermissaoId == permissao.Id).SingleOrDefault();
            //assert
            permissaoAssinada.Status.Valor.Should().BeFalse();
        }

        [Fact(DisplayName = "Deve notificar quando tentar cancelar permissão não assinada.")]
        [Trait("Services", "Perfil")]
        public async Task Deve_notificar_quando_permissao_nao_assinada()
        {
            //arrange
            var permissao = PermissaoBuilder.ObterPermissaoFake();
            _permRepo.Setup(p => p.ObterPorId(It.IsAny<Guid>())).ReturnsAsync(permissao);
            //act
            var act = await _perfilService.CancelarPermissoesAsync(_perfil.Id, permissao.Id);
            //assert
            _mediator.Verify(m => m.Publish(It.IsAny<DomainNotification>(),
                new System.Threading.CancellationToken()), Times.Once());
        }


        [Fact(DisplayName = "Deve notificar quando tentar cancelar permissão que não exista.")]
        [Trait("Services", "Perfil")]
        public async Task Deve_notificar_quando_tentar_cancelar_uma_permissao_que_nao_exista()
        {
            //arrange
            var permissao = PermissaoBuilder.ObterPermissaoFake();

            //act
            var act = await _perfilService.CancelarPermissoesAsync(_perfil.Id, permissao.Id);

            //assert
            _mediator.Verify(m => m.Publish(It.IsAny<DomainNotification>(),
                new System.Threading.CancellationToken()), Times.Once());
        }

        [Fact(DisplayName = "Deve deletar perfil e retornar true.")]
        [Trait("Services", "Perfil")]
        public async Task Deve_Deletar_Perfil_e_Retornar_True()
        {
            //arrange
            var perfil = await _perfilRepo.Object.ObterPorId(Guid.NewGuid());
            //act
            var result = await _perfilService.DeletarPerfilAsync(perfil);
            //assert

            result.Should().BeTrue();
            perfil.DeletadoEm.HasValue.Should().BeTrue();
        }

        [Fact(DisplayName = "Deve retornar false se perfil em uso.")]
        [Trait("Services", "Perfil")]
        public async Task Deve_Retornar_False_se_Perfil_Em_Uso()
        {
            //arrange
            var list = new List<Usuario>()
            {
                _usuario
            };
            _usuRepo.Setup(u => u.Buscar(It.IsAny<Expression<Func<Usuario, bool>>>())).ReturnsAsync(list);
            var perfil = PerfilBuilder.ObterPerfil();

            //act
            var result = await _perfilService.DeletarPerfilAsync(perfil);

            //assert
            result.Should().BeFalse();
            perfil.DeletadoEm.HasValue.Should().BeFalse();
            _mediator.Verify(m => m.Publish(It.IsAny<DomainNotification>(),
                 new System.Threading.CancellationToken()), Times.Once());
        }
    }
}
