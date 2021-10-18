using System;

namespace InterfacesG4_2022_I
{
    class Estufa:IApagar,IEncender
    {
        void IApagar.Apagar()
        {
            Console.WriteLine(" ***** Apagando Estufa **** ");
        }

        public void Encender()
        {
            Console.WriteLine(" Encendiendo quemador 1  ");
        }

        public Estufa()
        {
            Console.WriteLine(" Wirpool , Bienvenido " );
        }
    }
}
