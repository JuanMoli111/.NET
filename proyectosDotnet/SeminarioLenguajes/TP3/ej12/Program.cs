using System;

using System.Collections;


namespace ej12
{
    class Program
    {

        static Hashtable cargarTabla()
        {
            Hashtable tabla = new Hashtable();

            //Agregar caracteres hasta la N
            for(int num = 1, Ascii = 65; Ascii <= 78; num++, Ascii++){
                tabla.Add((char)Ascii,num);
            }

            //Agregar la Ñ manualmente 
            tabla.Add('Ñ',15);     

            //Agregar los caracteres desde la O hasta la Z
            for(int num = 16, Ascii = 79; Ascii <= 90; num++, Ascii++){                
                tabla.Add((char)Ascii,num);
            }

            //Agregar manualmente el caracter de espacio
            tabla.Add((object)"sp",28);

            return tabla;
        }

        static void mostrarTabla(Hashtable tabla)
        {

            foreach (var keys in tabla.Keys)
            {
                Console.WriteLine($"Para la clave {keys} el valor es {tabla[keys]}");
            }

        }




        static void Main(string[] args)
        {
            
            Hashtable tabla = cargarTabla();


            mostrarTabla(tabla);



            //LEER TEXTO
            Console.WriteLine("Ingresar el texto");
            string texto = Console.ReadLine();


            //lEER CLAVE, GENERAR UN ARREGLO DE STRINGS CON LAS CLAVES
            Console.WriteLine("Ingresar las claves separadas por coma");
            string[] ArregloClaves = Console.ReadLine().Split(",");


            Queue ColaClaves = new Queue();

            for(int j = 0; j < ArregloClaves.Length; j++)
            {
                ColaClaves.Enqueue(ArregloClaves[j]);
            }
            

            //FOR CADA CHAR DEL TEXTO
                //ENCOLAMOS EL PRIMER ELEM, CONSULTANDOLO CON PEEK()
                //DESENCOLAMOS CLAVE
                //CACLULAR CODIGO CIFRADO USANDO CLAVE
            

            //Declarar arreglo de enteros con tantos elementos como caracteres el texto, para cada clave correspondiente a cada char
            int[] CodigoCifrado = new [texto.Length];

            //Declarar un int como variable auxiliar para 
            int clave;

            for(int i = 0; i < texto.Length; i++)
            {
   
                //Encolar la primer clave, ej para la cola 3,5,6 queda 3,5,6,3
                ColaClaves.Enqueue(ColaClaves.Peek());


                int numCifrado = tabla[texto[i]] + ColaClaves.Dequeue();
                

                //guardar en el arreglo de enteros codigoCifrado, el codigo cifrado correspondiente a este char,
                // para calcularlo conseguir el valor con el hashtable y sumarle la clave desencolandola
                CodigoCifrado[i] = tabla[texto[i]] + ColaClaves.Dequeue();


                
                //SI RESULTADO ES MAYOR A 28 CALCULAR (RESULTADO MOD 28) ESTE RESTO ES EL CODIGO EFECTIVO
                numCifrado <= 28 ? numCifrado : numCifrado Mod 28;

            }


        }
    }
}
