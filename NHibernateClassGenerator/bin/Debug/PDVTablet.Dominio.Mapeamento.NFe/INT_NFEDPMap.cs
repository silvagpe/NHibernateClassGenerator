using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDVTablet.Dominio.Entidades.NFe;

namespace PDVTablet.Dominio.Mapeamento.NFe
{
    public class INT_NFEDPMap : ClassMap<INT_NFEDP>
    {
        public INT_NFEDPMap()
        {
            Table("INT_NFEDP");
            Map(x => x.EMPRESA, "EMPRESA");
            Map(x => x.FILIAL, "FILIAL");
            Map(x => x.INFNFE_ID, "INFNFE_ID").Length();
            Map(x => x.SEQ_NF, "SEQ_NF");
            Map(x => x.SEQ, "SEQ");
            Map(x => x.DUP_DESDOB, "DUP_DESDOB").Length();
            Map(x => x.DUP_NDUP, "DUP_NDUP").Length();
            Map(x => x.DUP_DVENC, "DUP_DVENC");
            Map(x => x.DUP_VDUP, "DUP_VDUP");
            Map(x => x.OPERADOR, "OPERADOR").Length();
            Map(x => x.DATA_ALTER, "DATA_ALTER");
            Map(x => x.HORA_ALTER, "HORA_ALTER");
            Map(x => x.TIME_STAMP, "TIME_STAMP");
            Map(x => x.SYNCHCODE, "SYNCHCODE");
        }
    }
}
