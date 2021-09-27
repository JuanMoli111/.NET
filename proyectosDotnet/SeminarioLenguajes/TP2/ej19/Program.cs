using System;

namespace ej19
{
    class Program
    {

        static void Imprimir(params object[] parametros)
        {
            foreach(object item in parametros)
            {
                Console.WriteLine(item);//.ToString();
            }

        }
        static void Main(string[] args)
        {
            Imprimir(1, 2.15, "tres coma catorce", true);
        }
    }
}
