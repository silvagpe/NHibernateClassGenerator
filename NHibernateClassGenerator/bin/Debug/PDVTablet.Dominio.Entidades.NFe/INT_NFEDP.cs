using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDVTablet.Dominio.Entidades.NFe
{
    public class INT_NFEDP : IEntidade
    {
        public virtual int EMPRESA { get; set; }

        public virtual int FILIAL { get; set; }

        public virtual char INFNFE_ID { get; set; }

        public virtual int SEQ_NF { get; set; }

        public virtual int SEQ { get; set; }

        public virtual string DUP_DESDOB { get; set; }

        public virtual string DUP_NDUP { get; set; }

        public virtual DateTime DUP_DVENC { get; set; }

        public virtual int DUP_VDUP { get; set; }

        public virtual char OPERADOR { get; set; }

        public virtual DateTime DATA_ALTER { get; set; }

        public virtual int HORA_ALTER { get; set; }

        public virtual int TIME_STAMP { get; set; }

        public virtual int SYNCHCODE { get; set; }

    }
}
