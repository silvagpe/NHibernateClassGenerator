using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NHibernateClassGenerator.Config
{
    public class XmlParseHelper<T> where T : ISerializavel
    {
        private string _dataToParse;
        private static XmlParseHelper<T> _instance;

        public static XmlParseHelper<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new XmlParseHelper<T>();
                }
                return _instance;
            }
        }

        public string DataToParse
        {
            get
            {
                return _dataToParse;
            }
            set
            {
                this._dataToParse = value;
            }
        }

        public T LoadData(string arquivo)
        {
            try
            {
                if (File.Exists(arquivo))
                {
                    FileStream stream = File.Open(arquivo, FileMode.Open);
                    XmlSerializer serlizer = new XmlSerializer(typeof(T));
                    
                    var resultado = (T)serlizer.Deserialize(stream);
                    stream.Close();
                    return resultado;
                }

                return default(T);
            }
            catch (Exception exp)
            {
                throw new XmlParseHelperException("Erro ao carregar os dados do XML", exp);
            }
        }

        public void SaveData(string arquivo, T dados)
        {
            try
            {
                if (File.Exists(arquivo))
                    File.Delete(arquivo);
                
                FileStream stream = File.Open(arquivo, FileMode.OpenOrCreate);

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
                {
                    serializer.Serialize(xmlWriter, dados);
                }
                
                stream.Close();
                
            }
            catch (Exception exp)
            {
                throw new XmlParseHelperException("Erro ao salvar os dados em XML", exp);
            }

        }

        public string ClasseParaXML(T dados)
        {
            try
            {
                if (dados == null)
                    throw new XmlParseHelperException("A classe para conversão em XML não pode ser nulo.");

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                StringWriter textWriter = new StringWriter();

                xmlSerializer.Serialize(textWriter, dados);

                string resultado = textWriter.ToString();

                textWriter.Close();
                return resultado;
            }
            catch (Exception exp)
            {
                throw new XmlParseHelperException("Erro ao converter de classe para XML", exp);
            }


        }

        public T XMLParaClasse(string xml)
        {
            try
            {
                if (string.IsNullOrEmpty(xml))
                    throw new XmlParseHelperException("XML não pode ser nulo ou vázio.");

                TextReader tReader = new StringReader(xml);
                XmlSerializer serlizer = new XmlSerializer(typeof(T));
                
                var resultado = (T)serlizer.Deserialize(tReader);

                tReader.Close();
                return resultado;
            }
            catch (Exception exp)
            {
                throw new XmlParseHelperException("Erro ao converter de XML para classe", exp);
            }
        }
    }


    public class XmlParseHelperException : System.Exception
    {
        public XmlParseHelperException() { }
        public XmlParseHelperException(string message) : base(message) { }
        public XmlParseHelperException(string message, System.Exception inner) : base(message, inner) { }

    }
}
