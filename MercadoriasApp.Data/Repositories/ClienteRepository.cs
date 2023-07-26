using ContasApp.Data.Entities;
using ContasApp.Data.Settings;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContasApp.Data.Repositories
{
    /// <summary>
    /// Classe para operações de banco de dados da tabela de Cliente
    /// </summary>
    public class ClienteRepository
    {
        /// <summary>
        /// Método para cadastrar um cliente no banco de dados
        /// </summary>
        public void Add(Cliente cliente)
        {
            var query = @"
             INSERT INTO CLIENTE(
             ID,
             NOME,
             EMAIL,
             SENHA,

             DATAHORACRIACAO)
             VALUES(
             @Id,
             @Nome,
             @Email,
             @Senha,
             @DataHoraCriacao)
";
            //abrindo conexão com o banco de dados..
            using (var connection = new SqlConnection

            (SqlServerSettings.GetConnectionString()))

            {
                //executando o comando SQL no banco de dados
                connection.Execute(query, cliente);
            }
        }

        /// <summary>
        /// Método para atualizar os dados do cliente no banco de dados
        /// </summary>
        public void Update (Cliente cliente)
        {
            var query = @"
             UPDATE CLIENTE
             SET
             NOME = @Nome,
             EMAIL = @Email,
             SENHA = @Senha

             WHERE
             ID = @Id
";
            using (var connection = new SqlConnection
            (SqlServerSettings.GetConnectionString()))

            {
                connection.Execute(query, cliente);
            }
        }
        /// <summary>
        /// Método para excluir um cliente do banco de dados
        /// </summary>
        public void Delete(Cliente cliente)
        {
            var query = @"
             DELETE FROM CLIENTE
             WHERE ID = @Id
";
            using (var connection = new SqlConnection
            (SqlServerSettings.GetConnectionString()))

            {
                connection.Execute(query, cliente);
            }
        }

        /// <summary>
        /// Método para consultar 1 cliente no banco de dados através do ID
        /// </summary>
        public Cliente? GetById(Guid id)
        {
            var query = @"
             SELECT * FROM CLIENTE
             WHERE ID = @Id
";
            using (var connection = new SqlConnection
            (SqlServerSettings.GetConnectionString()))

            {
                return connection.Query<Cliente>

                (query, new { @Id = id }).FirstOrDefault();

            }
        }

        /// <summary>
        /// Método para consultar 1 cliente no
        /// banco de dados através do Email
        /// </summary>
        public Cliente? GetByEmail(string email)
        {
            var query = @"
             SELECT * FROM CLIENTE
             WHERE EMAIL = @Email
";
            using (var connection = new SqlConnection
            (SqlServerSettings.GetConnectionString()))

            {
                return connection.Query<Cliente>(query,
                new { @Email = email }).FirstOrDefault();

            }
        }

        /// <summary>
        /// Método para consultar 1 cliente no banco
        ///de dados através do Email e da Senha
        /// </summary>
        public Cliente? GetByEmailAndSenha(string email, string senha)
        {
            var query = @"
             SELECT * FROM CLIENTE 
             WHERE EMAIL = @Email
             AND SENHA = @Senha

";
            using (var connection = new SqlConnection
            (SqlServerSettings.GetConnectionString()))

            {
                return connection.Query<Cliente>(query,

                new { @Email = email, @Senha = senha }).FirstOrDefault();

            }
        }
    }
}