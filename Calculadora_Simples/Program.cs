namespace Calculadora_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo a Calculadora Simples!");
            ESCOLHA:
            Console.WriteLine("Digite o número referente à operação que deseja");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            string inputOperacao = Console.ReadLine();
            int operacao ;

            if (!int.TryParse(inputOperacao, out operacao))
            {
                Console.WriteLine("Entrada inválida! Digite um número referente à operação");
                goto ESCOLHA;
            }
            if (operacao < 1 || operacao > 5)
            {
                Console.WriteLine("Entrada inválida! Digite um número referente à operação");
                goto ESCOLHA;
            }
            if (operacao == 5)
            {
                Environment.Exit(0);
            }
            
            Console.WriteLine("Escolha o primeiro número");
            double primeiroNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número");
            double segundoNumero = double.Parse(Console.ReadLine());
            double resultado;

            switch (operacao)
            {
                case 1:
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine($"O resultado é {resultado}");
                    break;
                case 2:
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine($"O resultado é {resultado}");
                    break;
                case 3:
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine($"O resultado é {resultado}");
                    break;
                case 4:
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine($"O resultado é {resultado}");
                    break;
            }
            Console.WriteLine("Deseja continuar? \"s\" para sim ou pressione qualquer tecla para sair");
            string continuacao = Console.ReadLine();
            if (continuacao == "s")
            {
                goto ESCOLHA;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
