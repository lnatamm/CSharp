using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Exercicios.ValidadorDeCpf
{
    internal class Validador
    {

        public static int calculaVerificador(int peso, List<int> cpf)
        {

            int soma = 0, j = 0;

            for(int i = peso; i > 1; i--)
            {
                soma += (cpf[j++] * i);
            }

            return (11 - (soma % 11) > 10) ? 0 : (11 - (soma % 11));

        }

        public static bool validar(string Cpf)
        {

            List<int> cpf = new List<int>();

            foreach(char i in Cpf)
            {
                if (char.IsDigit(i) && cpf.Count < 11)
                {
                    cpf.Add(Convert.ToInt32(char.ToString(i)));
                }
            }

            int verificador = calculaVerificador(10, cpf);

            if(verificador != cpf[9])
            {
                return false;
            }

            verificador = calculaVerificador(11, cpf);

            if(verificador != cpf[10])
            {
                return false;
            }

            return true;

        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(validar(Console.ReadLine()));
            }
        }


    }
}
