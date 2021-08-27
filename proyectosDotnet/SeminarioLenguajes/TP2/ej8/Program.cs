using System;

namespace ej8
{
    class Program
    {
        static void Main(string[] args)
        {

            //inciso a

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Hola " + args[i]);
            }

            Console.WriteLine();

            //inciso b

            foreach (string nombre in args)
            {
                Console.WriteLine("Hola " + nombre);
            }
        }
    }
}
