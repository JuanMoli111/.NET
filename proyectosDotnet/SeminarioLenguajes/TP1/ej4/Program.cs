using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre");

            string st = Console.ReadLine();


            if(st != "")
            {
                Console.WriteLine("Hola " + st);
            }
            else
            {
                Console.WriteLine("Hola Mundo!");
            }
        }
    }
}
