using System;

namespace ej2
{
    class SecuenciasDeEscape
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daaaaaaaaamn\n!");       //Siguiente linea
            
            Console.WriteLine("Daaaaaaaaamn\b!");       //Retroceso (El caracter retrocede pisando al anterior)
            Console.WriteLine("Daaaaaaaaamn\t!");       //Tabulacion

            Console.WriteLine("Daaaaaaaamn\r!");       //Retorno de carro 
            Console.WriteLine("Daaaaaaaamn\v!");       //Tabulacion vertical
  

            Console.WriteLine("Daaaa\\aaaaamn!");       //La doble barra invertida imprime una barra invertida, evitando que se confunda con otras secuencias de escape
            Console.WriteLine("Daaaaa\"aaaamn!");       //Permite imprimir el caracter de comilla evitando que se confunda con el cierre de la cadena de texto

        }
    }
}
