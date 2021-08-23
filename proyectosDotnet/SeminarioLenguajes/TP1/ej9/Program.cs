using System;

namespace ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1, st2;
            
            bool esSimetrico = true;


            //El usuario ingresa dos palabras y el programa debe determinar si estas son simetricas

            Console.WriteLine("Ingrese dos palabras");

            st1 = Console.ReadLine();
            st2 = Console.ReadLine();

            //Si las palabras tienen distinto tamaño no son simetricas
            if(st1.Length != st2.Length)
            {
                esSimetrico = false;

            }
            else
            //Si las palabras tienen el mismo tamaño debe verificarse que son simetricas
            {
                //Para i desde 0 hasta la longitud de las palabra
                for(int i = 0; i < st1.Length;i++)
                {
                    //Comprobara si el primer caracter de la primer palabra es igual al ultimo de la segunda palabra, 
                    //si el segundo caracter de la primer palabra es igual al anteultimo de la segunda palabra, etc...
                    //Si alguno no llegase a coincidir las palbras no son simetricas, entonces debe ser false el booleano esSimetrico

                    if(st1[i] != st2[st2.Length - 1 - i])
                    {
                        esSimetrico = false;
                    }


                }
            }

            //Informar
            if(esSimetrico)
            {
                Console.WriteLine("Las palabras son simetricas");
            }
            else
            {
                Console.WriteLine("Las palabras no son simetricas");
            }
        
        }
    }
}
