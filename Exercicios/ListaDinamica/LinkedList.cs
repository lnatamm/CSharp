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

        public void Add(T data)
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

        public void Add(int i,  T data)
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

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> aux = head;
            for(int i = 0; i < count; i++)
            {
                if (aux.getData().Equals(data))
                {
                    return true;
                }
                aux = aux.getNext();
            }
            return false;
        }

        public void Remove(T n)
        {
            Node<T> aux = head;
            if (head.getData().Equals(n))
            {
                head = head.getNext();
                if (head == null)
                {
                    tail = null;
                }
            }

            else if (tail.getData().Equals(n))
            {
                while (aux.getNext() != tail)
                {
                    aux = aux.getNext();
                }
                aux.setNext(null);
                tail = aux;
            }

            else
            {
                while (!aux.getNext().getData().Equals(n))
                {
                    aux = aux.getNext();
                }
                aux.setNext(aux.getNext().getNext());
            }
            count--;
        }

        public void Remove(int i)
        {
            Node<T> aux = head;
            if (i == 0)
            { 
                if (head == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    head = head.getNext();
                    if (head == null)
                    {
                        tail = null;
                    }
                }
            }
            else if (i == count - 1)
            {
                while (aux.getNext() != tail)
                {
                    aux = aux.getNext();
                }
                tail = aux;
            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == (i - 1))
                    {
                        aux.setNext(aux.getNext().getNext());
                    }
                    aux = aux.getNext();
                }
            }
            count--;
        }

        public T Get(int i)
        {
            Node<T> aux = head;
            for (int j = 0; j < i; j++)
            {
                aux = aux.getNext();
            }
            return aux.getData();
        }

        public int IndexOf(T n)
        {
            Node<T> aux = head;
            int index = 0;
            while (aux != null)
            {
                if (aux.getData().Equals(n))
                {
                    return index;
                }
                aux = aux.getNext();
                index++;
            }
            return -1;
        }

        
        public override string ToString()
        {
            Node<T> aux = head;
            string s = "[";
            while (aux.getNext() != null)
            {
                s += aux.getData() + ", ";
                aux = aux.getNext();
            }
            s += aux.getNext().getData();
            return $"{s}]";
        }

    }
}
