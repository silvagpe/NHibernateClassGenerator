using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NHibernateClassGenerator.Helpers
{
    public class LogHelper
    {
        public static string ArquivoLog
        {
            get
            {
                string caminho = System.Reflection.Assembly.GetExecutingAssembly().Location;
                caminho = System.IO.Path.GetDirectoryName(caminho);

                string nome = caminho
                    + "\\"
                    + "log_"
                    + DateTime.Now.ToString("yyyyMMdd")
                    + ".txt";
                return nome;
            }
        }

        public static void GravarLog(Exception exp, string msg)
        {
            using (StreamWriter writer = new StreamWriter(ArquivoLog, true))
            {
                writer.WriteLine("-------------------------------Log------------------------------");
                writer.WriteLine(string.Format("Log: {0}", DateTime.Now.ToString()));
                writer.WriteLine("----------------------------------------------------------------");
                writer.WriteLine(msg);
                writer.WriteLine("----------------------------------------------------------------");

                if (exp != null)
                {
                    writer.WriteLine("==== Exception Mensagem ===");
                    writer.WriteLine("----------------------------");
                    writer.WriteLine(exp.Message);

                    if (exp.InnerException != null)
                    {
                        writer.WriteLine("===== Inner Exception ===");
                        writer.WriteLine("-------------------------------");

                        GravarInnerException(writer, exp.InnerException);
                    }

                    writer.WriteLine("==== StackTrace ===");
                    writer.WriteLine("-------------------");
                    writer.WriteLine(exp.StackTrace);
                }

                writer.WriteLine("-------------------------------Fim Log--------------------------");
                writer.WriteLine(string.Empty);
                writer.Flush();
                writer.Close();
            }
        }

        private static void GravarInnerException(StreamWriter writer, Exception exp)
        {
            writer.WriteLine(exp.InnerException.Message);
            if (exp.InnerException != null)
                GravarInnerException(writer, exp.InnerException);
        }

        public static void GravarLog(string msg)
        {
            GravarLog(null, msg);
        }
    }
}
