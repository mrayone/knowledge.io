﻿using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentidadeAcesso.Domain.Events.PermissaoEvents
{
    public class PermissaoCriadaEvent : INotification
    {
        public PermissaoCriadaEvent(Permissao permissao)
        {
            Permissao = permissao;
        }

        public Permissao Permissao { get; private set; }
    }
}
