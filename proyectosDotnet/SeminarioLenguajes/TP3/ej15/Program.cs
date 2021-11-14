using System;

namespace ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            try
            {
                Console.WriteLine(1.0 / x);
                Console.WriteLine(1 / x);
                Console.WriteLine("TODO OK");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
