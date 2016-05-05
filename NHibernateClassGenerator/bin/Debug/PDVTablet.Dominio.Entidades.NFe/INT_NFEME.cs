using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDVTablet.Dominio.Entidades.NFe
{
    public class INT_NFEME : IEntidade
    {
        public virtual int ICMSTOT_VOUTRO { get; set; }

        public virtual int ICMSTOT_VNF { get; set; }

        public virtual int ISSQNTOT_VSERV { get; set; }

        public virtual int ISSQNTOT_VBC { get; set; }

        public virtual int ISSQNTOT_VISS { get; set; }

        public virtual int ISSQNTOT_VPIS { get; set; }

        public virtual int ISSQNTOT_VCOFINS { get; set; }

        public virtual int RETTRIB_VRETPIS { get; set; }

        public virtual int RETTRIB_VRETCOFINS { get; set; }

        public virtual int RETTRIB_VRETCSLL { get; set; }

        public virtual int RETTRIB_VBCIRRF { get; set; }

        public virtual int RETTRIB_VIRRF { get; set; }

        public virtual int RETTRIB_VBCRETPREV { get; set; }

        public virtual int RETTRIB_VRETPREV { get; set; }

        public virtual int TRANSP_MODFRETE { get; set; }

        public virtual int TRANSPORTA_CNPJ { get; set; }

        public virtual int TRANSPORTA_CPF { get; set; }

        public virtual string TRANSPORTA_XNOME { get; set; }

        public virtual string TRANSPORTA_IE { get; set; }

        public virtual string TRANSPORTA_XENDER { get; set; }

        public virtual string TRANSPORTA_XMUN { get; set; }

        public virtual char TRANSPORTA_UF { get; set; }

        public virtual int RETTRANSP_VSERV { get; set; }

        public virtual int RETTRANSP_VBCRET { get; set; }

        public virtual int RETTRANSP_PICMSRET { get; set; }

        public virtual int RETTRANSP_VICMSRET { get; set; }

        public virtual int RETTRANSP_CFOP { get; set; }

        public virtual int RETTRANSP_CMUNFG { get; set; }

        public virtual string VEICTRANSP_PLACA { get; set; }

        public virtual string VEICTRANSP_UF { get; set; }

        public virtual string VEICTRANSP_RNTC { get; set; }

        public virtual string REBOQUE_PLACA1 { get; set; }

        public virtual string REBOQUE_UF1 { get; set; }

        public virtual string REBOQUE_RNTC1 { get; set; }

        public virtual string REBOQUE_PLACA2 { get; set; }

        public virtual string REBOQUE_UF2 { get; set; }

        public virtual string REBOQUE_RNTC2 { get; set; }

        public virtual string FAT_NFAT { get; set; }

        public virtual int FAT_VORIG { get; set; }

        public virtual int FAT_VDESC { get; set; }

        public virtual int FAT_VLIQ { get; set; }

        public virtual string EXPORTA_UFEMBARQ { get; set; }

        public virtual string EXPORTA_XLOCEMBARQ { get; set; }

        public virtual string COMPRA_XNEMP { get; set; }

        public virtual string COMPRA_XPED { get; set; }

        public virtual string COMPRA_XCONT { get; set; }

        public virtual string OPERADOR { get; set; }

        public virtual DateTime DATA_ALTER { get; set; }

        public virtual int HORA_ALTER { get; set; }

        public virtual int TIME_STAMP { get; set; }

        public virtual int SYNCHCODE { get; set; }

        public virtual string IDE_HSAIENT { get; set; }

        public virtual string IDE_DHCONT { get; set; }

        public virtual string IDE_XJUST { get; set; }

        public virtual int ENDEREMIT_CTELPAIS { get; set; }

        public virtual int EMIT_CRT { get; set; }

        public virtual int AVULSA_CNPJ { get; set; }

        public virtual string AVULSA_XORGAO { get; set; }

        public virtual string AVULSA_MATR { get; set; }

        public virtual string AVULSA_XAGENTE { get; set; }

        public virtual int AVULSA_FONE { get; set; }

        public virtual string AVULSA_UF { get; set; }

        public virtual string AVULSA_NDAR { get; set; }

        public virtual DateTime AVULSA_DEMI { get; set; }

        public virtual int AVULSA_VDAR { get; set; }

        public virtual string AVULSA_REPEMI { get; set; }

        public virtual DateTime AVULSA_DPAG { get; set; }

        public virtual int ENDERDEST_CTELPAIS { get; set; }

        public virtual int RETIRADA_CPF { get; set; }

        public virtual int ENTREGA_CPF { get; set; }

        public virtual string CANA_SAFRA { get; set; }

        public virtual string CANA_REF { get; set; }

        public virtual int DESTINACAO { get; set; }

        public virtual int COND_ESPECIAL { get; set; }

        public virtual int ICMSTOT_VTOTTRIB { get; set; }

        public virtual int ICMSTOT_DESON { get; set; }

        public virtual int FINNFE { get; set; }

        public virtual int INDFINAL { get; set; }

        public virtual int INDPRES { get; set; }

        public virtual string IDESTRANGEIRO { get; set; }

        public virtual int INDIEDEST { get; set; }

        public virtual int AUT_CNPJ { get; set; }

        public virtual int AUT_CPF { get; set; }

        public virtual string HRCRIACAO { get; set; }

        public virtual string CD_CAIXA { get; set; }

        public virtual int EMPRESA { get; set; }

        public virtual int FILIAL { get; set; }

        public virtual char INFNFE_ID { get; set; }

        public virtual int SEQ_NF { get; set; }

        public virtual int IDE_CUF { get; set; }

        public virtual int IDE_CNF { get; set; }

        public virtual string IDE_NATOP { get; set; }

        public virtual int IDE_INDPA { get; set; }

        public virtual string IDE_MOD { get; set; }

        public virtual int IDE_SERIE { get; set; }

        public virtual int IDE_NNF { get; set; }

        public virtual DateTime IDE_DEMI { get; set; }

        public virtual DateTime IDE_DSAIENT { get; set; }

        public virtual int IDE_TPNF { get; set; }

        public virtual int IDE_CMUNFG { get; set; }

        public virtual int IDE_TPIMP { get; set; }

        public virtual int IDE_TPEMIS { get; set; }

        public virtual int IDE_CDV { get; set; }

        public virtual int IDE_TPAMB { get; set; }

        public virtual int IDE_FINNFE { get; set; }

        public virtual int IDE_PROCEMI { get; set; }

        public virtual string IDE_VERPROC { get; set; }

        public virtual int EMIT_CNPJ { get; set; }

        public virtual int EMIT_CPF { get; set; }

        public virtual string EMIT_XNOME { get; set; }

        public virtual string EMIT_XFANT { get; set; }

        public virtual string ENDEREMIT_XLGR { get; set; }

        public virtual string ENDEREMIT_NRO { get; set; }

        public virtual string ENDEREMIT_XCPL { get; set; }

        public virtual string ENDEREMIT_XBAIRRO { get; set; }

        public virtual int ENDEREMIT_CMUN { get; set; }

        public virtual string ENDEREMIT_XMUN { get; set; }

        public virtual string ENDEREMIT_UF { get; set; }

        public virtual int ENDEREMIT_CEP { get; set; }

        public virtual int ENDEREMIT_CPAIS { get; set; }

        public virtual string ENDEREMIT_XPAIS { get; set; }

        public virtual int ENDEREMIT_DDD { get; set; }

        public virtual int ENDEREMIT_FONE { get; set; }

        public virtual string EMIT_IE { get; set; }

        public virtual string EMIT_IEST { get; set; }

        public virtual string EMIT_IM { get; set; }

        public virtual string EMIT_CNAE { get; set; }

        public virtual int DEST_CNPJ { get; set; }

        public virtual int DEST_CPF { get; set; }

        public virtual string DEST_XNOME { get; set; }

        public virtual string DEST_EMAIL { get; set; }

        public virtual string ENDERDEST_XLGR { get; set; }

        public virtual string ENDERDEST_NRO { get; set; }

        public virtual string ENDERDEST_XCPL { get; set; }

        public virtual string ENDERDEST_XBAIRRO { get; set; }

        public virtual int ENDERDEST_CMUN { get; set; }

        public virtual string ENDERDEST_XMUN { get; set; }

        public virtual string ENDERDEST_UF { get; set; }

        public virtual int ENDERDEST_CEP { get; set; }

        public virtual int ENDERDEST_CPAIS { get; set; }

        public virtual string ENDERDEST_XPAIS { get; set; }

        public virtual int ENDERDEST_DDD { get; set; }

        public virtual int ENDERDEST_FONE { get; set; }

        public virtual string DEST_IE { get; set; }

        public virtual string DEST_ISUF { get; set; }

        public virtual int RETIRADA_CNPJ { get; set; }

        public virtual string RETIRADA_XLGR { get; set; }

        public virtual string RETIRADA_NRO { get; set; }

        public virtual string RETIRADA_XCPL { get; set; }

        public virtual string RETIRADA_XBAIRRO { get; set; }

        public virtual int RETIRADA_CMUN { get; set; }

        public virtual string RETIRADA_XMUN { get; set; }

        public virtual string RETIRADA_UF { get; set; }

        public virtual int ENTREGA_CNPJ { get; set; }

        public virtual string ENTREGA_XLGR { get; set; }

        public virtual string ENTREGA_NRO { get; set; }

        public virtual string ENTREGA_XCPL { get; set; }

        public virtual string ENTREGA_XBAIRRO { get; set; }

        public virtual int ENTREGA_CMUM { get; set; }

        public virtual string ENTREGA_XMUN { get; set; }

        public virtual string ENTREGA_UF { get; set; }

        public virtual int ICMSTOT_VBC { get; set; }

        public virtual int ICMSTOT_VICMS { get; set; }

        public virtual int ICMSTOT_VBCST { get; set; }

        public virtual int ICMSTOT_VST { get; set; }

        public virtual int ICMSTOT_VPROD { get; set; }

        public virtual int ICMSTOT_VFRETE { get; set; }

        public virtual int ICMSTOT_VSEG { get; set; }

        public virtual int ICMSTOT_VDESC { get; set; }

        public virtual int ICMSTOT_VII { get; set; }

        public virtual int ICMSTOT_VIPI { get; set; }

        public virtual int ICMSTOT_VPIS { get; set; }

        public virtual int ICMSTOT_VCOFINS { get; set; }

    }
}
