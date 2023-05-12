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

    }
}
