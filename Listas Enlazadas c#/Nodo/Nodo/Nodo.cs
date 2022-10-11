using System;
using System.Collections.Generic;
using System.Text;

namespace Programación
{
    class Nodo
    {
        private int data;
        private Nodo next;

        public int Dato
        {
            get { return data; }
            set { data = value; }
        }
        public Nodo Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
