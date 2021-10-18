using System;

namespace InterfacesG4_2022_I
{
    abstract class ElectroDomestico
    {
        private string marca;

        public string Marca { get => marca; 
            set
            {
                if( value == "")
                {
                    marca = "Genérica";
                }
                else
                {
                    marca = value;
                }
                
            }
                
        }

        public ElectroDomestico()
        {
            Console.WriteLine("Gracias por adquirir nuestro producto ElectroDomestico");
        }
    }
}
