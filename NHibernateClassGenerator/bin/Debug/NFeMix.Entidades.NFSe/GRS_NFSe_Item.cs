using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFeMix.Entidades.NFSe
{
    public class GRS_NFSe_Item : IEntidade
    {
        public virtual int Id { get; set; }

        public virtual int Id_Grs_Nfse { get; set; }

        public virtual string Cod_Municipal_Servico { get; set; }

        public virtual string Cod_Servico_LC { get; set; }

        public virtual string Desc_Servico { get; set; }

        public virtual string Cod_Ibge_Local_Tributacao { get; set; }

        public virtual string Tipo_Local_Tributacao { get; set; }

        public virtual string Unidade_Trib { get; set; }

        public virtual decimal? Qtd_Trib { get; set; }

        public virtual decimal? Valor_Uni { get; set; }

        public virtual decimal? Valor_Servico { get; set; }

        public virtual decimal? Valor_Desconto { get; set; }

        public virtual decimal? Valor_Bciss { get; set; }

        public virtual decimal? Perc_Iss { get; set; }

        public virtual decimal? Valor_Iss { get; set; }

        public virtual decimal? Valor_Bcinss { get; set; }

        public virtual decimal? Perc_Ret_Inss { get; set; }

        public virtual decimal? Valor_Ret_Inss { get; set; }

        public virtual decimal? Valor_Reducao_Bc_Iss { get; set; }

        public virtual decimal? Valor_Bcretir { get; set; }

        public virtual decimal? Perc_Retencao_Ir { get; set; }

        public virtual decimal? Valor_Retencao_Ir { get; set; }

        public virtual decimal? Valor_Bc_Cofins { get; set; }

        public virtual decimal? Perc_Retencao_Cofins { get; set; }

        public virtual decimal? Valor_Retencao_Cofins { get; set; }

        public virtual decimal? Valor_Bc_Csll { get; set; }

        public virtual decimal? Perc_Retencao_Csll { get; set; }

        public virtual decimal? Valor_Retencao_Csll { get; set; }

        public virtual decimal? Valor_Bc_Pispasep { get; set; }

        public virtual decimal? Perc_Retencao_Pispasep { get; set; }

        public virtual decimal? Valor_Retencao_Pispasep { get; set; }

        public virtual decimal? Total_Aprox_Tributos { get; set; }

        public virtual decimal? Valor_Retencao_Bc_Cst { get; set; }

        public virtual decimal? Valor_Bc_Cst { get; set; }

        public virtual decimal? Perc_ISSST { get; set; }

        public virtual decimal? Valor_ISSST { get; set; }

    }
}
