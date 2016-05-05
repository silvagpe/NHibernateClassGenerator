using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFeMix.Entidades.NFSe;

namespace NFeMix.Mapeamento.NFSe
{
    public class GRS_NFSe_ItemMap : ClassMap<GRS_NFSe_Item>
    {
        public GRS_NFSe_ItemMap()
        {
            Table("GRS_NFSe_Item");
            Id(x => x.Id, "id").GeneratedBy.Increment();

            Map(x => x.Id_Grs_Nfse, "id_grs_nfse").Not.Nullable();
            Map(x => x.Cod_Municipal_Servico, "cod_municipal_servico").Length(10);
            Map(x => x.Cod_Servico_LC, "cod_servico_LC").Length(10);
            Map(x => x.Desc_Servico, "desc_servico").Length(256);
            Map(x => x.Cod_Ibge_Local_Tributacao, "cod_ibge_local_tributacao").Length(10);
            Map(x => x.Tipo_Local_Tributacao, "tipo_local_tributacao").Length(1);
            Map(x => x.Unidade_Trib, "unidade_trib").Length(2);
            Map(x => x.Qtd_Trib, "qtd_trib").Precision(13).Scale(2);
            Map(x => x.Valor_Uni, "valor_uni").Precision(13).Scale(4);
            Map(x => x.Valor_Servico, "valor_servico").Precision(13).Scale(2);
            Map(x => x.Valor_Desconto, "valor_desconto").Precision(13).Scale(2);
            Map(x => x.Valor_Bciss, "valor_bciss").Precision(13).Scale(2);
            Map(x => x.Perc_Iss, "perc_iss").Precision(10).Scale(2);
            Map(x => x.Valor_Iss, "valor_iss").Precision(13).Scale(2);
            Map(x => x.Valor_Bcinss, "valor_bcinss").Precision(13).Scale(2);
            Map(x => x.Perc_Ret_Inss, "perc_ret_inss").Precision(13).Scale(2);
            Map(x => x.Valor_Ret_Inss, "valor_ret_inss").Precision(13).Scale(2);
            Map(x => x.Valor_Reducao_Bc_Iss, "valor_reducao_bc_iss").Precision(13).Scale(2);
            Map(x => x.Valor_Bcretir, "valor_bcretir").Precision(13).Scale(2);
            Map(x => x.Perc_Retencao_Ir, "perc_retencao_ir").Precision(13).Scale(2);
            Map(x => x.Valor_Retencao_Ir, "valor_retencao_ir").Precision(13).Scale(2);
            Map(x => x.Valor_Bc_Cofins, "valor_bc_cofins").Precision(13).Scale(2);
            Map(x => x.Perc_Retencao_Cofins, "perc_retencao_cofins").Precision(13).Scale(2);
            Map(x => x.Valor_Retencao_Cofins, "valor_retencao_cofins").Precision(13).Scale(2);
            Map(x => x.Valor_Bc_Csll, "valor_bc_csll").Precision(13).Scale(2);
            Map(x => x.Perc_Retencao_Csll, "perc_retencao_csll").Precision(13).Scale(2);
            Map(x => x.Valor_Retencao_Csll, "valor_retencao_csll").Precision(13).Scale(2);
            Map(x => x.Valor_Bc_Pispasep, "valor_bc_pispasep").Precision(13).Scale(2);
            Map(x => x.Perc_Retencao_Pispasep, "perc_retencao_pispasep").Precision(13).Scale(2);
            Map(x => x.Valor_Retencao_Pispasep, "valor_retencao_pispasep").Precision(13).Scale(2);
            Map(x => x.Total_Aprox_Tributos, "total_aprox_tributos").Precision(13).Scale(2);
            Map(x => x.Valor_Retencao_Bc_Cst, "valor_retencao_bc_cst").Precision(13).Scale(2);
            Map(x => x.Valor_Bc_Cst, "valor_bc_cst").Precision(13).Scale(2);
            Map(x => x.Perc_ISSST, "perc_ISSST").Precision(13).Scale(2);
            Map(x => x.Valor_ISSST, "valor_ISSST").Precision(13).Scale(2);
        }
    }
}
