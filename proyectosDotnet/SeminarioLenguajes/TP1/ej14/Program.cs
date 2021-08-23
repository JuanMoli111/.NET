using System;

namespace ej14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un numero");
            string st = Console.ReadLine();

            //Convertir el numero ingresado en integer
            string num = "" + int.Parse(st) * 365;

            //Convertir el resultado nuevamente a string
            
            //Console.WriteLine(num);

            //Para cada caracter del numero
            for(int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
                
            }
        }
    }
}
