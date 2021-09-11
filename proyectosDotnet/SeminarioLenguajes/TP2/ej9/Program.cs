using System;
using System.Text;
namespace ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            //string st = "Ho";

            StringBuilder st = new StringBuilder("Ho");


            //Ingresar 100.000 - 200.000 para empezar a notar la dif
            Console.WriteLine("Ingrese una cantidad de caracteres: ");


            int cantidad = int.Parse(Console.ReadLine());

            for(int i = 0; i < cantidad;i++)
            {
                st.Append("o");

                //st += "o";
            }

        }
    }
}
