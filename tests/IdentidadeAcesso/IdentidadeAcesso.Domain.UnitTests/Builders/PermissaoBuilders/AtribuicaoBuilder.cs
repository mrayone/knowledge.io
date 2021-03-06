﻿
using IdentidadeAcesso.Domain.AggregatesModel.PermissaoAggregate.ValueObjects;
using System;

namespace IdentidadeAcesso.Domain.UnitTests.Builders.PermissaoBuilders
{
    public class AtribuicaoBuilder
    {
        public static Atribuicao ObterAtribuicaoNula()
        {
            return new Atribuicao(null, null);
        }

        public static Atribuicao ObterAtribuicaoEmBranco()
        {
            return new Atribuicao("", "");
        }

        public static Atribuicao ObterAtribuicaoValida()
        {
            return new Atribuicao("Usuário", "Atualizar");
        }
    }
}