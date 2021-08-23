using System;

namespace ej13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros reales");

            string st1 = Console.ReadLine();
            string st2 = Console.ReadLine();

            double num1 = double.Parse(st1);
            double num2 = double.Parse(st2);

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

        }
    }
}
