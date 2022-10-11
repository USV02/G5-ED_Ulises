using System;
using Programación;

namespace Lista_Enlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola c = new Consola();
            while (c.option!=5)
            {
                //MOSTRAR TEXTO EN LA CONSOLA
                c.showInstructions();
                //EJECUTAR LA ORDEN DADA
                c.toList();
            }
        }
    }
}
