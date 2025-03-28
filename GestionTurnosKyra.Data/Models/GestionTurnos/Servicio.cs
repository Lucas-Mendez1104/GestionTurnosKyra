using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTurnosKyra.Data.Models.GestionTurnos
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double CostoHombre {  get; set; }
        public double CostoMujer {  get; set; }
        public bool Habilitado {  get; set; }
    }
}
