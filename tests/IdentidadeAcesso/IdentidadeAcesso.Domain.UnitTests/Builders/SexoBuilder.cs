﻿using IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects;
using System;

namespace IdentidadeAcesso.Domain.UnitTests.Builders
{
    public class SexoBuilder
    {
        public static Sexo ObterSexoInvalido()
        {
            return new Sexo("R", "Retângulo");
        }
    }
}