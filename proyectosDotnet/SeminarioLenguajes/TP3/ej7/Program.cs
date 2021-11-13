using System;

namespace ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            var x = i * 1.0;

            var y = 1.9f;

            var z = i * y;

            //test
            Console.WriteLine("i es de tipo " + i.GetType());

            Console.WriteLine("X es de tipo " + x.GetType());
            Console.WriteLine("Y es de tipo " + y.GetType());
            Console.WriteLine("Z es de tipo " + z.GetType());


        }
    }
}
