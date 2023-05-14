using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Exercicios.ValidadorDeCpf
{
    internal class Validador
    {

        public static bool validar(string Cpf)
        {

            int numerosSomados = 0;
            int peso = 10;
            int soma = 0;
            int primeiroDigitoVerificador = Convert.ToInt32(Convert.ToString(Cpf[9])), segundoDigitoVerificador = Convert.ToInt32(Convert.ToString(Cpf[10]));
            int primeiroDigito, segundoDigito;

            for (int i = 0; i < Cpf.Length && numerosSomados < 9; i++)
            {

                if (char.IsDigit(Cpf[i]))
                {
                    soma += Convert.ToInt32(Convert.ToString(Cpf[i])) * peso--;
                    numerosSomados++;
                }

            }

            primeiroDigito = 11 - (soma % 11);

            if (primeiroDigito > 10)
            {
                primeiroDigito = 0;
            }

            if (primeiroDigitoVerificador != primeiroDigito)
            {
                return false;
            }

            numerosSomados = 0;
            peso = 11;
            soma = 0;
            for (int i = 0; i < Cpf.Length && numerosSomados < 10; i++)
            {

                if (char.IsDigit(Cpf[i]))
                {
                    soma += Convert.ToInt32(Convert.ToString(Cpf[i])) * peso--;
                    numerosSomados++;
                }

            }

            segundoDigito = 11 - (soma % 11);

            if (segundoDigito > 10)
            {
                segundoDigito = 0;
            }

            if (segundoDigitoVerificador != segundoDigito)
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
