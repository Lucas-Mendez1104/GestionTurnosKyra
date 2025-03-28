using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTurnosKyra.Data.Models.GestionTurnos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroTelefono { get; set; }
        public string Correo {  get; set; }
        public string Instagram { get; set; }
        public int Asistencias {  get; set; }
        public int Inasistencias { get; set; }
    }
}
