using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio62
{
    class Program
    {
        // Método para calcular a hipotenusa
        public static double HIPOTENUSA(double baseTriangulo, double alturaTriangulo)
        {
            // Calculando a hipotenusa usando o teorema de Pitágoras
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            return hipotenusa;
        }

        // Método para calcular a área do triângulo
        public static double CalcularArea(double baseTriangulo, double alturaTriangulo)
        {
            // Calculando a área
            double area = (baseTriangulo * alturaTriangulo) / 2;
            return area;
        }

        static void Main(string[] args)
        {
            // Solicitando ao usuário o valor da base e altura do triângulo
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = Double.Parse(Console.ReadLine());  // Usando Double.Parse para obter um número decimal

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = Double.Parse(Console.ReadLine());  // Usando Double.Parse para obter um número decimal

            // Chamando o método HIPOTENUSA para calcular a hipotenusa
            double hipotenusa = HIPOTENUSA(baseTriangulo, alturaTriangulo);

            // Chamando o método CalcularArea para calcular a área
            double area = CalcularArea(baseTriangulo, alturaTriangulo);

            // Exibindo os resultados
            Console.WriteLine("A hipotenusa do triângulo é: " + hipotenusa.ToString("F2"));
            Console.WriteLine("A área do triângulo é: " + area.ToString("F2"));

            Console.ReadKey();
        }
    }
}
