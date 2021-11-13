using System;

namespace ej6
{
    class Program
    {

        static double[,] Suma(double[,] A, double[,] B)
        { 


            if((A.GetLength(0) != B.GetLength(0)) || (A.GetLength(1) != B.GetLength(1)))
            {
                throw new ArgumentException("Las matrices no se pueden sumar");
            }
            else
            {
                double[,] aux = new double[A.GetLength(0),A.GetLength(1)];
            

                for(int i = 0; i < A.GetLength(0); i++)
                {
                    
                    for(int j = 0; j < A.GetLength(1); j++)
                    {

                        aux[i,j] = A[i,j] + B[i,j];
                    }

                }
            
                return aux;
            }
        }
        
        
        static double[,] Resta(double[,] A, double[,] B)
        {
            if((A.GetLength(0) != B.GetLength(0)) || (A.GetLength(1) != B.GetLength(1)))
            {
                throw new ArgumentException("Las matrices no se pueden sumar");
            }
            else
            {
                double[,] aux = new double[A.GetLength(0),A.GetLength(1)];
            

                for(int i = 0; i < A.GetLength(0); i++)
                {
                    
                    for(int j = 0; j < A.GetLength(1); j++)
                    {

                        aux[i,j] = A[i,j] - B[i,j];
                    }

                }

                return aux;
            }
            
            return null;

        }
        
        

        static double[,] Multiplicacion(double[,] A, double[,] B)
        {
            if(A.GetLength(1) != B.GetLength(0))
            {
                throw new ArgumentException("Las matrices no se pueden multiplicar");
                return null;
            }
            else
            {
                double[,] aux = new double[A.GetLength(0),B.GetLength(1)];


                //Para cada fila y columna de la nueva matriz...
                for(int i = 0; i < A.GetLength(0); i++)
                {   
                    for(int j = 0; j < B.GetLength(1); j++)
                    {

                        //Declarar e inicializar un total en cero
                        double total = 0;

                        //Para k desde 0 hasta M (columnas de A y filas de B) este for representa la sumatoria
                        for(int k = 0; k < A.GetLength(1); k++)
                        {
                            
                            //Segun la formula de la multiplicacion de las matrices, la pos i,j igual a la sumatoria de las multiplicaciones 
                            //  a(i,k) * b(k,j) desde k hasta M
                            total += A[i,k] * B[k,j];

                        }

                        //Almacenar el total calculado en la pos correspondiente
                        aux[i,j] = total;

                    }

                }
                return aux;

            }

        }
        static void imprimir (double [,] A){
            for (int row=0;row<A.GetLength(0);row++) {
                for (int col=0;col<A.GetLength(1);col++) {
                    Console.Write($"{A[row,col],1} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            double[,] matriz1 = new double[,] {
                {2,0,1},
                {3,0,0},
                {5,1,1},
                };


            double[,] matriz2 = new double[,] {
                {1,0,1},
                {1,2,1},
                {1,1,0}, 
                
                };

            double [,] resultado = Resta(matriz1,matriz2);

            

            imprimir(resultado);

        }
    }
}
