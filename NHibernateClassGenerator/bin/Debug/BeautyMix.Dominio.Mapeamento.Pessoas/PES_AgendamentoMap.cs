using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautyMix.Dominio.Entidades.Pessoas;

namespace BeautyMix.Dominio.Mapeamento.Pessoas
{
    public class PES_AgendamentoMap : ClassMap<PES_Agendamento>
    {
        public PES_AgendamentoMap()
        {
            Table("agendamento");
            Id(x => x.Id, "id").GeneratedBy.Native();

            Map(x => x.Id_Profissional, "id_profissional").Not.Nullable();
            Map(x => x.Id_Servico, "id_servico").Not.Nullable();
            Map(x => x.Id_Cliente, "id_cliente").Not.Nullable();
            Map(x => x.Data_Agendamento, "data_agendamento");
        }
    }
}
