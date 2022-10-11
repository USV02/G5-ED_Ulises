using System;
using System.Collections.Generic;
using System.Text;

namespace Programación
{
    class Lista
    {
        private Nodo head = new Nodo();
        private Nodo tail = new Nodo();

        public Lista()
        {
            head = null;
            tail = null;
        }

        //INSERTAR NODO CABEZA
        public void insertHead()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Ingrese el número que contendra el nuevo Nodo:  ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            //SI la lista esta vacia
            if (head==null)
            {
                //El nuevo nodo se vuelve la Cabeza y Cola de la lista, y el Next del nodo es Null debido a que solo existe un nodo
                head = Nuevo;
                head.Next = null;
                tail = Nuevo;
            }
            //SI la lista tiene mas de 1 nodo
            else
            {
                //El atributo Next del nodo nuevo es igual al actual nodo Cabeza
                Nuevo.Next = head;
                //Actualizamos la cabeza de la lista con el Nuevo Nodo
                head = Nuevo;
            }
            Console.WriteLine("Nodo Insertado");
        }

        //INSERTAR NODO CABEZA
        public void insertTail()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Ingrese el número que contendra el nuevo Nodo:  ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            //SI la lista esta vacia
            if (head==null)
            {
                //El nuevo nodo se vuelve la Cabeza y Cola de la lista, y el Next del nodo es Null debido a que solo existe un nodo
                head = Nuevo;
                head.Next = null;
                tail = Nuevo;
            }
            else
            {
                //El atributo Next del Nodo Cola Actual sera el Nuevo Nodo
                tail.Next = Nuevo;
                //Actualizamos la cola de la lista con el Nuevo Nodo
                tail = Nuevo;
            }

        }

        //ELIMINAR UN NODO EN ESPECIFICO
        public void removeNode(int nodeToRemove)
        {
            Nodo temporalNode = head;
            Nodo back = null;
            bool found = false;
            
            //SI el Nodo Cabeza no es igual a Null, quiere decir que existen nodos en la lista y por lo tanto podremos borrar un Nodo
            if (head!=null)
            {
                //MIENTRAS no se haya encontrado el Nodo que se desea borrar y nuestro Nodo Temporal no haya alcanzado el final de la lista
                while (temporalNode!=null && found!=true)
                {
                    //Comparamos SI el dato de nuestro Nodo Temporal es igual al dato del Nodo que envio el usuario
                    if (temporalNode.Dato==nodeToRemove)
                    {
                        //SI el Nodo a eliminar es la Cabeza de la lista
                        if (temporalNode == head)
                        {
                            //El nodo cabeza sera ahora el Nodo Next de la cabeza actual
                            head = head.Next;
                        }
                        //SI el Nodo a eliminar es la Cola de la lista
                        else if (temporalNode == tail)
                        {
                        //El Nodo Back elimina su Nodo Next y se convierte en el Nodo Cola
                            back.Next = null;
                            tail = back;
                        }
                        //SI el nodo se encuentra entre el Nodo Cabeza y el Nodo Cola
                        else
                        {
                        //Asignamos que el Nodo Next del Nodo Back sea igual al Nodo Next del Nodo Temporal
                            back.Next = temporalNode.Next;
                        }
                        Console.WriteLine("Nodo elminidado");
                        found = true;
                    }
                    //En el caso de que los datos del Nodo Temporal y el del usuario sean iguales, el Nodo Back se le asignan los atributos del
                    //Nodo temporal, y el Nodo Temporal se le asignan los atributos de su Next, asi logramos comparar todos los datos de los nodos
                    //con el dato que busca eliminar al usuario
                    back = temporalNode;
                    temporalNode = temporalNode.Next;
                }
            }
        }

        //ELIMINAR TODOS LOS NODOS
        public void removeAll()
        {
            while (head != null)
            {
                head = head.Next;
            }

        }

        //ESCRIBIR LA LISTA
        public void showList()
        {
            Nodo show = new Nodo();
            //Mostraremos la lista de la cabeza a la cola, por lo que primero debemos igualar el Nodo Show con el Nodo Cabeza
            show = head;
            //SI la lista NO esta vacia
            if (head!=null)
            {
                //MIENTRAS el Nodo Show sea diferente a Null
                while (show!=null)
                {
                    //Se escribe el dato del nodo asignado al Nodo Show, una vez mostrado su dato se iguala al siguiente nodo al Nodo Show
                    //a traves del atributo Next, asi sucesivamente hasta que finaliza con el Nodo Cola el cual su atributo Next es igual a Null
                    //por lo tanto finalizara la funcion MIENTRAS
                    Console.Write(show.Dato+"->");
                    show = show.Next;
                }
            }
            //SI la lista esta vacia
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
    }
}
