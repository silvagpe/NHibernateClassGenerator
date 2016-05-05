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
    public abstract class Tables
    {
        public const string TABLE_NAME = "TABLE_NAME";
        public const string COLUMN_NAME = "COLUMN_NAME"; 
        public const string DATA_TYPE = "DATA_TYPE";
        public const string CHARACTER_MAXIMUM_LENGTH = "CHARACTER_MAXIMUM_LENGTH";
        public const string NUMERIC_PRECISION = "NUMERIC_PRECISION";
        public const string NUMERIC_SCALE = "NUMERIC_SCALE";
        public const string IS_NULLABLE = "IS_NULLABLE";


        /// <summary>
        /// SELECT * FROM information_schema.tables 
        /// order by TABLE_NAME
        /// </summary>
        /// <returns></returns>
        public abstract DataTable LoadTables();

        /// <summary>
        /// SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE,* 
        /// FROM INFORMATION_SCHEMA.COLUMNS
        /// WHERE TABLE_NAME = 'produto'
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public abstract DataTable LoadColumn(string tableName);

        /// <summary>
        /// select COLUMN_NAME, TABLE_NAME
        /// from INFORMATION_SCHEMA.COLUMNS
        /// where TABLE_SCHEMA = 'dbo'
        /// and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1
        /// and TABLE_NAME = '{0}'
        /// order by TABLE_NAME
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public abstract bool IsIdenty(string tablename);


        /// <summary>
        /// SELECT column_name
        /// FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
        /// WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1
        /// AND table_name = '{0}'
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public abstract DataTable LoadPrimaryKeys(string tablename);

    }
}
