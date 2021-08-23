using System;

namespace ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año se confirmara si es bisiesto");
        
            string stAnio = Console.ReadLine();

            int anio = int.Parse(stAnio);

            if((anio % 4 == 0) | ((anio % 100 == 0) & (anio % 400 == 0)))
            {
                Console.WriteLine("es bisiesto");
            }
            else
            {
                Console.WriteLine("no es bisiesto");
            }

        
        }
    }
}
