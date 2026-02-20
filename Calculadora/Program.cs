using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("          CALCULADORA         ");
        Console.WriteLine("==============================");
        Console.WriteLine("Escolha uma opçao: ");
        Console.WriteLine();
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Potência");
        Console.WriteLine("6 - Raiz quadrada");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==============================");
        Console.Write("Digite a opção desejada: ");
        int N = int.Parse(Console.ReadLine());

        double N1, N2;

        switch (N)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Você escolheu: SOMA");
                Console.Write("Digite o primeiro número: ");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o segundo número: ");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                double soma = N1 + N2;
                Console.WriteLine("RESULTADO: " + soma);
                break;
            case 2:
                Console.WriteLine();
                Console.WriteLine("Você escolheu: SUBTRAÇÃO");
                Console.Write("Digite o primeiro número: ");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o segundo número: ");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                double subtracao = N1 - N2;
                Console.WriteLine("RESULTADO: " + subtracao);
                break;
            case 3:
                Console.WriteLine();
                Console.WriteLine("Você escolheu: MULTIPLICAÇÃO");
                Console.Write("Digite o primeiro número: ");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o segundo número: ");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                double multiplicacao = N1 * N2;
                Console.WriteLine("RESULTADO: " + multiplicacao);
                break;
            case 4:
                Console.WriteLine();
                Console.WriteLine("Você escolheu: DIVISÃO");
                Console.Write("Digite o primeiro número: ");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o segundo número: ");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                double divisao = N1 / N2;
                Console.WriteLine("RESULTADO: " + divisao);
                break;
            case 5:
                Console.WriteLine();
                Console.WriteLine("Você escolheu: Potenciação");
                Console.Write("Digite o número: ");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite a potência: ");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                double potencia = Math.Pow(N1, N2);
                Console.WriteLine("RESULTADO: " + potencia);
                break;
            case 6:
                Console.WriteLine();
                Console.WriteLine("Você escolheu: Raiz qudrada");
                Console.Write("Digite o número:");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double raiz = Math.Sqrt(N1);
                Console.WriteLine("RESULTADO: " + raiz);
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Cálculo Inválido!");
                break;
                
        };
    }
}
