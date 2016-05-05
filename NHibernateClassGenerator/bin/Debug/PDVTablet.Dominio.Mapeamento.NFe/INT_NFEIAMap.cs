using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDVTablet.Dominio.Entidades.NFe;

namespace PDVTablet.Dominio.Mapeamento.NFe
{
    public class INT_NFEIAMap : ClassMap<INT_NFEIA>
    {
        public INT_NFEIAMap()
        {
            Table("INT_NFEIA");
            Map(x => x.EMPRESA, "EMPRESA");
            Map(x => x.FILIAL, "FILIAL");
            Map(x => x.INFNFE_ID, "INFNFE_ID").Length();
            Map(x => x.SEQ_NF, "SEQ_NF");
            Map(x => x.DET_NITEM, "DET_NITEM");
            Map(x => x.TPO_TEXTO, "TPO_TEXTO").Length();
            Map(x => x.OPERADOR, "OPERADOR").Length();
            Map(x => x.DATA_ALTER, "DATA_ALTER");
            Map(x => x.HORA_ALTER, "HORA_ALTER");
            Map(x => x.TIME_STAMP, "TIME_STAMP");
            Map(x => x.SYNCHCODE, "SYNCHCODE");
            Map(x => x.OBSERVACAO, "OBSERVACAO").Length();
        }
    }
}
