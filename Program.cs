using System;

namespace InterfacesG4_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Estufa miEstufa = new Estufa();
            miEstufa.Encender();
            IApagar apagar = miEstufa;
            apagar.Apagar();


            Refrigerador miRefri = new Refrigerador();
            //La interfaz IEncender  está de forma explícita
            IEncender encender = miRefri;
            encender.Encender();
            //La interfaz IApagar está de forma implícita
            miRefri.Apagar();


            Console.ReadLine();

        }
    }
}
