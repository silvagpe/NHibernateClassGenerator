using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace NHibernateClassGenerator.BLL
{
    public abstract class ClassGenerator
    {
        public static string DirectoryBase
        {
            get
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                path = Path.GetDirectoryName(path);

                return path;
            }
        }


        #region Entities

        public abstract void EntityClass(string tableName, IList<ColumnModel> columns, string classPrefix, string entityNamespace, string strInterface = "");

        public abstract void GenereteProprerties(StreamWriter writer, IList<ColumnModel> columns);

        public abstract string DataTypeToCSharpType(string dataType);

        #endregion

        #region Mappings

        public abstract void MapClass(string tableName, IList<ColumnModel> columns, string classPrefix, string mapNamespace, string entityNameSpace);

        public abstract void MapColumns(StreamWriter writer, IList<ColumnModel> columns, string tableName);

        public abstract void IdMap(StreamWriter writer, DataTable dtPrimaryKeys, string tableName);

        public abstract void IdComposite(StreamWriter writer, DataTable dtPrimaryKeys);

        public abstract void MapByDataType(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapByteArray(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapString(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapText(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapDecimal(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapDouble(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapInteger(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapDatetime(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapBoolean(StreamWriter writer, ColumnModel columnModel);

        public abstract void MapGuid(StreamWriter writer, ColumnModel columnModel);


        #endregion
    }
}
