using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.BLL
{

    public class ColumnModel
    {
        public string ColumnName { get; set; }

        public string DataType { get; set; }

        public string Length { get; set; }

        public string Precison { get; set; }

        public string Scale { get; set; }

        public string IsNullable { get; set; }
    }
}
