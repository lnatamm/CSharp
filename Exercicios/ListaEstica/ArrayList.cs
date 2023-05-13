﻿using System;
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

        private void CreateEspace()
        {

            T[] aux = array;

            array = new T[array.Length + array.Length / 2];

            for(int i = 0; i < aux.Length; i++)
            {
                array[i] = aux[i];
            }

        }

        public void Add(T data)
        {
            try
            {
                array[count] = data;
                count++;
            }
            catch(IndexOutOfRangeException e)
            {
                CreateEspace();
                Add(data);
            }
        }

        public void Add(int pos, T data)
        {

            try
            {
                for(int i = count; i > pos; i--)
                {
                    array[i] = array[i - 1];
                }
                array[pos] = data;
                count++;
            }
            catch (IndexOutOfRangeException e) { 
                CreateEspace();
                Add(pos, data);
            }

        }

        
        public override string ToString()
        {
            String s = "[";

            for(int i = 0; i < count - 1; i++)
            {
                s += array[i] + ", ";
            }

            s += array[count - 1];

            return s + "]";
        }

    }
}
