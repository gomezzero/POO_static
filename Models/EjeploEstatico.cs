using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models
{
    public class EjemploEstatico
    {
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }

        static EjemploEstatico ()
        {
            Nombre = "Zero";
            Apellido = " ";
        }
        public static void Saludo()
        {
            Console.WriteLine($"Buenos dias Sr.{Nombre} {Apellido}");
        }

    }
}