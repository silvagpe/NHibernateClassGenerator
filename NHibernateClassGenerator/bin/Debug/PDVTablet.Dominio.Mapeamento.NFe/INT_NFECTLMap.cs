using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDVTablet.Dominio.Entidades.NFe;

namespace PDVTablet.Dominio.Mapeamento.NFe
{
    public class INT_NFECTLMap : ClassMap<INT_NFECTL>
    {
        public INT_NFECTLMap()
        {
            Table("INT_NFECTL");
            Map(x => x.XMSG, "XMSG").Length();
            Map(x => x.STATUS_MSG, "STATUS_MSG").Length();
            Map(x => x.EMPRESA, "EMPRESA");
            Map(x => x.FILIAL, "FILIAL");
            Map(x => x.INFNFE_ID, "INFNFE_ID").Length();
            Map(x => x.SEQ_NF, "SEQ_NF");
            Map(x => x.SITUACAO_NFE, "SITUACAO_NFE");
            Map(x => x.NOME_SIT_NFE, "NOME_SIT_NFE").Length();
            Map(x => x.COD_SERV_SOLIC, "COD_SERV_SOLIC");
            Map(x => x.NOME_SERV_SOLIC, "NOME_SERV_SOLIC").Length();
            Map(x => x.DT_SOLIC_SERV, "DT_SOLIC_SERV");
            Map(x => x.VERSAO_APLIC, "VERSAO_APLIC").Length();
            Map(x => x.STATUS_RESP, "STATUS_RESP");
            Map(x => x.MOTIVO, "MOTIVO").Length();
            Map(x => x.UF, "UF");
            Map(x => x.RECIBO, "RECIBO").Length();
            Map(x => x.DT_RECTO, "DT_RECTO");
            Map(x => x.HR_RECTO, "HR_RECTO");
            Map(x => x.PROTOCOLO, "PROTOCOLO").Length();
            Map(x => x.TEMPO_MED_RESP, "TEMPO_MED_RESP");
            Map(x => x.ANO, "ANO");
            Map(x => x.NFE_INI_INUT, "NFE_INI_INUT");
            Map(x => x.NFE_FIN_INUT, "NFE_FIN_INUT");
            Map(x => x.IBOLT_OPERATION, "IBOLT_OPERATION").Length();
            Map(x => x.IBOLT_OPER_DATE, "IBOLT_OPER_DATE");
            Map(x => x.IBOLT_OPER_TIME, "IBOLT_OPER_TIME").Length();
            Map(x => x.IBOLT_RET_CODE, "IBOLT_RET_CODE");
            Map(x => x.QT_IMP_DANFE, "QT_IMP_DANFE");
            Map(x => x.QT_ENV_EML_DANFE, "QT_ENV_EML_DANFE");
            Map(x => x.QT_ENV_EML_XML, "QT_ENV_EML_XML");
            Map(x => x.DANFE_PDF_PATH, "DANFE_PDF_PATH").Length();
            Map(x => x.STATUS_CARGA, "STATUS_CARGA").Length();
            Map(x => x.MSG_ERRO_CARGA, "MSG_ERRO_CARGA").Length();
            Map(x => x.JUSTIFICATIVA, "JUSTIFICATIVA").Length();
            Map(x => x.CODE, "CODE");
            Map(x => x.IDE_TPAMB, "IDE_TPAMB");
            Map(x => x.IDE_VERPROC, "IDE_VERPROC").Length();
            Map(x => x.OPERADOR, "OPERADOR").Length();
            Map(x => x.DATA_ALTER, "DATA_ALTER");
            Map(x => x.HORA_ALTER, "HORA_ALTER");
            Map(x => x.TIME_STAMP, "TIME_STAMP");
            Map(x => x.SYNCHCODE, "SYNCHCODE");
            Map(x => x.ID_ASSINATURA, "ID_ASSINATURA").Length();
            Map(x => x.ID_AUXILIAR, "ID_AUXILIAR").Length();
            Map(x => x.WS_RECEP, "WS_RECEP").Length();
            Map(x => x.WS_RET_RECEP, "WS_RET_RECEP").Length();
            Map(x => x.WS_CANCEL, "WS_CANCEL").Length();
            Map(x => x.WS_INUTIL, "WS_INUTIL").Length();
            Map(x => x.WS_STATUS, "WS_STATUS").Length();
            Map(x => x.WS_CONSUL_NFE, "WS_CONSUL_NFE").Length();
            Map(x => x.WS_CONSUL_CAD, "WS_CONSUL_CAD").Length();
            Map(x => x.RESERVADO_06, "RESERVADO_06");
            Map(x => x.RESERVADO_11, "RESERVADO_11").Length();
            Map(x => x.RESERVADO_12, "RESERVADO_12").Length();
            Map(x => x.RESERVADO_09, "RESERVADO_09").Length();
            Map(x => x.WS_RESERVADO_11, "WS_RESERVADO_1").Length();
            Map(x => x.WS_RESERVADO_22, "WS_RESERVADO_2").Length();
            Map(x => x.WS_RESERVADO_33, "WS_RESERVADO_3").Length();
            Map(x => x.WS_RESERVADO_44, "WS_RESERVADO_4").Length();
            Map(x => x.WS_RESERVADO_55, "WS_RESERVADO_5").Length();
            Map(x => x.WS_RESERVADO_66, "WS_RESERVADO_6").Length();
            Map(x => x.WS_RESERVADO_77, "WS_RESERVADO_7").Length();
            Map(x => x.RESERVADO_01, "RESERVADO_01");
            Map(x => x.RESERVADO_02, "RESERVADO_02");
            Map(x => x.RESERVADO_03, "RESERVADO_03");
            Map(x => x.RESERVADO_04, "RESERVADO_04");
            Map(x => x.RESERVADO_05, "RESERVADO_05");
            Map(x => x.RESERVADO_07, "RESERVADO_07");
            Map(x => x.RESERVADO_08, "RESERVADO_08");
            Map(x => x.RESERVADO_10, "RESERVADO_10").Length();
            Map(x => x.RESERVADO_13, "RESERVADO_13");
            Map(x => x.RESERVADO_14, "RESERVADO_14");
            Map(x => x.RESERVADO_15, "RESERVADO_15");
            Map(x => x.RESERVADO_16, "RESERVADO_16");
            Map(x => x.RESERVADO_17, "RESERVADO_17");
            Map(x => x.RESERVADO_18, "RESERVADO_18");
            Map(x => x.RESERVADO_19, "RESERVADO_19");
            Map(x => x.RESERVADO_20, "RESERVADO_20");
            Map(x => x.RESERVADO_21, "RESERVADO_21");
            Map(x => x.RESERVADO_22, "RESERVADO_22");
            Map(x => x.RESERVADO_23, "RESERVADO_23");
            Map(x => x.RESERVADO_24, "RESERVADO_24");
            Map(x => x.RESERVADO_25, "RESERVADO_25").Length();
            Map(x => x.RESERVADO_26, "RESERVADO_26").Length();
            Map(x => x.RESERVADO_27, "RESERVADO_27").Length();
            Map(x => x.RESERVADO_28, "RESERVADO_28").Length();
            Map(x => x.RESERVADO_29, "RESERVADO_29");
            Map(x => x.RESERVADO_30, "RESERVADO_30");
            Map(x => x.RESERVADO_31, "RESERVADO_31");
            Map(x => x.RESERVADO_32, "RESERVADO_32");
            Map(x => x.CMSG, "CMSG");
        }
    }
}
