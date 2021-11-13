using System;

namespace ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3L;

            dynamic b = 32;

            object obj = 3;


            Console.WriteLine("type of a is " + a.GetType());

            Console.WriteLine("Type of b is " + b.GetType());

            Console.WriteLine("type of obj is " + obj.GetType());

            //Error de compilacion no puede convertir implicitamente un double en long
            //a = a * 2.0;

            //No hay error de compilacion xq b es de tipo dynamic entonces el compilador no hace verificaciones de tipo
            b = b * 2.0;
            b = "hola";


            obj = b;

            // ???
            b = b + 11;

            Console.WriteLine("B is: " + b);

            //Error de compilacion no se puede aplicar + entre un object y un int
            obj = obj + 11;
            
            var c = new { Nombre = "Juan"};

            var d = new { Nombre = "María"};
            var e = new { Nombre = "Maria", Edad = 20};
            var f = new { Edad = 20, Nombre = "Maria"};

            //Error de compilacion, no puede setear la edad por que los tipos anonimos son de solo lectura
            f.Edad = 22;

            d = c;

            //Error de compilacion no puede convertir implicitamente un tipo con un campo string en un tipo con un campo string y uno int
            e = d;

            //Error de compilacion no puede convertir implicitamente un tipo con un campo string y uno int en un tipo con un campo int y uno string (el orden de los parametros afecta)
            f = e;
        }
    }
}
