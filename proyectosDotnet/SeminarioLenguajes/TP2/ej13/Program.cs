using System;

namespace ej13
{
    class Program
    {

        //Declarar un tipo enumerativo con los meses del año
        enum Meses
        {
            Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un texto, se comprobara si corresponde a un mes");

            string st = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Lista de meses: \n");

            //Imprimir los meses al reves
            for(int i = 11; i >= 0; i--)
            {
                Console.WriteLine((Meses)i);

                //Si el string ingresado es igual a algun mes del tipo enumerativo, informarlo
                if(st == ((Meses)i).ToString()) Console.WriteLine("El texto ingresado es un mes!");
            }

        }
    }
}
