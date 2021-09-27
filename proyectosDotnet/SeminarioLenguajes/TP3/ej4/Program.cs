
using System;

namespace ej3
{
    class Program
    {
        static double[] GetDiagonalPrincipal(double[,] matriz)
        {

            try{

                //Controlar y levantar la excepcion manualmente
                if(matriz.GetLength(0) != matriz.GetLength(1))
                {
                    throw new ArgumentException();
                }

                //Crear un arreglo con la dim fisica de la matriz cuadrada,
                double[] Diagonal = new double[matriz.GetLength(0)];
                    
                //Guardar cada elemento de la diag principal en un arreglo de double
                for(int i = 0; i < matriz.GetLength(0); i++) Diagonal[i] = matriz[i,i];
                  
                return Diagonal;
            }
            //Manejar la excepcion ArgumentException
            catch (ArgumentException E)
            {
                //Jugando con el informe del error y los datos de la excepcion levantada
                Console.WriteLine($"El error {E.GetType()} {E.ToString().Split("\\")[5]} {E.Data}");

                Console.WriteLine("\n La matriz debe de ser cuadrada");
                return null;
            }

        }

        static double[] GetDiagonalSecundaria(double[,] matriz)
        {
            try{

                //Controlar y levantar la excepcion manualmente
                if(matriz.GetLength(0) != matriz.GetLength(1))
                {
                    throw new ArgumentException();
                }

                //Crear un arreglo coon la dim fisica de la matriz cuadrada,
                double[] Diagonal = new double[matriz.GetLength(0)];
     
                Console.WriteLine(matriz.GetLength(0));
                Console.WriteLine(matriz.GetLength(1));


                //Guardar cada elemento de la diag secundaria en un arreglo de double
                int col = 0;

                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    Diagonal[i] = matriz[matriz.GetLength(0) - i - 1 ,  i];
                }
                    
                return Diagonal;
            }
            //Manejar la excepcion ArgumentException
            catch (ArgumentException E)
            {
                //Jugando con el informe del error y los datos de la excepcion levantada
                Console.WriteLine($"El error {E.GetType()} {E.ToString().Split("\\")[5]} {E.Data}");

                Console.WriteLine("\n La matriz debe de ser cuadrada");
                return null;
            }
        }

        
        static void Main(string[] args)
        {

            double[,] matriz = new double[4,4] {{1,2,3,4},{4,10,44,46},{5,6,7,8},{0,10,100,100}};

            double[] Diago = GetDiagonalSecundaria(matriz);

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }

            for(int k = 0; k < Diago.GetLength(0); k++)
            {
                Console.WriteLine(Diago[k]);
            }

        }
    }
}