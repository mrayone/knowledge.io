﻿using Dapper;
using IdentidadeAcesso.API.Application.Models;
using Knowledge.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace IdentidadeAcesso.API.Application.Queries
{
    public class UsuarioQueries : IUsuarioQueries
    {
        private readonly IdentidadeAcessoDbContext _context;

        public UsuarioQueries(IdentidadeAcessoDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<UsuarioViewModel> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UsuarioViewModel>> ObterTodosAsync()
        {
            using (var connection = _context.Database.GetDbConnection())
            {
                var sql = @"SELECT [Id]
                              ,[PrimeiroNome]
                              ,[Sobrenome]
                              ,[Sexo]
                              ,[Email]
                              ,[CPF_Digitos]
                              ,[DataDeNascimento_Data]
                              ,[Telefone_Numero]
                              ,[Celular_Numero]
                              ,[Status_Valor]
                              ,[DeletadoEm]
                              ,[PerfilId]
                          FROM [usuarios]";

                var query = await connection.QueryAsync<UsuarioViewModel>(sql);

                return query;
            }
        }
    }
}
