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

        public bool IsEmpty()
        {
            return head == null;
        }

        public void add(T data)
        {
            Node<T> node = new Node<T>(data);
            if(head == null)
            {
                head = node;
                tail = node;
                count++;
            }
            else
            {
                tail.setNext(node);
                tail = node;
                count++;
            }
        }

        public void add(int i,  T data)
        {

            Node<T> node = new Node<T>(data);
            Node<T> aux = head;

            if (i == 0)
            {
                if(head == null)
                {
                    head = node;
                    tail = node;
                    count++;
                }
                else
                {
                    tail.setNext(node);
                    tail = node;
                }
            }

            else if(i == count)
            {
                tail.setNext(node);
                tail = node;
            }

            else
            {
                if(i > count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    for(int j = 0; j < i - 1; j++)
                    {
                        aux = aux.getNext();
                    }
                    try
                    {
                        node.setNext(aux.getNext());
                        aux.setNext(node);
                        count++;
                    }
                    catch
                    {

                    }
                }
            }

        }

    }
}
