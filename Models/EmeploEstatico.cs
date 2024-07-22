using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models
{
    public class EmeploEstatico
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public EmeploEstatico ()
        {
            Nombre = "Zero";
            Apellido = " ";
        }
        public void Saludo()
        {
            Console.WriteLine($"Buenos dias Sr.{Nombre} {Apellido}");
        }

    }
}