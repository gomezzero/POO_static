// uso de propiedades y metodos
using POO_static.Models;

Console.Clear();
// var ejemplo1 = new Ejemplo();
// Console.WriteLine("Nombre =>" + ejemplo1.Nombre); 
// Console.WriteLine("Nombre =>" + ejemplo1.Apellido);
// ejemplo1.Saludo(); 

// // uso de propiedades y metodos con static
// EjemploEstatico.Nombre = "ZERO";
// EjemploEstatico.Apellido = "";
// Console.WriteLine("Nombre =>" + EjemploEstatico.Nombre); 
// Console.WriteLine("Nombre =>" + EjemploEstatico.Apellido);
// EjemploEstatico.Saludo();

// uso de un constructor statico
// EjemploEstatico.Saludo();
EjemploHibrido.MostarHead();
var nuevoUsuario = new EjemploHibrido(1, "Zero", "", 171);
nuevoUsuario.Mostrarinformacion();
EjemploHibrido.MostarFoter();
EjemploHibrido.MostarFoter();