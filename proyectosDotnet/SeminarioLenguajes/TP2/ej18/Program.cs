using System;

namespace ej18
{
    class Program
    {

        static void Swap(ref int val1, ref int val2)
        {
            int aux = val1;

            val1 = val2;

            val2 = aux;

        }
        static void Main(string[] args)
        {
            int i = 1,j = 2;


            Swap(ref i, ref j);

            Console.WriteLine($"variable i {i}, y la j {j}");
        }
    }
}
