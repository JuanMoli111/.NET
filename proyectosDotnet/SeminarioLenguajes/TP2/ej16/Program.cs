using System;

namespace ej16
{
    class Program
    {

        static int Factorial(int n)
        {
            for(int i = n - 1; i > 1; i--)
            {
                Console.WriteLine($"{n} * {i}");

                n *= i;
            }

            return n;
        }

        static int FactorialRecursivo(int n)
        {
            if(n < 2) return 1;
            else return (n * FactorialRecursivo(n - 1));

        }

        static int FactorialExpBodied(int n) => return (i < 2) ? 1 : (n * FactorialExpBodied(n - 1));

        
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero natural");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"El factorial de {n}: " + FactorialRecursivo(n));

        }
    }
}
