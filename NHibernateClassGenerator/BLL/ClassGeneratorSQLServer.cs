using NHibernateClassGenerator.Helpers;
using NHibernateClassGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.BLL
{
    public class ClassGeneratorSQLServer : ClassGenerator
    {
        private Tables _tables = null;

        public ClassGeneratorSQLServer()
        {
            _tables = new TablesSQLServer();
        }

        #region Entities

        public override void EntityClass(string tableName, IList<ColumnModel> columns, string classPrefix, string entityNamespace, string strInterface = "")
        {
            string entityDir = DirectoryBase + "\\" + entityNamespace;

            if (!Directory.Exists(entityDir))
                Directory.CreateDirectory(entityDir);

            string className = TextHelper.FirstLetterUp(tableName);
            if (!string.IsNullOrEmpty(classPrefix))
                className = classPrefix + "_" + className;

            string fileClass = className + ".cs";
            fileClass = entityDir + "\\" + fileClass;

            if (File.Exists(fileClass))
                File.Delete(fileClass);


            using (StreamWriter writer = new StreamWriter(fileClass, true))
            {
                writer.WriteLine(Resources.Enity_Using);
                writer.WriteLine(string.Empty);

                //Namespace
                writer.WriteLine(string.Format(Resources.Entity_Namespace, entityNamespace));
                writer.WriteLine("{");
                {
                    //Class
                    writer.WriteLine("    " + string.Format(Resources.Entity_Class, className, strInterface));
                    writer.WriteLine("    {");
                    {
                        GenereteProprerties(writer, columns);
                    }
                    writer.WriteLine("    }");
                }
                writer.WriteLine("}");

                writer.Flush();
                writer.Close();
            }
        }

        public override void GenereteProprerties(StreamWriter writer, IList<ColumnModel> columns)
        {
            foreach (ColumnModel column in columns)
            {
                string propName = TextHelper.FirstLetterUp(column.ColumnName);
                string strType = DataTypeToCSharpType(column.DataType);

                if (column.IsNullable == "YES" && !strType.Equals("string"))
                    strType = strType+"?";

                string propLine = string.Format(Resources.Entity_Propertie, strType, propName) + " { get; set; }";

                //Tab
                propLine = "        " + propLine;

                writer.WriteLine(propLine);
                writer.WriteLine(string.Empty);
            }
        }

        public override string DataTypeToCSharpType(string dataType)
        {
            switch (dataType)
            {
                case "bigint": return "long";
                case "int": return "int";
                case "smallint": return "short";
                case "tinyint": return "byte";
                case "bit": return "bool";
                case "decimal": return "decimal";
                case "numeric": return "decimal";
                case "money": return "decimal";
                case "smallmoney": return "decimal";
                case "float": return "decimal";
                case "real": return "decimal";
                case "datetime": return "DateTime";
                case "smalldatetime": return "DateTime";
                case "char": return "char";
                case "varchar": return "string";
                case "nvarchar": return "string";
                case "nchar": return "string";
                case "ntext": return "string";
                case "binary": return "string";
                case "image": return "byte[]";
                case "guid": return "Guid";
                case "text": return "string";
                case "time": return "TimeSpan";
                default: return string.Empty;
            }
        }

        #endregion

        #region Mappings

        public override void MapClass(string tableName, IList<ColumnModel> columns, string classPrefix, string mapNamespace, string entityNameSpace)
        {
            string entityDir = DirectoryBase + "\\" + mapNamespace;

            if (!Directory.Exists(entityDir))
                Directory.CreateDirectory(entityDir);

            string className = TextHelper.FirstLetterUp(tableName);
            if (!string.IsNullOrEmpty(classPrefix))
                className = classPrefix + "_" + className;

            string classMap = className + "Map";

            string fileClass = classMap + ".cs";
            fileClass = entityDir + "\\" + fileClass;

            if (File.Exists(fileClass))
                File.Delete(fileClass);


            using (StreamWriter writer = new StreamWriter(fileClass, true))
            {
                writer.WriteLine(Resources.Map_Using);
                writer.WriteLine(string.Format("using {0};", entityNameSpace));
                writer.WriteLine(string.Empty);

                //Namespace
                writer.WriteLine(string.Format(Resources.Map_Namespace, mapNamespace));
                writer.WriteLine("{");
                {
                    //Class
                    writer.WriteLine("    " + string.Format(Resources.Map_Class, classMap, className));
                    writer.WriteLine("    {");
                    {
                        writer.WriteLine("        " + string.Format(Resources.Map_Constructor, classMap));
                        //Constructor
                        writer.WriteLine("        {");
                        {
                            MapColumns(writer, columns, tableName);
                        }
                        writer.WriteLine("        }");
                    }
                    writer.WriteLine("    }");
                }
                writer.WriteLine("}");

                writer.Flush();
                writer.Close();
            }
        }

        public override void MapColumns(StreamWriter writer, IList<ColumnModel> columns, string tableName)
        {
            writer.WriteLine("            " + string.Format(Resources.Map_Table, tableName));

            DataTable dtPrimaryKeys = _tables.LoadPrimaryKeys(tableName);
            if (dtPrimaryKeys.Rows.Count > 1)
                IdComposite(writer, dtPrimaryKeys);
            else
                IdMap(writer, dtPrimaryKeys, tableName);

            //Remove primary key
            foreach (DataRow row in dtPrimaryKeys.Rows)
            {
                string column_name = row[Tables.COLUMN_NAME].ToString();

                ColumnModel columnModel = columns.Where(x => x.ColumnName.Equals(column_name)).FirstOrDefault();

                if (columnModel != null)
                    columns.Remove(columnModel);
            }

            //Maps columns without keys
            foreach (ColumnModel column in columns)
            {
                MapByDataType(writer, column);
            }

        }

        public override void IdMap(StreamWriter writer, DataTable dtPrimaryKeys, string tableName)
        {
            foreach (DataRow row in dtPrimaryKeys.Rows)
            {
                string column_name = row[Tables.COLUMN_NAME].ToString();
                string propName = TextHelper.FirstLetterUp(column_name);
                string propMap = "            " + string.Format(Resources.Map_Id, propName, column_name);

                if (_tables.IsIdenty(tableName))
                    propMap = propMap + ".GeneratedBy.Native();";
                else
                    propMap = propMap + ".GeneratedBy.Increment();";

                writer.WriteLine(propMap);
                writer.WriteLine(string.Empty);
            }

        }

        public override void IdComposite(StreamWriter writer, DataTable dtPrimaryKeys)
        {
            StringBuilder sbPropMap = new StringBuilder("            CompositeId()");

            foreach (DataRow row in dtPrimaryKeys.Rows)
            {
                string column_name = row[Tables.COLUMN_NAME].ToString();
                string propName = TextHelper.FirstLetterUp(column_name);

                sbPropMap.Append(string.Format(Resources.Map_KeyProperty, propName, column_name));
            }
            sbPropMap.Append(";");

            string propMap = sbPropMap.ToString();
            writer.WriteLine(propMap);
        }

        public override void MapByDataType(StreamWriter writer, ColumnModel columnModel)
        {
            switch (columnModel.DataType)
            {
                case "bigint": MapInteger(writer, columnModel); break;
                case "int": MapInteger(writer, columnModel); break;
                case "smallint": MapInteger(writer, columnModel); break;
                case "tinyint": MapInteger(writer, columnModel); break;
                case "bit": MapInteger(writer, columnModel); break;
                case "decimal": MapDecimal(writer, columnModel); break;
                case "numeric": MapDecimal(writer, columnModel); break;
                case "money": MapDecimal(writer, columnModel); break;
                case "smallmoney": MapDecimal(writer, columnModel); break;
                case "float": MapDecimal(writer, columnModel); break;
                case "real": MapDecimal(writer, columnModel); break;
                case "datetime": MapDatetime(writer, columnModel); break;
                case "smalldatetime": MapDatetime(writer, columnModel); break;
                case "char": MapString(writer, columnModel); break;
                case "varchar": MapString(writer, columnModel); break;
                case "nvarchar": MapString(writer, columnModel); break;
                case "nchar": MapString(writer, columnModel); break;
                case "ntext": MapString(writer, columnModel); break;
                case "binary": MapString(writer, columnModel); break;
                case "image": MapByteArray(writer, columnModel); break;
                case "guid": MapString(writer, columnModel); break;
                case "text": MapString(writer, columnModel); break;
            }


        }

        public override void MapByteArray(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            sb.Append(".Custom<NHibernate.Type.BinaryBlobType>()");

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapString(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            sb.Append(string.Format(".Length({0})", columnModel.Length));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapText(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            if (!string.IsNullOrEmpty(columnModel.Length))
                sb.Append(string.Format(".Length({0})", columnModel.Length));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapDouble(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            if (!string.IsNullOrEmpty(columnModel.Precison))
                sb.Append(string.Format(".Precision({0})", columnModel.Precison, columnModel.Scale));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapDecimal(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            sb.Append(string.Format(".Precision({0}).Scale({1})", columnModel.Precison, columnModel.Scale));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapInteger(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapDatetime(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapBoolean(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }

        public override void MapGuid(StreamWriter writer, ColumnModel columnModel)
        {
            StringBuilder sb = new StringBuilder("            ");
            string propName = TextHelper.FirstLetterUp(columnModel.ColumnName);
            sb.Append(string.Format(Resources.Map_Prop_Column, propName, columnModel.ColumnName));

            if (columnModel.IsNullable == "NO")
                sb.Append(".Not.Nullable()");

            sb.Append(";");

            writer.WriteLine(sb.ToString());
        }


        #endregion
    }
}
