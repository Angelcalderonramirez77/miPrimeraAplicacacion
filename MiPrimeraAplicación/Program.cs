using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAplicación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, profesion, motivo;

            byte edad, actualYear , nacimientoYear; ;
            
            Console.Write("Ingresa tu nombre: ");
             nombre = Console.ReadLine();

            Console.Write("Ingresa tu profesión: ");
             profesion = Console.ReadLine();

            Console.Write("motivo por el que estudia programación: ");
             motivo = Console.ReadLine();

            Console.Write("\n");

            Console.WriteLine($"Bienvenido Sr (a) {nombre} al curso de desarrollo de aplicaciones mi " +
                $"profesion es {profesion} , mi motivo es {motivo} ");

            Console.ReadLine();
        }
    }
}
