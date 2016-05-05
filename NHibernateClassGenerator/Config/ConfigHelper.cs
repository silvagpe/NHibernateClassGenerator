using NHibernateClassGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NHibernateClassGenerator.Config
{
    public class ConfigHelper
    {
        public ConfigHelper()
        {   
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            path = Path.GetDirectoryName(path);
            this._localConfig = path;
        }

        /// <summary>
        /// Contrutor
        /// </summary>
        /// <param name="localConfig">Caminho onde será salva as configurações. Exemplo: C:\Aplicativo\</param>
        public ConfigHelper(string localConfig)
        {
            this._localConfig = localConfig;
        }

        private string _localConfig = string.Empty;
        private string _nomeArquivo = "config.xml";
        private bool _configEmBranco = false;

        public bool ConfigEmpty
        {
            get { return _configEmBranco; }
        }

        public ConfigXml Config { get; set; }
        
        /// <summary>
        /// Nome e local do arquivo de configurações do sistema
        /// </summary>
        private string Arquivo 
        {
            get
            {
                int tam = this._localConfig.Length -1;
                if (this._localConfig[tam] != '\\')
                    this._localConfig = this._localConfig + "\\";

                return this._localConfig + _nomeArquivo;
            }
        }


        public void Load()
        {
            try
            {
                XmlParseHelper<ConfigXml> xmlParse = new XmlParseHelper<ConfigXml>();

                this.Config = xmlParse.LoadData(this.Arquivo);

                if (this.Config == null)
                {
                    this.Config = new ConfigXml();
                    _configEmBranco = true;
                }                
            }
            catch (XmlParseHelperException exp)
            {
                LogHelper.GravarLog(exp, "Erro no XmlParse ao carregar as configurações .");
                throw exp;
            }
            catch (Exception exp)
            {
                LogHelper.GravarLog(exp, "Erro ao carregar as configurações.");
                throw exp;
            }
            
        }

        public void Save()
        {
            try
            {
                if (this.Config == null)
                    this.Config = new ConfigXml();
                
                XmlParseHelper<ConfigXml> xmlParse = new XmlParseHelper<ConfigXml>();

                xmlParse.SaveData(this.Arquivo, this.Config);
            }
            catch (XmlParseHelperException exp)
            {
                LogHelper.GravarLog(exp, "Erro no XmlParse ao salvar as configurações .");
                throw exp;
            }
            catch (Exception exp)
            {
                LogHelper.GravarLog(exp, "Erro ao salvar as configurações.");
                throw exp;
            }
            

        }

    }
}
