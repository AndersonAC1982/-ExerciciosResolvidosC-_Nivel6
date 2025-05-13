using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio64
{


    using System;

    class Program
    {
        static int[] vetor;

        // Método para carregar o vetor com os valores inseridos pelo usuário
        public static void CarregarVetor()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            vetor = new int[tamanho];

            Console.WriteLine("Digite os valores para o vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        // Método para listar os valores do vetor
        public static void ListarVetor()
        {
            Console.WriteLine("Conteúdo do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }

        // Método para exibir apenas os números pares do vetor
        public static void ExibirPares()
        {
            Console.WriteLine("Números pares no vetor:");
            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    Console.Write(numero + " ");
                }
            }
            Console.WriteLine();
        }

        // Método para exibir apenas os números ímpares do vetor
        public static void ExibirImpares()
        {
            Console.WriteLine("Números ímpares no vetor:");
            foreach (int numero in vetor)
            {
                if (numero % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
            }
            Console.WriteLine();
        }

        // Método para contar os números pares nas posições ímpares (1, 3, 5,...)
        public static void ContarParesPosicoesImpares()
        {
            int contador = 0;
            for (int i = 1; i < vetor.Length; i += 2) // Posições ímpares (1, 3, 5,...)
            {
                if (vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
        }

        // Método para contar os números ímpares nas posições pares (0, 2, 4,...)
        public static void ContarImparesPosicoesPares()
        {
            int contador = 0;
            for (int i = 0; i < vetor.Length; i += 2) // Posições pares (0, 2, 4,...)
            {
                if (vetor[i] % 2 != 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                // Menu com as opções
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares");
                Console.WriteLine("7 - Limpar Tela");
                Console.WriteLine("8 - Sair");

                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                // Executando a ação conforme a opção escolhida
                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirPares();
                        break;
                    case 4:
                        ExibirImpares();
                        break;
                    case 5:
                        ContarParesPosicoesImpares();
                        break;
                    case 6:
                        ContarImparesPosicoesPares();
                        break;
                    case 7:
                        Console.Clear(); // Limpa a tela
                        break;
                    case 8:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                // Aguardar o usuário pressionar uma tecla para continuar (exceto se escolher a opção de sair)
                if (opcao != 8)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 8); // O programa continuará até a opção 8 ser escolhida.

            Console.ReadKey();
        }
    }

}
