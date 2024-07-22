using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models
{
    public class EjemploHibrido
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Altura { get; set; }

        public int cosa;

        public int Intended { get; set; }

        public EjemploHibrido(int id, string nombre, string apellido, int altura)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Altura = altura;
        }

        public void Mostrarinformacion()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Altura: {Altura}");
        }

        public static void MostarHead()
        {
            Console.WriteLine("######################");
            Console.WriteLine("       Detalles      ");
            Console.WriteLine("######################");
        }

        public static void MostarFoter()
        {
            Console.WriteLine("----------------------");
        }
    }
}