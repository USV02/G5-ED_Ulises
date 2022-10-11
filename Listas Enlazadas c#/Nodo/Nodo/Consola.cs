using System;
using System.Collections.Generic;
using System.Text;

namespace Programación
{
    class Consola
    {
        public int option;
        Lista l = new Lista();

        public void showInstructions()
        {
           
            Console.Clear();
            Console.WriteLine("1 para ingrsar Nodo cabeza");
            Console.WriteLine("2 para ingresar Nodo cola");
            Console.WriteLine("3 para eliminar un nodo");
            Console.WriteLine("4 para eliminar TODOS los nodos");
            Console.WriteLine("5 para cerrar el programa");
            Console.WriteLine();
            Console.Write("Lista: ");
            l.showList();
            Console.WriteLine();
            option= int.Parse(Console.ReadLine());
        }

        public void toList()
        {
            switch (option)
            {
                case 1:
                    //INCERTA UN NODO TIPO CABEZA
                    l.insertHead();
                    break;

                case 2:
                    //INCERTA UN NODO TIPO COLA
                    l.insertTail();
                    break;

                case 3:
                    //ELIMINA UN NODO EN ESPECIFICO
                    //Para eliminar un nodo, el usuario debe mandar el dato del nodo que desea eliminar
                    Console.WriteLine("Escribe el numero de la lista que desea eliminar:  ");
                    int dataToRemove= int.Parse(Console.ReadLine());
                    l.removeNode(dataToRemove);
                    break;

                case 4:
                    //ELIMINA TODOS LOS NODOS
                    l.removeAll();
                    break;

                case 5:
                    //CIERRA EL PROGRAMA
                    Console.WriteLine("Cerrando programa...");
                    Console.ReadLine();
                    break;
                default:
                    //OPCION ERRONEA
                    Console.WriteLine("Esa opcion no existe...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
