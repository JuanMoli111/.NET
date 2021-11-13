using System;

namespace ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new int[10];
            dynamic dyn = 13;


            //Error de compilacion, por que object no tiene un campo Length
            Console.WriteLine(obj.Length);

            //Error de ejecucion, el tipo inferido int no tiene un campo Length, el compilador no levanta el error por que no realiza verificacion de tipos, para tipos dynamic
            Console.WriteLine(dyn.Length);
        }
    }
}
