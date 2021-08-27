using System;

namespace ej7
{
    class Program
    {
        static void Main(string[] args)
        {


            char c;
            char? c2;
            string st;

            c = "";         //ERROR DE COMPILACION c es de tipo caracter no puede asignarsele un valor string
            c = '';         
            c = null;       //ERROR DE COMPILACION c no es un tipo nulable

            c2 = null;
            c2 = (65 as char?);  //Siempre es null por que 65 es tipo valor y un char nulable es tipo referencia (no puede realizar la conversion y el operador as retorna null )

            st = "";
            st = '';           //ERROR DE COMPILACION el literal de caracter estaba vacio (si hubiera sido un caracter real, el error seria por asignar un char a un string)
            st = null;          

            st = (char)65;        //ERROR COMPILACION no se puede asignar el char 65 a un string 
            st = (string)65;        //ERROR COMPILACION no se puede castear el int en string

            st = 47.89.ToString();

        }
    }
}
