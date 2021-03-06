﻿using IdentidadeAcesso.API.Application.Validations.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Commands.UsuarioCommands
{
    public class NovoUsuarioCommand : BaseUsuarioCommand<NovoUsuarioCommand>
    {
        public NovoUsuarioCommand(string nome, string sobrenome, string sexo, string email, string cpf, DateTime dataDeNascimento, string telefone, string celular, 
            string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado, Guid perfilId)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Sexo = sexo;
            Email = email;
            CPF = cpf;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Celular = celular;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            PerfilId = perfilId;
        }
    }
}
