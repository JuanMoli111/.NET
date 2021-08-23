using System;

namespace ej10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for(int i = 0; i <= 1000; i++)
            {
                if((i % 17 == 0) | (i % 29 == 0))
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}
