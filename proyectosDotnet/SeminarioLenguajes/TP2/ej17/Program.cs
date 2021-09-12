using System;

namespace ej17
{
    class Program
    {

        static void Factorial(int n, out int fac)
        {
            fac = n;

            for(int i = n - 1; i > 1; i--)
            {
                Console.WriteLine($"{i} * {i - 1}");

                fac *= i;
            }

        }

        static void FactorialRecursivo(int num, out int fac)
        {
            
            if(num > 0)
            {
                FactorialRecursivo(num-1,out fac);
                fac *= num;

            }
            else
            {
                fac = 1;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero natural");

            int n = int.Parse(Console.ReadLine());

            int fact = 1;
            
            FactorialRecursivo(n,out fact);

            Console.WriteLine($"El factorial de {n}: " + fact);

        }
    }
}
