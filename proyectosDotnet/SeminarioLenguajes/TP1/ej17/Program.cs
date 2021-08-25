using System;

namespace ej17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar e inicializar dos enteros
            int a = 3, b = 6;

            //entero C es igual al menor entero entre a y b
            int c = (a < b) ? a : b;


            Console.WriteLine(c);
        }
    }
}
