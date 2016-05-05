using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NHibernateClassGenerator.Config
{
    [XmlRoot("Configs")]
    public class ConfigXml : ISerializavel
    {
        public ConfigXml()
        {
        }

        /// <summary>
        /// 1 - Sql Server,
        /// 2 - Oracle,
        /// 3 - Mysql,
        /// 4 - Postgres,
        /// 5 - Firebird
        /// </summary>
        [XmlElement]
        public int TipoDoServidor { get; set; }

        [XmlElement]
        public string IP_Imp { get; set; }

        [XmlElement]
        public string Banco_Imp { get; set; }

        [XmlElement]
        public string Usuario_Imp { get; set; }

        [XmlElement]
        public string Senha_Imp { get; set; }

        [XmlElement]
        public string Porta_Imp { get; set; }

        [XmlElement]
        public string PrefixClas { get; set; }

        [XmlElement]
        public string NS_Entity { get; set; }

        [XmlElement]
        public string NS_Map { get; set; }

        [XmlElement]
        public string StrInterface { get; set; }
    }
}
