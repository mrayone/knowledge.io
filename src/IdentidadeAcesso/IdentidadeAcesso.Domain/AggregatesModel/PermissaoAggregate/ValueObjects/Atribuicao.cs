﻿using System;
using IdentidadeAcesso.Domain.SeedOfWork;

namespace IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.ValueObjects
{
    public class Atribuicao : ValueObject<Atribuicao>
    {
        public string Valor { get; private set; }
        public string Tipo { get; private set; }

        public Atribuicao(string valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }

        protected override bool EqualsCore(Atribuicao other)
        {
            return Valor.Equals(other.Valor);
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                var hash = (Valor.GetHashCode() * 907) ^ Valor.GetHashCode();

                return hash;
            }
        }
    }
}