using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDVTablet.Dominio.Entidades.NFe
{
    public class INT_NFEFORP : IEntidade
    {
        public virtual int EMPRESA { get; set; }

        public virtual int FILIAL { get; set; }

        public virtual char INFNFE_ID { get; set; }

        public virtual int SEQ_NF { get; set; }

        public virtual int SEQ_PAG { get; set; }

        public virtual string TPAG { get; set; }

        public virtual int VPAG { get; set; }

        public virtual string CNPJ { get; set; }

        public virtual string TBAND { get; set; }

        public virtual string CAUT { get; set; }

        public virtual char OPERADOR { get; set; }

        public virtual DateTime DATA_ALTER { get; set; }

        public virtual int HORA_ALTER { get; set; }

        public virtual int TIME_STAMP { get; set; }

        public virtual int SYNCHCODE { get; set; }

    }
}
