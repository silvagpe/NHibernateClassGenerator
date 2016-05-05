using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NHibernateClassGenerator.Helpers
{
    public class ValidarCampo
    {
        public static string ValidarCampoDatetime(DataRow row, string campo, string format)
        {
            //Caso o campo seja nulo
            if (row.IsNull(campo))
                return "";

            //Caso o campo tenha espaços em brancos
            if (row[campo].ToString().Trim().Count() == 0)
                return null;

            //Caso não consiga converter para o formato de data
            DateTime data;
            if (DateTime.TryParse(row[campo].ToString(), out data))
            {
                return data.ToString(format);
            }

            return null;
        }

        public static string ValidarCampoString(DataRow row, string campo)
        {
            //Caso o campo seja nulo
            if (row.IsNull(campo))
                return "";

            //Caso o campo tenha espaços em brancos
            if (row[campo].ToString().Trim().Count() == 0)
                return "";

            return row[campo].ToString().Trim();
        }

        public static string ValidarCampoDecimal(DataRow row, string campo)
        {
            //Caso o campo seja nulo
            if (row.IsNull(campo))
                return "0";

            //Caso o campo tenha espaços em brancos
            if (row[campo].ToString().Trim().Count() == 0)
                return "0";

            string val = row[campo].ToString().Trim();

            if (val.Equals("0"))
                return "0";

            return row[campo].ToString().Trim();
        }

        public static string ValidarCampoDecimal(DataRow row, string campo, string format)
        {
            return ValidarCampoDecimal(row, campo, format, '.');
        }

        public static string ValidarCampoDecimal(DataRow row, string campo, string format, char separadorDecimal)
        {
            //Caso o campo seja nulo
            if (row.IsNull(campo))
                return null;

            //Caso o campo tenha espaços em brancos
            if (row[campo].ToString().Trim().Count() == 0)
                return null;

            decimal valor = 0;
            decimal.TryParse(row[campo].ToString(), out valor);

            string valFormat = valor.ToString(format);

            if (!separadorDecimal.Equals(','))
                valFormat = valFormat.Replace(',', separadorDecimal);

            return valFormat;
        }

        /// <summary>
        /// Retorna zero caso não passe em alguma das validações
        /// </summary>
        /// <param name="row"></param>
        /// <param name="campo"></param>
        /// <returns></returns>
        public static int ValidarCampoInteiro(DataRow row, string campo)
        {
            //Caso o campo seja nulo
            if (row.IsNull(campo))
                return 0;

            //Caso o campo tenha espaços em brancos
            if (row[campo].ToString().Trim().Count() == 0)
                return 0;

            //string val = row[campo].ToString().Trim();

            int val = 0;
            if (int.TryParse(row[campo].ToString(), out val))
                return val;

            return val;
        }

        public static string RemoverCaracteresNaoNumericos(string texto)
        {
            return texto.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace(">", "").Replace("<", "");
        }

    }
}
