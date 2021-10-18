using System;

namespace InterfacesG4_2022_I
{
    class Refrigerador : ElectroDomestico,IEncender,IApagar
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
            Marca = "Wirpool";
            Console.WriteLine(" {0}, te da la bienvenida para ocupar tu Refrigerador  ",Marca );
        }
    }
}
