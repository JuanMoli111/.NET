using System;

namespace ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            String strNum = Console.ReadLine();
            
            int Contador = 0;

            while(strNum != "")
            {
                
                try
                {
                    Contador += int.Parse(strNum);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Total: " + Contador);

                Console.WriteLine("Ingrese un nuevo numero");
                strNum = Console.ReadLine();
            }
        }
    }
}
