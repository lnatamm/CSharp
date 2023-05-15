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

        private Node<T> next { get; set; }

        public Node(T data)
        {
            this.data = data;
        }

    }
}
