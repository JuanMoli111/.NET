using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'A';
            string st1 = "A";
            object o1 = c1;             //El char es tipo valor, el obj o1 será de tipo char en este caso
            object o2 = st1;            // --> Provoca Boxing, el obj o2 es una referencia a un tipo string en la heap
            
            Console.WriteLine("El objeto 1: " + o1 + " es de tipo: " + o1.GetType());

            char c2 = (char)o1;         //conjetura: No provoca unboxing, por que el objeto ya era de tipo char, la conversion mediante (char) debe ser explicita de todos modos
    
            string st2 = (string)o2;    // Unboxing

            Console.WriteLine("El caracter 2: " + c2 + " es de tipo: " + c2.GetType());
        }
    }
}
