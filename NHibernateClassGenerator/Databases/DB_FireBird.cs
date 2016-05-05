using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;
using NHibernateClassGenerator.Helpers;
using System.IO;
using NHibernateClassGenerator.Config;


namespace NHibernateClassGenerator.Databases
{
    public class DB_FireBird : IDatabase
    {
        public DB_FireBird()
        {
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            path = Path.GetDirectoryName(path);

            ConfigHelper configHelper = new ConfigHelper(path);
            configHelper.Load();

            StringConexao = String.Format("Data Source={0};Database={1};User={2};Password={3}",
                configHelper.Config.IP_Imp,
                configHelper.Config.Banco_Imp,
                configHelper.Config.Usuario_Imp,
                configHelper.Config.Senha_Imp);

            ListaParametros = new List<FbParameter>();
            BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        public DB_FireBird(string ipServidor, string nomeDatabase, string usuarioBancoDados, string senhaBancoDados, int portaBancoDados)
        {
            StringConexao = String.Format("DataSource={0};Database={1};User={2};Password={3}",
                ipServidor,
                nomeDatabase,
                usuarioBancoDados,
                senhaBancoDados);

            StringConexao = StringConexao +
                //";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=false;Packet Size=8192;ServerType=0;";
                ";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";

            ListaParametros = new List<FbParameter>();
            BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        private FbConnection Conexao { get; set; }
        public string StringConexao { get; set; }
        private FbTransaction Trans { get; set; }
        private List<FbParameter> ListaParametros { get; set; }

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
        /// <returns>Objeto FbConnection</returns>
        public DbConnection OpenConnection()
        {
            if (Conexao == null)
            {
                Conexao = new FbConnection();
            }
            try
            {
                if (Conexao.State != ConnectionState.Open)
                {
                    Conexao.ConnectionString = StringConexao;
                    Conexao.Open();
                }
            }
            catch (Exception exp)
            {
                LogHelper.GravarLog(exp, "Erro ao abrir a conexão com o Firebird");
                throw exp;
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
            FbParameter param = new FbParameter(nomeParametro, tipoParametro);
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
            catch (Exception exp)
            {
                LogHelper.GravarLog(exp, "Erro ao comitar os dados com o Firebird");
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
            catch (Exception exp)
            {
                LogHelper.GravarLog(exp, "Erro ao dar Rollback nos dados com o Firebird");
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
                FbConnection sqlConn = (FbConnection)OpenConnection();
                FbCommand sqlCommand = new FbCommand(queryString, sqlConn);
                sqlCommand.CommandTimeout = 600;
                if (Trans == null || (Trans != null && Trans.Connection == null))
                {
                    Trans = Conexao.BeginTransaction(IsolationLevel.ReadUncommitted);
                }
                sqlCommand.Transaction = Trans;
                for (int i = 0; i < ListaParametros.Count; i++)
                {
                    sqlCommand.Parameters.AddWithValue(ListaParametros[i].ParameterName, ListaParametros[i].Value);
                }
                scalar = sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                LogHelper.GravarLog(e, "Erro ao executa o comando ExecuteScalar com o Firebird");
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
        public int ExecuteNonQuery(string queryString, bool fechaConexao, bool utilizarTransaction)
        {
            int rows;
            try
            {
                FbConnection sqlConn = (FbConnection)OpenConnection();
                FbCommand sqlCommand = new FbCommand(queryString, sqlConn);
                sqlCommand.CommandTimeout = 600;
                if (utilizarTransaction)
                {
                    if (Trans == null || (Trans != null && Trans.Connection == null))
                    {
                        Trans = Conexao.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    sqlCommand.Transaction = Trans;
                }
                for (int i = 0; i < ListaParametros.Count; i++)
                {
                    sqlCommand.Parameters.AddWithValue(ListaParametros[i].ParameterName, ListaParametros[i].Value);
                }
                rows = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogHelper.GravarLog(ex, "Erro ao executa o comando ExecuteNonQuery com o Firebird");
                throw ex;
            }
            finally
            {
                if (fechaConexao)
                {
                    Commit();
                    CloseConnection();
                }
            }
            return rows;
        }

        public int ExecuteNonQuery(string queryString, bool fechaConexao)
        {
            return ExecuteNonQuery(queryString, fechaConexao, true);
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
            FbDataAdapter da = new FbDataAdapter();
            try
            {
                FbConnection sqlConn = (FbConnection)OpenConnection();
                da.SelectCommand = new FbCommand(queryString, sqlConn);
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
                LogHelper.GravarLog(e, "Erro ao executa o comando Select com o Firebird");
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
    }
}
