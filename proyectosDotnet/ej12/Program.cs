using System;

namespace ej12
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();

            int num = int.Parse(st);

            
            for(int i = 1; i <= num;i++)
            {
                
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
