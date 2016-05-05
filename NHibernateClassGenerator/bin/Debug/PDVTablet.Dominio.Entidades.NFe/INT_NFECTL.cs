using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDVTablet.Dominio.Entidades.NFe
{
    public class INT_NFECTL : IEntidade
    {
        public virtual string XMSG { get; set; }

        public virtual string STATUS_MSG { get; set; }

        public virtual int EMPRESA { get; set; }

        public virtual int FILIAL { get; set; }

        public virtual char INFNFE_ID { get; set; }

        public virtual int SEQ_NF { get; set; }

        public virtual int SITUACAO_NFE { get; set; }

        public virtual string NOME_SIT_NFE { get; set; }

        public virtual int COD_SERV_SOLIC { get; set; }

        public virtual string NOME_SERV_SOLIC { get; set; }

        public virtual DateTime DT_SOLIC_SERV { get; set; }

        public virtual string VERSAO_APLIC { get; set; }

        public virtual int STATUS_RESP { get; set; }

        public virtual string MOTIVO { get; set; }

        public virtual int UF { get; set; }

        public virtual string RECIBO { get; set; }

        public virtual DateTime DT_RECTO { get; set; }

        public virtual int HR_RECTO { get; set; }

        public virtual string PROTOCOLO { get; set; }

        public virtual int TEMPO_MED_RESP { get; set; }

        public virtual int ANO { get; set; }

        public virtual int NFE_INI_INUT { get; set; }

        public virtual int NFE_FIN_INUT { get; set; }

        public virtual string IBOLT_OPERATION { get; set; }

        public virtual DateTime IBOLT_OPER_DATE { get; set; }

        public virtual string IBOLT_OPER_TIME { get; set; }

        public virtual int IBOLT_RET_CODE { get; set; }

        public virtual int QT_IMP_DANFE { get; set; }

        public virtual int QT_ENV_EML_DANFE { get; set; }

        public virtual int QT_ENV_EML_XML { get; set; }

        public virtual string DANFE_PDF_PATH { get; set; }

        public virtual string STATUS_CARGA { get; set; }

        public virtual string MSG_ERRO_CARGA { get; set; }

        public virtual string JUSTIFICATIVA { get; set; }

        public virtual int CODE { get; set; }

        public virtual int IDE_TPAMB { get; set; }

        public virtual string IDE_VERPROC { get; set; }

        public virtual string OPERADOR { get; set; }

        public virtual DateTime DATA_ALTER { get; set; }

        public virtual int HORA_ALTER { get; set; }

        public virtual int TIME_STAMP { get; set; }

        public virtual int SYNCHCODE { get; set; }

        public virtual string ID_ASSINATURA { get; set; }

        public virtual string ID_AUXILIAR { get; set; }

        public virtual string WS_RECEP { get; set; }

        public virtual string WS_RET_RECEP { get; set; }

        public virtual string WS_CANCEL { get; set; }

        public virtual string WS_INUTIL { get; set; }

        public virtual string WS_STATUS { get; set; }

        public virtual string WS_CONSUL_NFE { get; set; }

        public virtual string WS_CONSUL_CAD { get; set; }

        public virtual int RESERVADO_06 { get; set; }

        public virtual string RESERVADO_11 { get; set; }

        public virtual string RESERVADO_12 { get; set; }

        public virtual string RESERVADO_09 { get; set; }

        public virtual string WS_RESERVADO_11 { get; set; }

        public virtual string WS_RESERVADO_22 { get; set; }

        public virtual string WS_RESERVADO_33 { get; set; }

        public virtual string WS_RESERVADO_44 { get; set; }

        public virtual string WS_RESERVADO_55 { get; set; }

        public virtual string WS_RESERVADO_66 { get; set; }

        public virtual string WS_RESERVADO_77 { get; set; }

        public virtual int RESERVADO_01 { get; set; }

        public virtual int RESERVADO_02 { get; set; }

        public virtual int RESERVADO_03 { get; set; }

        public virtual int RESERVADO_04 { get; set; }

        public virtual int RESERVADO_05 { get; set; }

        public virtual int RESERVADO_07 { get; set; }

        public virtual int RESERVADO_08 { get; set; }

        public virtual string RESERVADO_10 { get; set; }

        public virtual DateTime RESERVADO_13 { get; set; }

        public virtual DateTime RESERVADO_14 { get; set; }

        public virtual DateTime RESERVADO_15 { get; set; }

        public virtual DateTime RESERVADO_16 { get; set; }

        public virtual int RESERVADO_17 { get; set; }

        public virtual int RESERVADO_18 { get; set; }

        public virtual int RESERVADO_19 { get; set; }

        public virtual int RESERVADO_20 { get; set; }

        public virtual int RESERVADO_21 { get; set; }

        public virtual int RESERVADO_22 { get; set; }

        public virtual int RESERVADO_23 { get; set; }

        public virtual int RESERVADO_24 { get; set; }

        public virtual string RESERVADO_25 { get; set; }

        public virtual string RESERVADO_26 { get; set; }

        public virtual string RESERVADO_27 { get; set; }

        public virtual string RESERVADO_28 { get; set; }

        public virtual DateTime RESERVADO_29 { get; set; }

        public virtual DateTime RESERVADO_30 { get; set; }

        public virtual DateTime RESERVADO_31 { get; set; }

        public virtual DateTime RESERVADO_32 { get; set; }

        public virtual int CMSG { get; set; }

    }
}
