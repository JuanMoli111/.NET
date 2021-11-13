using System.Collections;
using System;

namespace ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList() {1,2,3,4};

            //No encuentra el elemento 5, pero no hay error
            a.Remove(5);

            //Error de indice no existe la pos 5
            //a.RemoveAt(5);
        }
    }
}
