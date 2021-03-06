﻿using FluentValidation;
using IdentidadeAcesso.API.Application.Commands.PerfilCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Validations.Perfil
{
    public class AtualizarPerfilCommandValidation : ValidacaoPerfil<AtualizarPerfilCommand>
    {
        public AtualizarPerfilCommandValidation() : base()
        {
            RuleFor(command => command.Id).NotEqual(Guid.Empty);
            RuleFor(command => command.Descricao).NotNull();
        }
    }
}
