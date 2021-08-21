using System;

namespace ej5b
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = Console.ReadLine();

            switch (nombre)
            {
                case "Juan":
                    Console.WriteLine("Hola Mundo");
                    break;

                case "Maria":
                    Console.WriteLine("Buen dia señora");
                    break;

                case "Alberto":
                    Console.WriteLine("¡Hola Alberto!");
                    break;

                case "":
                    Console.WriteLine("¡Buen dia mundo!");
                    break;

                default:
                    Console.WriteLine("Buen dia");
                    break;
            }


        }
    }
}
