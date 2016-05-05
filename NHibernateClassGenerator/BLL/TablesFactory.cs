using NHibernateClassGenerator.Config;
using NHibernateClassGenerator.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.BLL
{
    public class TablesFactory
    {
        public static Tables CreateTables()
        {
            Tables tables = null;

            ConfigHelper confHelper = new ConfigHelper();
            confHelper.Load();

            switch (confHelper.Config.TipoDoServidor)
            {
                //Sql Server
                case 1: tables = new TablesSQLServer();
                    break;
                //Oracle
                case 2: tables = new TablesOracle();
                    break;
                //Mysql
                case 3: tables = new TablesMySql();
                    break;
                //Postgres
                case 4: tables = new TablesPostgres();
                    break;
                //Firebird
                case 5: tables = null;
                    break;
                //Null caso não definido
                default: tables = null;
                    break;
            }

            return tables;
        }

    }
}
