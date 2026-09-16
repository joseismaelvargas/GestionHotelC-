
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Huespedes
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public double Telefono { get; set; }


        public Huespedes(string nombre,int dni,string email,int telefono)
        {
           
            Nombre = nombre;
            Dni = dni;
            Email = email;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return $"{Nombre} - DNI: {Dni}";
        }
    }
}
