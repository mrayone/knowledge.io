﻿using IdentidadeAcesso.API.Application.Validations.Perfil;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Commands.PerfilCommands
{
    public class ExcluirPerfilCommand : BasePerfilCommand<ExcluirPerfilCommand>, IRequest<bool>
    {
        public ExcluirPerfilCommand(Guid id)
        {
            Id = id;
        }

        public override bool isValid()
        {
            ValidationResult = new ExcluirPerfilCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
