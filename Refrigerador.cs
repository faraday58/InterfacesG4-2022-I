using System;

namespace InterfacesG4_2022_I
{
    class Refrigerador : IEncender,IApagar
    {
        void IEncender.Encender()
        {
            Console.WriteLine(" Encendiendo la luz interna del refriferador  ");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando Refrigerador. \n Bye");
        }

        public Refrigerador()
        {
            Console.WriteLine(" Wirpool, te da la bienvenida para ocupar tu Refrigerador  ");
        }
    }
}
