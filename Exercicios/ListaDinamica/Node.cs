using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Exercicios.ListaDinamica
{
    internal class Node<T>
    {

        private T data { get; set; }

        private Node<T> next;

        public Node(T data)
        {
            this.data = data;
            next = null;
        }

        public T getData()
        {
            return data;
        }

        public Node<T> getNext()
        {
            return next;
        }

        public void setData(T data)
        {
            this.data = data;
        }

        public void setNext(Node<T> next)
        {
            this.next = next;
        }

    }
}
