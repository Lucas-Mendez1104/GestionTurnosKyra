using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTurnosKyra.Data.Models.GestionTurnos
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaTurno { get; set; } 
        public double PrecioFinal {  get; set; }
        public bool EstaCompletado {  get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ServicioId { get; set; }
        public virtual Servicio Servicio { get; set; }

    }
}
