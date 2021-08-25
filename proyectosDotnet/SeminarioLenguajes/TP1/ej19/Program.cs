using System;

namespace ej19
{
    class print
    {
        static void Main(string[] args)
        {

            /*                               */
            int b; int c; int a = b = c = 1;      // las variables = 1
            int c; int a, b = c = 1;              // a queda sin inicializar, c y b seran = 1
            int c; int a = 2, b = c = 1;          // b y c = 1, a  = 2
            int a = 2, b, c, d = 2 * a;           //b y c solo inicializadas, a = 2 y     d = 4
            int a = 2, int b = 3, int c = 4;      //ERROR esperaba un ; o un identificador, al declarar en la misma linea de codigo no es necesario volver a especificar el tipo de dato
            int a;int c = a;                      //ERROR la variable a no está inicializada
            char c = 'A', string st = "Hola";     //ERROR esperaba un ; o identificador, al declarar en la misma linea las variables deben ser del mismo tipo
            char c = 'A'; string st = "Hola";     //Declara e inicializa dos variables, una de tipo char c en 'A' y un string st en "Hola"
            char c = 'A', st = "Hola";            //ERROR no puede convertir implicitamente string en char, al declarar variables en la misma linea deben de ser del mismo tipo


            Console.WriteLine(c);
        }
    }
}
