using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautyMix.Dominio.Entidades.Pessoas
{
    public class PES_Agendamento : IEntidade
    {
        public virtual int Id { get; set; }

        public virtual int Id_Profissional { get; set; }

        public virtual int Id_Servico { get; set; }

        public virtual int Id_Cliente { get; set; }

        public virtual DateTime? Data_Agendamento { get; set; }

        public virtual ? Hora_Inicial { get; set; }

        public virtual ? Hora_Final { get; set; }

    }
}
