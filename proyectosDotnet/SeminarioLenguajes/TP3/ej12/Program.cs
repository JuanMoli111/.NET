using System;

using System.Collections;


namespace ej12
{
    class Program
    {

        static Hashtable cargarTablaCifrado()
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
            tabla.Add(' ',28);

            return tabla;
        }

        static Hashtable cargarTablaDescifrado()
        {
            Hashtable tabla = new Hashtable();

            //Agregar caracteres hasta la N
            for(int num = 1, Ascii = 65; Ascii <= 78; num++, Ascii++){
                tabla.Add(num,(char)Ascii);
            }

            //Agregar la Ñ manualmente 
            tabla.Add(15,'Ñ');     

            //Agregar los caracteres desde la O hasta la Z
            for(int num = 16, Ascii = 79; Ascii <= 90; num++, Ascii++){                
                tabla.Add(num,(char)Ascii);
            }

            //Agregar manualmente el caracter de espacio
            tabla.Add(28,' ');

            return tabla;
        }


        static void mostrarTabla(Hashtable tabla)
        {

            foreach (var keys in tabla.Keys)
            {
                Console.WriteLine($"Para la clave {keys} el tipo es {tabla[keys].GetType()}");
            }
            foreach (var value in tabla.Values)
            {
                Console.WriteLine($"Para el valor {value} el tipo es {value.GetType()}");
            }
        }


        


        static void Main(string[] args)
        {
            
            //Declarar e inicializar las hashtable
            Hashtable tablaCifrado = cargarTablaCifrado();
            Hashtable tablaDescifrado = cargarTablaDescifrado();


            
            //mostrarTabla(tablaCifrado);




            //LEER TEXTO
            Console.WriteLine("Ingresar el texto");
            string texto = Console.ReadLine();


            //lEER CLAVE, GENERAR UN ARREGLO DE STRINGS CON LAS CLAVES
            Console.WriteLine("Ingresar las claves separadas por coma");
            string[] ArregloClaves = Console.ReadLine().Split(",");

            //Declarar arreglo de enteros con tantos elementos como caracteres del texto
            //aqui se guardara el codigo cifrado 
            int[] CodigoCifrado = new int[texto.Length];

            //Declara un string vacio donde almacenaremos el mensaje cifrado resultante
            string MensajeCifrado = "";


            //Declarar e inicializar el queue
            Queue ColaClaves = new Queue();

            //Cargar las claves en el queue
            for(int j = 0; j < ArregloClaves.Length; j++)
            {
                ColaClaves.Enqueue(ArregloClaves[j]);
            }
            

            //CIFRADO
            //Para cada caracter del texto
            for(int i = 0; i < texto.Length; i++)
            {
   
                //Encolar clave, ej para la cola 3,5,6 queda 3,5,6,3
                ColaClaves.Enqueue(ColaClaves.Peek());

                //Calcular la clave numerica cifrada para este caracter, 
                //consiguiendo su valor por hashtable y sumandole el desplazamiento segun la clave desencolada               
                int numCifrado = (int)tablaCifrado[texto[i]] + int.Parse((string)ColaClaves.Dequeue());    


                //Guardar cada num cifrado para conservar el codigo cifrado generado
                CodigoCifrado[i] = numCifrado;

                //Concatenar el char correspondiente, con el num calculado en numCifrado, en el hashtable de descifrado
                //SI EL RESULTADO ES MAYOR A 28 CALCULAR (RESULTADO MOD 28) ESTE RESTO ES EL CODIGO EFECTIVO
                MensajeCifrado += numCifrado <= 28 ? tablaDescifrado[numCifrado] : tablaDescifrado[numCifrado % 28]; 

            }
            
        
            Console.WriteLine($"Mensaje cifrado: {MensajeCifrado}");


            //Reestablecer el estado del Queue, borrando y volviendo a cargar las claves
            ColaClaves.Clear();

            for(int j = 0; j < ArregloClaves.Length; j++)
            {
                ColaClaves.Enqueue(ArregloClaves[j]);
            }


            string MensajeDescifrado = "";

            //DESCIFRADO
            //Para cada caracter del texto
            for(int i = 0; i < texto.Length; i++)
            {
   
                //Encolar la primer clave, ej para la cola 3,5,6 queda 3,5,6,3
                ColaClaves.Enqueue(ColaClaves.Peek());

                //Calcular la clave descifrada, restando la clave al numero cifrado anteriormente                
                int numDescifrado = CodigoCifrado[i] - int.Parse((string)ColaClaves.Dequeue());// - (int)tablaCifrado[texto[i]];    

                //Concatenar el caracter correspondiente al numero descifrado 
                MensajeDescifrado += tablaDescifrado[numDescifrado]; 
            
            
            }
            
            Console.WriteLine($"Mensaje descifrado: {MensajeDescifrado}");



        }
    }
}
