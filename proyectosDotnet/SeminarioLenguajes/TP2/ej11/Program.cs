using System;

namespace ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");


            string st = Console.ReadLine();
        
            foreach(string subst in st.Split(' '))
            {
                Console.WriteLine(subst);
            }
        }
    }
}
