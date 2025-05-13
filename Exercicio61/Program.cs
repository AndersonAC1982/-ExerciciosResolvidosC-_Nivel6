using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosNivel_6
{
    class Program
    {
        // Método para calcular o reajuste
        public static double REAJUSTE(double salario, double indiceReajuste)
        {
            // Calculando o novo salário após o reajuste
            double salarioAtualizado = salario + (salario * indiceReajuste / 100);
            return salarioAtualizado;
        }

        static void Main(string[] args)
        {
            // Solicitando ao usuário o valor do salário e o índice de reajuste
            Console.Write("Digite o valor do salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o índice de reajuste (em %): ");
            double indiceReajuste = Convert.ToDouble(Console.ReadLine());

            // Chamando o método REAJUSTE para calcular o novo salário
            double salarioAtualizado = REAJUSTE(salario, indiceReajuste);

            // Exibindo o resultado
            Console.WriteLine("O salário atualizado é: R$ " + salarioAtualizado.ToString("F2"));

            Console.ReadKey();
        }
    }
}
