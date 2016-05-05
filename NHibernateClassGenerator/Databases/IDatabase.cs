using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace NHibernateClassGenerator.Databases
{
    public interface IDatabase
    {
        string StringConexao { get; set; }

        /// <summary>
        /// Abre uma conexão com o banco de dados
        /// </summary>
        /// <returns>Objeto SqlConnection</returns>
        DbConnection OpenConnection();

        /// <summary>
        /// Verifica se o banco está em transação
        /// </summary>
        bool InTransaction { get; }

        /// <summary>
        /// Verifica se o banco está aberto
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>        
        void CloseConnection();

        /// <summary>
        /// Adiciona um parâmetro à lista de parâmetros
        /// </summary>
        /// <param name="nomeParametro">Nome do parâmetro</param>
        /// <param name="tipoParametro">Tipo do parâmetro</param>
        /// <param name="valor">Valor do parâmetro</param>
        void AddParam(string nomeParametro, DbType tipoParametro, object valor);

        /// <summary>
        /// Executa um begin transaction
        /// </summary>
        /// <param name="isolation">Nível de isolamento</param>
        void BeginTransaction(IsolationLevel isolation);

        /// <summary>
        /// Executa um commit
        /// </summary>
        void Commit();

        /// <summary>
        /// Executa um rollback
        /// </summary>
        void Rollback();

        /// <summary>
        /// Retorna um valor do banco de dados
        /// </summary>
        /// <param name="queryString">String com o comando select a ser executado</param>                
        /// <param name="parametros">Lista com os parâmetros da query</param> 
        /// <param name="fechaConexao">Indica se a conexão deve ser fechada após a execução do comando</param> 
        /// <returns></returns>
        // public object ExecuteScalar(string queryString, Param parametros, bool fechaConexao)
        object ExecuteScalar(string queryString, bool fechaConexao);

        /// <summary>
        /// Executa um comando SQL
        /// </summary>
        /// <param name="queryString">String com o comando select a ser executado</param>                
        /// <param name="parametros">Lista com os parâmetros da query</param> 
        /// <param name="fechaConexao">Indica se a conexão deve ser fechada após a execução do comando</param> 
        /// <returns></returns>
        // public int ExecuteNonQuery(string queryString, Param parametros, bool fechaConexao)
        int ExecuteNonQuery(string queryString, bool fechaConexao, bool utilizarTransaction);

        int ExecuteNonQuery(string queryString, bool fechaConexao);

        /// <summary>
        /// Seleciona dados do banco de dados
        /// </summary>
        /// <param name="queryString">String com o comando select a ser executado</param>
        /// <param name="parametros">Lista com os parâmetros da query</param>
        /// <returns>DataTable com as informações</returns>
        DataTable Select(string queryString, bool fechaConexao);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        int Update(string query);
    }
}
