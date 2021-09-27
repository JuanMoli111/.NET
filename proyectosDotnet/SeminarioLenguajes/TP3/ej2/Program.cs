using System;

namespace ej2
{
    class Program
    {
        static void ImprimirMatriz(double[,] matriz)
        {
            
            int i , j;

            for(j = 0; j < matriz.GetLength(1) ; j++)
            {

    
                for(i = 0; i < matriz.GetLength(0); i++)
                {

                    matriz[i,j] = i * (Math.Pow(j,4));

                    Console.Write($"{matriz[i,j],-4} |");

                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
            }
        }

        static void ImprimirMatriz(double[,] matriz, string formatString)
        {
            int i , j;


            for(j = 0; j < matriz.GetLength(1) ; j++)
            {    
                for(i = 0; i < matriz.GetLength(0); i++)
                {

                    matriz[i,j] = Math.E * (i + 1/Math.PI * (Math.Pow(j + 1,4)));

                    //No se me ocurrio mejor manera ¿?
                    if(formatString == "0.0") Console.Write($"{matriz[i,j],-6:0.0}|");
                    else if(formatString == "0.00") Console.Write($"{matriz[i,j],-6:0.00}|");
                    else Console.Write($"{matriz[i,j],-4}|");

                }
                Console.WriteLine();
                Console.WriteLine("---------~---------~---------~---------~--");
            }
        }


        static void Main(string[] args)
        {
            double[,] matriz = new double[6,4];

    
            ImprimirMatriz(matriz,"0.0");
        }
    }
}


