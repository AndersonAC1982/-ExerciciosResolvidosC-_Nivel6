using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio63
{
    using System;

    class Program
    {
        // Método para verificar se o número é PAR ou ÍMPAR
        public static string VERIFICA(int n)
        {
            // Verifica se o número é par ou ímpar
            if (n % 2 == 0)
            {
                return "PAR";  // Se o número for divisível por 2, é PAR
            }
            else
            {
                return "ÍMPAR";  // Se o número não for divisível por 2, é ÍMPAR
            }
        }

        static void Main(string[] args)
        {
            // Solicita ao usuário um número
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());  // Converte a entrada do usuário para inteiro

            // Chamando o método VERIFICA para determinar se o número é par ou ímpar
            string resultado = VERIFICA(numero);

            // Exibindo o resultado
            Console.WriteLine("O número " + numero + " é " + resultado);

            Console.ReadKey();
        }
    }
}
