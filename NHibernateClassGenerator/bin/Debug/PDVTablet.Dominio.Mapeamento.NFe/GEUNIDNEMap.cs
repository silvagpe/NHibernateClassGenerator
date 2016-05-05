using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDVTablet.Dominio.Entidades.NFe;

namespace PDVTablet.Dominio.Mapeamento.NFe
{
    public class GEUNIDNEMap : ClassMap<GEUNIDNE>
    {
        public GEUNIDNEMap()
        {
            Table("GEUNIDNE");
            Map(x => x.CAMPO13, "CAMPO13").Length();
            Map(x => x.CAMPO14, "CAMPO14").Length();
            Map(x => x.CAMPO15, "CAMPO15").Length();
            Map(x => x.UF, "UF").Length();
            Map(x => x.CAMPO17, "CAMPO17").Length();
            Map(x => x.CAMPO18, "CAMPO18").Length();
            Map(x => x.CAMPO19, "CAMPO19").Length();
            Map(x => x.CAMPO20, "CAMPO20").Length();
            Map(x => x.CAMPO21, "CAMPO21").Length();
            Map(x => x.CAMPO22, "CAMPO22");
            Map(x => x.CAMPO23, "CAMPO23");
            Map(x => x.CAMPO24, "CAMPO24");
            Map(x => x.CAMPO25, "CAMPO25");
            Map(x => x.CAMPO26, "CAMPO26");
            Map(x => x.CAMPO27, "CAMPO27");
            Map(x => x.CAMPO28, "CAMPO28");
            Map(x => x.CAMPO29, "CAMPO29");
            Map(x => x.CAMPO30, "CAMPO30");
            Map(x => x.CAMPO31, "CAMPO31");
            Map(x => x.CAMPO32, "CAMPO32");
            Map(x => x.USRPAIS1, "USRPAIS1").Length();
            Map(x => x.USRPAIS2, "USRPAIS2").Length();
            Map(x => x.USRPAIS3, "USRPAIS3").Length();
            Map(x => x.USRPAIS4, "USRPAIS4");
            Map(x => x.USRPAIS5, "USRPAIS5");
            Map(x => x.USUARIO_CRIACAO, "USUARIO_CRIACAO").Length();
            Map(x => x.DT_MODIFICACAO, "DT_MODIFICACAO");
            Map(x => x.CD_UNIDADE_DE_NN, "CD_UNIDADE_DE_N").Length();
            Map(x => x.CD_EMPRESA, "CD_EMPRESA").Length();
            Map(x => x.NOME_COMPLETO, "NOME_COMPLETO").Length();
            Map(x => x.FANTASIA, "FANTASIA").Length();
            Map(x => x.CODIGO_OUTROS, "CODIGO_OUTROS").Length();
            Map(x => x.CODIGO_ECF, "CODIGO_ECF").Length();
            Map(x => x.CD_RESPONSAVEL, "CD_RESPONSAVEL").Length();
            Map(x => x.RESPONSAVEL, "RESPONSAVEL").Length();
            Map(x => x.CARGO, "CARGO").Length();
            Map(x => x.USUARIO_MODIFIC, "USUARIO_MODIFIC").Length();
            Map(x => x.SESSAO, "SESSAO");
            Map(x => x.CAMPO5, "CAMPO5");
            Map(x => x.CAMPO6, "CAMPO6");
            Map(x => x.CAMPO7, "CAMPO7");
            Map(x => x.CAMPO8, "CAMPO8");
            Map(x => x.CAMPO9, "CAMPO9").Length();
            Map(x => x.CAMPO10, "CAMPO10").Length();
            Map(x => x.CAMPO11, "CAMPO11").Length();
            Map(x => x.CAMPO12, "CAMPO12").Length();
        }
    }
}
