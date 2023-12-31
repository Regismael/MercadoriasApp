﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContasApp.Data.Settings
{
    /// <summary>
    /// Classe para armazenar a string de conexão do banco de dados
    /// </summary>
    public class SqlServerSettings
    {
        /// <summary>
        /// Método para retornar a string de conexão do banco de dados
        /// </summary>
        public static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDMercadoriasApp;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        }
    }
}