using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = Console.ReadLine();


            if(nombre == "Juan")
            {
                Console.WriteLine("Hola Mundo");
            }
            else if(nombre == "Maria")
            {
                Console.WriteLine("Buen dia señora");
            }
            else if(nombre == "Alberto")
            {
                Console.WriteLine("¡Hola Alberto!");
            }
            else if(nombre == "")
            {
                Console.WriteLine("¡Buen dia mundo!");
            }
            else
            {
                Console.WriteLine("Buen dia ");
            }


        }
    }
}
