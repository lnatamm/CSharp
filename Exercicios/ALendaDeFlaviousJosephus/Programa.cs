using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Exercicios.ALendaDeFlaviousJosephus
{
    internal class Programa
    {

        public static int f(int n, int m)
        {

            if(n == 1)
            {
                return 0;
            }

            else if(n >= 2)
            {
                return (f(n - 1, m) + m) % n;
            }

            return -1;

        }

        public static int josephus(int n, int m)
        {

            return f(n, m) + 1;

        }

        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Case {i + 1}: {josephus(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");
            }

        }
    }
}
