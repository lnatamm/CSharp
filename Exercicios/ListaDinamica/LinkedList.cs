using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Exercicios.ListaDinamica
{
    internal class LinkedList<T>
    {

        private Node<T> head;
        private Node<T> tail;
        private int count;
        public LinkedList() 
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

    }
}
