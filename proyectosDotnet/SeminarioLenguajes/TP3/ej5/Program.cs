using System;

namespace ej5
{
    class Program
    {

        static double[][] GetArregloDeArreglo(double [,] matriz)
        {

            //Declarar e incializar un arreglo de arreglos, para el arreglo principal su longitud corresponde con la de la primer dimension de la matriz
            //EJEMPLO para una matriz de 4x6 filas por columnas, precisamos un arreglo de cuatro arreglos, luego la dimension de estos sera la segunda dim de la matriz (columnas)
            double[][] ArregloArreglos = new double[matriz.GetLength(0)][];
            

            //Declarar para cada arreglo interno, su longitud respecto a la 2da dimension de la matriz (columnas)
            for(int k = 0; k < matriz.GetLength(0); k++)
            {
                ArregloArreglos[k] = new double[matriz.GetLength(1)];
            }


            //Para cada elemento del arreglo principal (estos elementos son arreglos)
            // dicho de otra forma:     Para el iésimo arreglo del arreglo de arreglos
            for(int i = 0; i < ArregloArreglos.Length; i++)
            {

                //Para cada elemento de los arreglos internos, almacenar el valor correspondiente
                // dicho de otra forma:     Para el jotaésimo elemento del iésimo arreglo, setearle el elemento de la matriz que haya en la posicion i - j
                for(int j = 0; j < ArregloArreglos[i].Length; j++)
                {
                    ArregloArreglos[i][j] = matriz[i,j];
                }
                
                Console.WriteLine();
            }

            //Retornar el arreglo de arreglos
            return ArregloArreglos;

        }

        static void Main(string[] args)

        {
            //Declarar e inicializar una matriz de prueba

            double[,] matriz = new double[4,3] {{1,2,3},{4,5,6},{7,888,9},{10,15,20}};

            double[][] Data = GetArregloDeArreglo(matriz);

            Console.WriteLine(Data.);
        }
    }
}
