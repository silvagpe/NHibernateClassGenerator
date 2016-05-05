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
    /// <summary>
    /// Important!
    /// ====================================================
    /// Maintain the same column name in select statement
    /// </summary>
    public class TablesPostgres : Tables
    {
        /// <summary>
        /// SELECT * FROM pg_catalog.pg_tables
        /// order by tablename
        /// </summary>
        /// <returns></returns>
        public override DataTable LoadTables()
        {
            IDatabase db = DatabaseFacoty.CreateDatabase();


            string sql = @"SELECT 
	                        schemaname,
	                        tablename as TABLE_NAME,
	                        tableowner, 
	                        tablespace,
	                        hasindexes,
	                        hasrules,
	                        hastriggers 
                        FROM pg_catalog.pg_tables order by tablename";

            return db.Select(sql, true);
        }

        /// <summary>
        /// SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE, IS_NULLABLE
        /// FROM information_schema.columns
        /// WHERE table_name = 'fin_lancamento'
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public override DataTable LoadColumn(string tableName)
        {
            string sql = @"SELECT 
	                        COLUMN_NAME, 
	                        DATA_TYPE, 
	                        CHARACTER_MAXIMUM_LENGTH, 
	                        NUMERIC_PRECISION, 
	                        NUMERIC_SCALE, 
	                        IS_NULLABLE
                        FROM information_schema.columns
                        WHERE table_name   =  '{0}'";

            sql = string.Format(sql, tableName);

            IDatabase db = DatabaseFacoty.CreateDatabase();
            return db.Select(sql, true);

        }

        /// <summary>
        /// SELECT count(COLUMN_DEFAULT)
        /// FROM information_schema.columns
        /// WHERE table_name   =  'crm_acaonegocio'
        /// and column_default like ('nextval%')
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public override bool IsIdenty(string tablename)
        {
            string sql = @"SELECT 
	                        count(COLUMN_DEFAULT)
                        FROM information_schema.columns
                        WHERE table_name = '{0}'
                        and column_default like ('nextval%')";

            sql = string.Format(sql, tablename);

            IDatabase db = DatabaseFacoty.CreateDatabase();
            int count = Convert.ToInt32(db.ExecuteScalar(sql, true));

            return count > 0;
        }


        /// <summary>
        /// SELECT  pg_attribute.attname as column_name, format_type(pg_attribute.atttypid, pg_attribute.atttypmod) 
        /// FROM pg_index, pg_class, pg_attribute 
        /// WHERE 
        /// pg_class.oid = 'tscrm_moducont'::regclass AND
        /// indrelid = pg_class.oid AND
        /// pg_attribute.attrelid = pg_class.oid AND 
        /// pg_attribute.attnum = any(pg_index.indkey)
        /// AND indisprimary
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public override DataTable LoadPrimaryKeys(string tablename)
        {
            string sql = @"SELECT               
                          pg_attribute.attname as column_name,  
                          format_type(pg_attribute.atttypid, pg_attribute.atttypmod) 
                        FROM pg_index, pg_class, pg_attribute 
                        WHERE 
                          pg_class.oid = '{0}'::regclass AND
                          indrelid = pg_class.oid AND
                          pg_attribute.attrelid = pg_class.oid AND 
                          pg_attribute.attnum = any(pg_index.indkey)
                          AND indisprimary";

            sql = string.Format(sql, tablename);

            IDatabase db = DatabaseFacoty.CreateDatabase();
            return db.Select(sql, true);
        }
    }
}
