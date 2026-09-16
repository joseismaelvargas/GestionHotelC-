using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Reserva
    {
        public Huespedes Huesped { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime  FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadPersonas { get; set; }
       
    }
}
