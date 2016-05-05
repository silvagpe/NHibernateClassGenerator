using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection;
using System.Xml;
using System.IO;
using NHibernateClassGenerator.Config;
using MySql.Data.MySqlClient;

namespace NHibernateClassGenerator.Databases
{
    public class DB_MySql : IDatabase
    {
        public DB_MySql()
        {
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            path = Path.GetDirectoryName(path);

            ConfigHelper configHelper = new ConfigHelper(path);
            configHelper.Load();

            StringConexao = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                configHelper.Config.IP_Imp,
                configHelper.Config.Banco_Imp,
                configHelper.Config.Usuario_Imp,
                configHelper.Config.Senha_Imp);

            ListaParametros = new List<MySqlParameter>();
            BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        public DB_MySql(string ipServidor, string nomeDatabase, string usuarioBancoDados, string senhaBancoDados, int portaBancoDados)
        {
            StringConexao = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", ipServidor, nomeDatabase, usuarioBancoDados, senhaBancoDados);
            ListaParametros = new List<MySqlParameter>();
            BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        public DB_MySql(string ipServidor, string nomeDatabase, int portaBancoDados, bool conexaoConfiavel)
        {
            StringConexao = String.Format("Data Source={0}; Initial Catalog={1}; Trusted_Connection=True",
                ipServidor,
                (nomeDatabase.Trim() == "" ? "master" : nomeDatabase));
            ListaParametros = new List<MySqlParameter>();
            BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        public DB_MySql(string connstr)
        {
            this.StringConexao = connstr;
            ListaParametros = new List<MySqlParameter>();
            BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        private MySqlConnection Conexao { get; set; }
        public string StringConexao { get; set; }
        private MySqlTransaction Trans { get; set; }
        private List<MySqlParameter> ListaParametros { get; set; }

        public bool InTransaction
        {
            get
            {
                if (Conexao == null)
                    return false;

                if (Trans == null)
                    return false;

                if (Conexao.State == ConnectionState.Open && Trans != null)
                    return true;

                return false;
            }
        }

        public bool IsOpen
        {
            get
            {
                if (Conexao == null)
                    return false;

                if (Trans == null)
                    return false;

                if (Conexao.State == ConnectionState.Open)
                    return true;

                return false;
            }
        }

        /// <summary>
        /// Abre uma conexão com o banco de dados
        /// </summary>
        /// <returns>Objeto MySqlConnection</returns>
        public DbConnection OpenConnection()
        {
            if (Conexao == null)
            {
                Conexao = new MySqlConnection();
            }
            try
            {
                if (Conexao.State != ConnectionState.Open)
                {
                    Conexao.ConnectionString = StringConexao;
                    Conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Conexao;
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>        
        public void CloseConnection()
        {
            if (Conexao != null && Conexao.State == ConnectionState.Open)
            {
                Conexao.Close();
            }
            Conexao = null;
        }

        /// <summary>
        /// Adiciona um parâmetro à lista de parâmetros
        /// </summary>
        /// <param name="nomeParametro">Nome do parâmetro</param>
        /// <param name="tipoParametro">Tipo do parâmetro</param>
        /// <param name="valor">Valor do parâmetro</param>
        public void AddParam(string nomeParametro, DbType tipoParametro, object valor)
        {
            // Remove o parâmetro caso já exista
            for (int i = 0; i < ListaParametros.Count; i++)
            {
                if (ListaParametros[i].ParameterName == nomeParametro)
                {
                    ListaParametros.Remove(ListaParametros[i]);
                }
            }

            // Adiciona o parâmetro
            MySqlParameter param = new MySqlParameter(nomeParametro, tipoParametro);
            param.Value = (valor == null) ? "" : valor;
            ListaParametros.Add(param);
        }

        /// <summary>
        /// Executa um begin transaction
        /// </summary>
        /// <param name="isolation">Nível de isolamento</param>
        public void BeginTransaction(IsolationLevel isolation)
        {
            OpenConnection();
            if (Trans == null)
            {
                Trans = Conexao.BeginTransaction(isolation);
            }
        }

        /// <summary>
        /// Executa um commit
        /// </summary>
        public void Commit()
        {
            try
            {
                if (Trans != null)
                {
                    Trans.Commit();
                }
                CloseConnection();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Executa um rollback
        /// </summary>
        public void Rollback()
        {

            try
            {
                if (Trans != null)
                {
                    Trans.Rollback();
                }
                CloseConnection();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Retorna um valor do banco de dados
        /// </summary>
        /// <param name="queryString">String com o comando select a ser executado</param>                
        /// <param name="parametros">Lista com os parâmetros da query</param> 
        /// <param name="fechaConexao">Indica se a conexão deve ser fechada após a execução do comando</param> 
        /// <returns></returns>
        // public object ExecuteScalar(string queryString, Param parametros, bool fechaConexao)
        public object ExecuteScalar(string queryString, bool fechaConexao)
        {
            object scalar = new object();
            try
            {
                MySqlConnection sqlConn = (MySqlConnection)OpenConnection();
                MySqlCommand MySqlCommand = new MySqlCommand(queryString, sqlConn);
                MySqlCommand.CommandTimeout = 600;
                if (Trans == null || (Trans != null && Trans.Connection == null))
                {
                    Trans = Conexao.BeginTransaction(IsolationLevel.ReadUncommitted);
                }
                MySqlCommand.Transaction = Trans;
                for (int i = 0; i < ListaParametros.Count; i++)
                {
                    MySqlCommand.Parameters.AddWithValue(ListaParametros[i].ParameterName, ListaParametros[i].Value);
                }
                scalar = MySqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fechaConexao)
                {
                    Commit();
                    CloseConnection();
                }
            }
            return scalar;
        }

        /// <summary>
        /// Executa um comando SQL
        /// </summary>
        /// <param name="queryString">String com o comando select a ser executado</param>                
        /// <param name="parametros">Lista com os parâmetros da query</param> 
        /// <param name="fechaConexao">Indica se a conexão deve ser fechada após a execução do comando</param> 
        /// <returns></returns>
        // public int ExecuteNonQuery(string queryString, Param parametros, bool fechaConexao)
        public int ExecuteNonQuery(string queryString, bool fechaConexao, bool utilizarTransaction, bool commitar)
        {
            int rows;
            try
            {
                MySqlConnection sqlConn = (MySqlConnection)OpenConnection();
                MySqlCommand MySqlCommand = new MySqlCommand(queryString, sqlConn);
                MySqlCommand.CommandTimeout = 600;
                if (utilizarTransaction)
                {
                    if (Trans == null || (Trans != null && Trans.Connection == null))
                    {
                        Trans = Conexao.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    MySqlCommand.Transaction = Trans;
                }
                for (int i = 0; i < ListaParametros.Count; i++)
                {
                    MySqlCommand.Parameters.AddWithValue(ListaParametros[i].ParameterName, ListaParametros[i].Value);
                }
                rows = MySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(commitar)
                    Commit();

                if (fechaConexao)
                    CloseConnection();
            }
            return rows;
        }

        public int ExecuteNonQuery(string queryString, bool fechaConexao, bool commitar)
        {
            return ExecuteNonQuery(queryString, fechaConexao, true, commitar);
        }

        public int ExecuteNonQuery(string queryString, bool fechaConexao)
        {
            return ExecuteNonQuery(queryString, fechaConexao, true, true);
        }

        /// <summary>
        /// Seleciona dados do banco de dados
        /// </summary>
        /// <param name="queryString">String com o comando select a ser executado</param>
        /// <param name="parametros">Lista com os parâmetros da query</param>
        /// <returns>DataTable com as informações</returns>
        public DataTable Select(string queryString, bool fechaConexao)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                MySqlConnection sqlConn = (MySqlConnection)OpenConnection();
                da.SelectCommand = new MySqlCommand(queryString, sqlConn);
                da.SelectCommand.CommandTimeout = 600;
                if (Trans == null || (Trans != null && Trans.Connection == null))
                {
                    Trans = Conexao.BeginTransaction(IsolationLevel.ReadUncommitted);
                }
                da.SelectCommand.Transaction = Trans;
                for (int i = 0; i < ListaParametros.Count; i++)
                {
                    da.SelectCommand.Parameters.AddWithValue(ListaParametros[i].ParameterName, ListaParametros[i].Value);
                }
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fechaConexao)
                {
                    CloseConnection();
                }
            }
            return dt;
        }

        public int Update(string query)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// Carrega as configurações do arquivo app.config para pegar a conexão com o banco
        ///// </summary>
        //public XmlDocument CarregarConfiguracaoBancoAppConfig()
        //{
        //    string loc = Assembly.GetAssembly(this.GetType()).Location;
        //    string path = System.IO.Path.GetDirectoryName(loc);
        //    string arquivo = path + "\\UVERP.exe.config";
        //    XmlDocument config = new XmlDocument();
        //    config.Load(arquivo);

        //    return config;
        //}
    }
}
