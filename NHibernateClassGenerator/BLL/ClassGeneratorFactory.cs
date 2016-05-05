using NHibernateClassGenerator.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.BLL
{
    public class ClassGeneratorFactory
    {
        public static ClassGenerator CreateClassGenerator()
        {
            ClassGenerator classGenerator = null;

            ConfigHelper confHelper = new ConfigHelper();
            confHelper.Load();

            switch (confHelper.Config.TipoDoServidor)
	        {
                    //Sql Server
                case 1: classGenerator = new ClassGeneratorSQLServer();
                    break;
                    //Oracle
                case 2: classGenerator = new ClassGeneratorOracle();
                    break;
                    //Mysql
                case 3: classGenerator = new ClassGeneratorMySql();
                    break;
                    //Postgres
                case 4: classGenerator = new ClassGeneratorPostgres();
                    break;
                    //Firebird
                case 5: classGenerator = null;
                    break;
                    //Null caso não definido
                default: classGenerator = null;
                    break;
	        } 

            return classGenerator;
        }
    }
}
