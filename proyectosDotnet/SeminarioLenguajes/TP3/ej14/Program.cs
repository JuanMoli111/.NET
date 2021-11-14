using System;
using System.Collections;

namespace ej14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero!");
            String numStr = Console.ReadLine();

            int base10 = int.Parse(numStr);


            Console.WriteLine("Ingrese una base a la que transformar el numero");
            String baseStr = Console.ReadLine();

            int basex = int.Parse(baseStr);

            if(basex < 2)
            {
                Console.WriteLine("La base debe ser mayor a uno");
            }
            else
            {
                Stack Pila = new Stack();

                //Apilar el resto
                Pila.Push(base10 % basex);

                while(basex < base10)
                {
                    //Num = num / base
                    base10 /= basex;

                    //Apilar el resto
                    Pila.Push(base10 % basex);
                }

                Console.Write(base10 / basex + " ");
                
                while(Pila.Count > 0)
                {
                    Console.Write(Pila.Pop() + " ");
                }
            }

        }
    }
}
