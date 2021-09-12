using System;

namespace ej15
{
    class Program
    {

        //Recibe el termino a calcular
        static int Fib(int n)
        {
            if(n <= 2) return 1;

            else return Fib(n - 1) + Fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un termino a calcular de la serie de Fibonacci");

            int num = int.Parse(Console.ReadLine());            

            Console.WriteLine("El termino " + num + " = " + Fib(num));
        }
    }
}
