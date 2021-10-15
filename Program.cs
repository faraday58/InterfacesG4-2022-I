using System;

namespace InterfacesG4_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Estufa miEstufa = new Estufa();
            IApagar apagar = miEstufa;
            apagar.Apagar();

            Console.ReadLine();


        }
    }
}
