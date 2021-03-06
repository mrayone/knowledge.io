﻿using System;
using System.Text.RegularExpressions;
using IdentidadeAcesso.Domain.SeedOfWork;

namespace IdentidadeAcesso.Domain.AggregatesModel.UsuarioAggregate.ValueObjects
{
    public class Endereco : ValueObject<Endereco>
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public Endereco(string logradouro, string numero, 
            string bairro, string cep, string cidade, string estado, string complemento = "")
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        protected override bool EqualsCore(Endereco other)
        {
            return Logradouro.Equals(other.Logradouro)
                && Numero.Equals(other.Numero)
                && Complemento.Equals(other.Complemento)
                && Bairro.Equals(other.Bairro)
                && Cep.Equals(other.Cep)
                && Cidade.Equals(other.Cidade)
                && Estado.Equals(other.Estado);
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                var hash = Logradouro.GetHashCode();
                hash += (Numero.GetHashCode() * 907) ^ Numero.GetHashCode();
                hash += (Complemento.GetHashCode() * 907) ^ Complemento.GetHashCode();
                hash += (Bairro.GetHashCode() * 907) ^ Bairro.GetHashCode();
                hash += (Cep.GetHashCode() * 907) ^ Cep.GetHashCode();
                hash += (Cidade.GetHashCode() * 907) ^ Cidade.GetHashCode();
                hash += (Estado.GetHashCode() * 907) ^ Estado.GetHashCode();

                return hash;
            }
        }
    }
}