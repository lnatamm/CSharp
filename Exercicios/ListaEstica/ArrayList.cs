using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Exercicios.ListaEstica
{
    internal class ArrayList<T>
    {

        private T[] array;

        private int count;

        public ArrayList()
        {

            array = new T[10];
            count = 0;

        }

        private void createEspace()
        {

            T[] aux = array;

            array = new T[array.Length + array.Length / 2];

            for(int i = 0; i < aux.Length; i++)
            {
                array[i] = aux[i];
            }

        }

        public void add(T data)
        {
            try
            {
                array[count] = data;
                count++;
            }
            catch(IndexOutOfRangeException e)
            {
                createEspace();
                add(data);
            }
        }

    }
}
