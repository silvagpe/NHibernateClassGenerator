using NHibernateClassGenerator.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.Databases
{
    public class DatabaseFacoty
    {

        public static IDatabase CreateDatabase()
        {
            ConfigHelper configHelper = new ConfigHelper();
            configHelper.Load();
            if (configHelper.ConfigEmpty)
                throw new Exception("Configs is empty");



            /// <summary>
            /// 1 - Sql Server,
            /// 2 - Oracle,
            /// 3 - Mysql,
            /// 4 - Postgres,
            /// 5 - Firebird
            /// </summary>
            IDatabase db = null;

            ConfigXml config = configHelper.Config;

            int port = int.TryParse(config.Porta_Imp, out port)
                ? port
                : 0;

            switch (configHelper.Config.TipoDoServidor)
            {
                //SQL Server
                case 1: db = new DB_SQLServer(
                        config.IP_Imp,
                        config.Banco_Imp,
                        config.Usuario_Imp,
                        config.Senha_Imp,
                        port);
                    break;

                //Oracle
                case 2: db = new DB_Oracle(
                    config.IP_Imp,
                    config.Banco_Imp,
                    config.Usuario_Imp,
                    config.Senha_Imp, port);
                    break;
                
                //Mysql
                case 3: db = new DB_MySql(
                        config.IP_Imp,
                        config.Banco_Imp,
                        config.Usuario_Imp,
                        config.Senha_Imp,
                        port);
                    break;
                
                //Postgres
                case 4: db = new DB_Postgres(
                        config.IP_Imp,
                        config.Banco_Imp,
                        config.Usuario_Imp,
                        config.Senha_Imp,
                        port);
                    break;
                
                //FireBird
                case 5: db = new DB_FireBird(
                        config.IP_Imp,
                        config.Banco_Imp,
                        config.Usuario_Imp,
                        config.Senha_Imp,
                        port);
                    break;
                default:
                    break;
            }

            if (db == null)
                throw new Exception("Database don't implemented");

            db.OpenConnection();

            return db;
        }
    }
}
