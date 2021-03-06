﻿using IdentidadeAcesso.Domain.AggregatesModel.PerfilAggregate;
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Domain.SeedOfWork.Interfaces
{
    public interface IPermissaoService
    {
        Task<bool> DeletarPermissaoAsync(Permissao permissao);
    }
}
