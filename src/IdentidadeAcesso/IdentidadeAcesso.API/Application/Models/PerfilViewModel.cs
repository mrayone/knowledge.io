﻿using IdentidadeAcesso.API.Application.Commands.PerfilCommands;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace IdentidadeAcesso.API.Application.Models
{
    public class PerfilViewModel : IQueryModel
    {
        public PerfilViewModel()
        {
            Atribuicoes = new List<AtribuicaoDTO>();
        }

        public Guid Id { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição deve ser informada.")]
        public string Descricao { get; set; }

        [BindNever]
        public IList<AtribuicaoDTO> Atribuicoes { get; set; }
    }

    public class NivelDeAcessoViewModel
    {
        public Guid PerfilId { get; set; }
        public IList<AtribuicaoDTO> Atribuicoes { get; set; }
    }
}