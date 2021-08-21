using System;

namespace ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();

            while(st.Length != 0)
            {
                Console.WriteLine(st.Length);

                st = Console.ReadLine();
            }

        }
    }
}
