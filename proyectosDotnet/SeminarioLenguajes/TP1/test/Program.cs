using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            Auto a = new Auto();

            a.Marca = "Nissan";
            a.Modelo = 2001;


            a.Imprimir();
        }


        class Auto
        {
            public string _marca;
            public int _modelo;

            public void Imprimir() =>  Console.WriteLine($"Auto {_marca} Modelo {_modelo} ");

            public Auto()
            {
                _marca = "Fiat";
                _modelo = DateTime.Now.Year;
            }

            public Auto(string Marca) : this()
            {
                _marca = Marca;
            }
        }
    }
}
