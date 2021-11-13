using System;
using System.Collections;

namespace ej13
{
    class Program
    {
        static void Main(string[] args)
        {
            //LEER EXPRESION
            Console.WriteLine("Ingresar expresion aritmetica");
            String texto = Console.ReadLine();


            //Declarar una pila
            Stack Parens = new Stack();

            Boolean Bal = true;


            //Para cada char en la expresion
            foreach(Char item in texto)
            {

                //Si el CHAR ES APERTURA DE PARENTESIS, APILARLO
                if(item == '(')
                {
                    Parens.Push(item);
                }

                //Si el CHAR es CIERRE DE PARENTESIS:
                else if(item == ')')
                {

                    //Si entro un parentesis de cierre pero no hay elementos en el stack, seguro esta desbalanceado
                    if(Parens.Count == 0 || (char)Parens.Peek() != '(')
                    {
                        Bal = false;
                    }
                    //Si tiene un parentesis de apertura correspondiente, desapilarlo
                    else if((char)Parens.Peek() == '(')
                    {
                        Parens.Pop();
                    }

                }
            }


            //Si BAL es TRUE y no hay elementos restantes en la pila
            if(Bal && Parens.Count == 0)
            {
                Console.WriteLine("Es balanceado!");
            }
            else
            {
                Console.WriteLine("La expresion no es balanceada");
            }


        }
    }
}
