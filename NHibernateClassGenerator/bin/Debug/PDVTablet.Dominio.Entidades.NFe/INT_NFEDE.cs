using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDVTablet.Dominio.Entidades.NFe
{
    public class INT_NFEDE : IEntidade
    {
        public virtual int ICMSST_VBCSTRET { get; set; }

        public virtual int ICMSST_VICMSSTRET { get; set; }

        public virtual int ICMSST_VBCDEST { get; set; }

        public virtual int ICMSST_VICMSSTDEST { get; set; }

        public virtual int ICMSSN_ORIG { get; set; }

        public virtual int ICMSSN_CSOSN { get; set; }

        public virtual int ICMSSN_PCREDSN { get; set; }

        public virtual int ICMSSN_VCREDICMSSN { get; set; }

        public virtual int ICMSSN_MODBCST { get; set; }

        public virtual int ICMSSN_PMVAST { get; set; }

        public virtual int ICMSSN_PREDBCST { get; set; }

        public virtual int ICMSSN_VBCST { get; set; }

        public virtual int ICMSSN_PICMSST { get; set; }

        public virtual int ICMSSN_VICMSST { get; set; }

        public virtual int ICMSSN_VBCSTRET { get; set; }

        public virtual int ICMSSN_VICMSSTRET { get; set; }

        public virtual int ICMSSN_MODBC { get; set; }

        public virtual int ICMSSN_VBC { get; set; }

        public virtual int ICMSSN_PREDBC { get; set; }

        public virtual int ICMSSN_PICMS { get; set; }

        public virtual int ICMSSN_VICMS { get; set; }

        public virtual string ISSQN_CSITTRIB { get; set; }

        public virtual string PROD_XPED { get; set; }

        public virtual int PROD_NITEMPED { get; set; }

        public virtual int DESTINACAO { get; set; }

        public virtual int IMPOSTO_VTOTTRIB { get; set; }

        public virtual int ICMS_VICMSDIF { get; set; }

        public virtual int ICMS_PDIF { get; set; }

        public virtual int ICMS_VICMSOP { get; set; }

        public virtual string VEICPROD_CCOR { get; set; }

        public virtual string VEICPROD_XCOR { get; set; }

        public virtual string VEICPROD_POT { get; set; }

        public virtual string VEICPROD_CM3 { get; set; }

        public virtual string VEICPROD_PESOL { get; set; }

        public virtual string VEICPROD_PESOB { get; set; }

        public virtual string VEICPROD_NSERIE { get; set; }

        public virtual string VEICPROD_TPCOMB { get; set; }

        public virtual string VEICPROD_NMOTOR { get; set; }

        public virtual string VEICPROD_CMKG { get; set; }

        public virtual string VEICPROD_DIST { get; set; }

        public virtual string VEICPROD_RENAVAM { get; set; }

        public virtual string VEICPROD_ANOMOD { get; set; }

        public virtual string VEICPROD_ANOFAB { get; set; }

        public virtual string VEICPROD_TPPINT { get; set; }

        public virtual int VEICPROD_TPVEIC { get; set; }

        public virtual int VEICPROD_ESPVEIC { get; set; }

        public virtual string VEICPROD_VIN { get; set; }

        public virtual int VEICPROD_CONDVEIC { get; set; }

        public virtual int VEICPROD_CMOD { get; set; }

        public virtual int COMB_CPRODANP { get; set; }

        public virtual string COMB_CODIF { get; set; }

        public virtual int COMB_QTEMP { get; set; }

        public virtual int CIDE_QBCPROD { get; set; }

        public virtual int CIDE_VALIQPROD { get; set; }

        public virtual int CIDE_VCIDE { get; set; }

        public virtual int CICMS_VBCICMS { get; set; }

        public virtual int CICMS_VICMS { get; set; }

        public virtual int CICMS_VBCICMSST { get; set; }

        public virtual int CICMS_VICMSST { get; set; }

        public virtual int CICMSINTER_VBCICMS { get; set; }

        public virtual int CICMSINTER_VICMSST { get; set; }

        public virtual int CICMSCONS_VBCICMSS { get; set; }

        public virtual int CICMSCONS_VICMSSTC { get; set; }

        public virtual string CICMSCONS_UFCONS { get; set; }

        public virtual int ICMS_ORIG { get; set; }

        public virtual int ICMS_CST { get; set; }

        public virtual int ICMS_MODBC { get; set; }

        public virtual int ICMS_PREDBC { get; set; }

        public virtual int ICMS_VBC { get; set; }

        public virtual int ICMS_PICMS { get; set; }

        public virtual int ICMS_VICMS { get; set; }

        public virtual int ICMS_MODBCST { get; set; }

        public virtual int ICMS_PMVAST { get; set; }

        public virtual int ICMS_PREDBCST { get; set; }

        public virtual int ICMS_VBCST { get; set; }

        public virtual int ICMS_PICMSST { get; set; }

        public virtual int ICMS_VICMSST { get; set; }

        public virtual string IPI_CLENQ { get; set; }

        public virtual int IPI_CNPJPROD { get; set; }

        public virtual string IPI_CSELO { get; set; }

        public virtual int IPI_QSELO { get; set; }

        public virtual string IPI_CENQ { get; set; }

        public virtual int IPITRIB_CST { get; set; }

        public virtual int IPITRIB_VBC { get; set; }

        public virtual int IPITRIB_QUNID { get; set; }

        public virtual int IPITRIB_VUNID { get; set; }

        public virtual int IPITRIB_PIPI { get; set; }

        public virtual int IPITRIB_VIPI { get; set; }

        public virtual int II_VBC { get; set; }

        public virtual int II_VDESPADU { get; set; }

        public virtual int II_VII { get; set; }

        public virtual int II_VIOF { get; set; }

        public virtual int PISALIQ_CST { get; set; }

        public virtual int PISALIQ_VBC { get; set; }

        public virtual int PISALIQ_PPIS { get; set; }

        public virtual int PISALIQ_VPIS { get; set; }

        public virtual int PISALIQ_QBCPROD { get; set; }

        public virtual int PISALIQ_VALIQPROD { get; set; }

        public virtual int PISST_VBC { get; set; }

        public virtual int PISST_PPIS { get; set; }

        public virtual int PISST_QBCPROD { get; set; }

        public virtual int PISST_VALIQPROD { get; set; }

        public virtual int PISST_VPIS { get; set; }

        public virtual int COFINSALIQ_CST { get; set; }

        public virtual int COFINSALIQ_VBC { get; set; }

        public virtual int COFINSALIQ_PCOFINS { get; set; }

        public virtual int COFINSALIQ_VCOFINS { get; set; }

        public virtual int COFINSALIQ_QBCPROD { get; set; }

        public virtual int COFINSALIQ_VALIQPR { get; set; }

        public virtual int COFINSST_VBC { get; set; }

        public virtual int COFINSST_PCOFINS { get; set; }

        public virtual int COFINSST_QBCPROD { get; set; }

        public virtual int COFINSST_VALIQPROD { get; set; }

        public virtual int COFINSST_VCOFINS { get; set; }

        public virtual int ISSQN_VBC { get; set; }

        public virtual int ISSQN_VALIQ { get; set; }

        public virtual int ISSQN_VISSQN { get; set; }

        public virtual int ISSQN_CMUNFG { get; set; }

        public virtual int ISSQN_CLISTSERV { get; set; }

        public virtual string OPERADOR { get; set; }

        public virtual DateTime DATA_ALTER { get; set; }

        public virtual int HORA_ALTER { get; set; }

        public virtual int TIME_STAMP { get; set; }

        public virtual int SYNCHCODE { get; set; }

        public virtual int PROD_VOUTRO { get; set; }

        public virtual int PROD_INDTOT { get; set; }

        public virtual int VEICPROD_CCORDENAT { get; set; }

        public virtual int VEICPROD_LOTA { get; set; }

        public virtual int VEICPROD_TPREST { get; set; }

        public virtual int COMB_UFCONS { get; set; }

        public virtual int ICMS_MOTDESICMS { get; set; }

        public virtual int ICMS_VBCSTRET { get; set; }

        public virtual int ICMS_VICMSSTRET { get; set; }

        public virtual int ICMSPART_MODBC { get; set; }

        public virtual int ICMSPART_VBC { get; set; }

        public virtual int ICMSPART_PREDBC { get; set; }

        public virtual int ICMSPART_PICMS { get; set; }

        public virtual int ICMSPART_VICMS { get; set; }

        public virtual int ICMSPART_MODBCST { get; set; }

        public virtual int ICMSPART_PMVAST { get; set; }

        public virtual int ICMSPART_PREDBCST { get; set; }

        public virtual int ICMSPART_VBCST { get; set; }

        public virtual int ICMSPART_PICMSST { get; set; }

        public virtual int ICMSPART_VICMSST { get; set; }

        public virtual int ICMSPART_PBCOP { get; set; }

        public virtual string ICMSPART_UFST { get; set; }

        public virtual int EMPRESA { get; set; }

        public virtual int FILIAL { get; set; }

        public virtual char INFNFE_ID { get; set; }

        public virtual int SEQ_NF { get; set; }

        public virtual int DET_NITEM { get; set; }

        public virtual string PROD_CPROD { get; set; }

        public virtual string PROD_CEAN { get; set; }

        public virtual string PROD_XPROD { get; set; }

        public virtual string PROD_NCM { get; set; }

        public virtual string PROD_EXTIPI { get; set; }

        public virtual int PROD_GENERO { get; set; }

        public virtual int PROD_CFOP { get; set; }

        public virtual string PROD_UCOM { get; set; }

        public virtual int PROD_QCOM { get; set; }

        public virtual int PROD_VUNCOM { get; set; }

        public virtual int PROD_VPROD { get; set; }

        public virtual string PROD_CEANTRIB { get; set; }

        public virtual string PROD_UTRIB { get; set; }

        public virtual int PROD_QTRIB { get; set; }

        public virtual int PROD_VUNTRIB { get; set; }

        public virtual int PROD_VFRETE { get; set; }

        public virtual int PROD_VSEG { get; set; }

        public virtual int PROD_VDESC { get; set; }

        public virtual int VEICPROD_TPOP { get; set; }

        public virtual string VEICPROD_CHASSI { get; set; }

    }
}
