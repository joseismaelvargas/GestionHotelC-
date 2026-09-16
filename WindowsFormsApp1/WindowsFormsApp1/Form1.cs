using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

      public  List<Huespedes> huespedesregistrados = new List <Huespedes>();
       public  List<Habitacion> habitaciones = new List<Habitacion>();
       
        public  List<Reserva> reservas = new List<Reserva>();
        public Form1()
        {
            InitializeComponent();
            guardarHabitaciones();
            guardarhuespedes();
            guardarReservas();
        }   

        public void guardarReservas()
        {
            Reserva reserva1 = new Reserva
            {
                Huesped = huespedesregistrados[3],
                Habitacion = habitaciones[1],
                FechaEntrada = new DateTime(2026, 9, 15),
                FechaSalida = new DateTime(2026, 9, 18),
                CantidadPersonas = 2
            };
            Reserva reserva2 = new Reserva
            {
                Huesped = huespedesregistrados[2],
                Habitacion = habitaciones[0],
                FechaEntrada = new DateTime(2026, 6, 15),
                FechaSalida = new DateTime(2026, 2, 18),
                CantidadPersonas = 2
            };
            reservas.Add(reserva1);
            reservas.Add(reserva2);
        }
        public void guardarhuespedes()
        {
            Huespedes huesped1 = new Huespedes
(
   "Juan Perez",
    12345678,
    "juan@gmail.com",
     381456789
);

Huespedes huesped2 = new Huespedes
(
   "Maria Gomez",
    23456789,
    "maria@gmail.com",
   815678901
);

Huespedes huesped3 = new Huespedes
(
  "Carlos Lopez",
  34567890,
  "carlos@gmail.com",
 81678901

)   ;

            Huespedes huesped4 = new Huespedes
(
  "jose ismael",
  34567890,
  "jose@gmail.com",
 81678901

);
            huespedesregistrados.Add(huesped1);
            huespedesregistrados.Add(huesped2);
            huespedesregistrados.Add(huesped3);
            huespedesregistrados.Add(huesped4);

        }
       public void guardarHabitaciones()
        {
            Habitacion habitacion101 = new Habitacion
            {
                Numero = 101,
                Tipo = "Individual",
                Precio = 30000,
                Estado = "Disponible"
            };

            Habitacion habitacion102 = new Habitacion
            {
                Numero = 102,
                Tipo = "Doble",
                Precio = 45000,
                Estado = "Disponible"
            };

            Habitacion habitacion103 = new Habitacion
            {
                Numero = 103,
                Tipo = "Triple",
            Precio = 60000,
                Estado = "Ocupada"
            };

            Habitacion habitacion104 = new Habitacion
            {
                Numero = 104,
                Tipo = "Suite",
                Precio = 90000,
                Estado = "Disponible"
            };

            Habitacion habitacion105 = new Habitacion
            {
                Numero = 105,
                Tipo = "Doble",
                Precio = 45000,
                Estado = "Mantenimiento"
            };

            habitaciones.Add(habitacion101);
            habitaciones.Add(habitacion102);
            habitaciones.Add(habitacion103);
            habitaciones.Add(habitacion104);
            habitaciones.Add(habitacion105);
        }



       

        private void label2_Click( object sender, EventArgs e)
        {
            Formgestion formgestion = new Formgestion(huespedesregistrados);
            
            formgestion.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Reservas formreserbas = new Reservas(habitaciones, huespedesregistrados,reservas);
            formreserbas.Show();

        }
    }
} 
