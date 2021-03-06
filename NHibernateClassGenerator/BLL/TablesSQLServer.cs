﻿using NHibernateClassGenerator.Config;
using NHibernateClassGenerator.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.BLL
{
    public class TablesSQLServer : Tables
    {
        /// <summary>
        /// SELECT * FROM information_schema.tables 
        /// order by TABLE_NAME
        /// </summary>
        /// <returns></returns>
        public override DataTable LoadTables()
        {
            IDatabase db = DatabaseFacoty.CreateDatabase();


            string sql = "SELECT * FROM information_schema.tables order by TABLE_NAME";

            return db.Select(sql, true);
        }

        /// <summary>
        /// SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE,* 
        /// FROM INFORMATION_SCHEMA.COLUMNS
        /// WHERE TABLE_NAME = 'produto'
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public override DataTable LoadColumn(string tableName)
        {
            string sql = @"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE, IS_NULLABLE
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = '{0}'";

            sql = string.Format(sql, tableName);

            IDatabase db = DatabaseFacoty.CreateDatabase();
            return db.Select(sql, true);

        }

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
        public override bool IsIdenty(string tablename)
        {
            string sql = @"select count(*)
                            from INFORMATION_SCHEMA.COLUMNS
                            where TABLE_SCHEMA = 'dbo'
                            and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1
                            and TABLE_NAME = '{0}'";

            sql = string.Format(sql, tablename);

            IDatabase db = DatabaseFacoty.CreateDatabase();
            int count = Convert.ToInt32(db.ExecuteScalar(sql, true));

            return count > 0;
        }


        /// <summary>
        /// SELECT column_name
        /// FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
        /// WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1
        /// AND table_name = '{0}'
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public override DataTable LoadPrimaryKeys(string tablename)
        {
            string sql = @"SELECT column_name
                            FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                            WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1
                            AND table_name  = '{0}'";

            sql = string.Format(sql, tablename);

            IDatabase db = DatabaseFacoty.CreateDatabase();
            return db.Select(sql, true);
        }
    }
}
