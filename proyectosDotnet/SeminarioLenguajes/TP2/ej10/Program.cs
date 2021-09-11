using System;
using System.Text;
namespace ej9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crear un string builder, para probar el algoritmo con strings descomentar la linea 13
            StringBuilder st = new StringBuilder("Ho");

            //string st = "Ho";


            //Ingresar 100.000 - 200.000 para notar grandes diferencias
            Console.WriteLine("Ingrese una cantidad de caracteres: ");


            int cantidad = int.Parse(Console.ReadLine());


            //Crear una clase tipo DateTime, le damos la fecha y hora actual
            DateTime date1 = DateTime.Now;

            //Agregar a la cadena de caracteres, tantas 'o' como indique la variable cantidad
            for(int i = 0; i < cantidad;i++)
            {
                st.Append("o");

                //st += "o";
            }

            //Crear una clase TimeSpan y calcular cuanto paso desde que creo DateTime hasta que termino el for
            TimeSpan duracion = DateTime.Now - date1;


            Console.WriteLine("Tardo " + duracion.TotalSeconds + " segundos "); 
        }
    }
}
