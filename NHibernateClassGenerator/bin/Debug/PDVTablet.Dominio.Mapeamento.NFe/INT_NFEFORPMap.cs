using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDVTablet.Dominio.Entidades.NFe;

namespace PDVTablet.Dominio.Mapeamento.NFe
{
    public class INT_NFEFORPMap : ClassMap<INT_NFEFORP>
    {
        public INT_NFEFORPMap()
        {
            Table("INT_NFEFORP");
            Map(x => x.EMPRESA, "EMPRESA");
            Map(x => x.FILIAL, "FILIAL");
            Map(x => x.INFNFE_ID, "INFNFE_ID").Length();
            Map(x => x.SEQ_NF, "SEQ_NF");
            Map(x => x.SEQ_PAG, "SEQ_PAG");
            Map(x => x.TPAG, "TPAG").Length();
            Map(x => x.VPAG, "VPAG");
            Map(x => x.CNPJ, "CNPJ").Length();
            Map(x => x.TBAND, "TBAND").Length();
            Map(x => x.CAUT, "CAUT").Length();
            Map(x => x.OPERADOR, "OPERADOR").Length();
            Map(x => x.DATA_ALTER, "DATA_ALTER");
            Map(x => x.HORA_ALTER, "HORA_ALTER");
            Map(x => x.TIME_STAMP, "TIME_STAMP");
            Map(x => x.SYNCHCODE, "SYNCHCODE");
        }
    }
}
