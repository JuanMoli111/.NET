using System;

namespace ej14
{
    class Program
    {

        static bool esPrimo(int n)
        {
            for(int i = 2; i <= Math.Sqrt(n); i++) 
                if(n % i == 0) return false;

            return true;
        }

        static void Main(string[] args)
        {
            
            try
            {
                //Informa segun el retorno, si el argumento pasado es o no es un numero primo
                if(esPrimo(int.Parse(args[0]))) Console.WriteLine(args[0] + " es primo ");
                else Console.WriteLine(args[0] + " no es primo ");
            }
            catch
            {
                Console.WriteLine("Error en ejecucion");
            }
        }
    }
}
