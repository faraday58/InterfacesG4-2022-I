using System;

namespace InterfacesG4_2022_I
{
    class Estufa:IApagar
    {
        void IApagar.Apagar()
        {
            Console.WriteLine(" ***** Apagando Estufa **** ");
        }
        public Estufa()
        {
            Console.WriteLine(" Wirpool , Bienvenido " );
        }
    }
}
