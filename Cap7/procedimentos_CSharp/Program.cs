namespace procedimentos_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            Console.WriteLine("Digite a sua opção:" +
                "\n 1 - Adição" +
                "\n 2 - Subtração" +
                "\n 3 - Multiplicação" +
                "\n 4 - Divisão");

            // \n faz que hava uma quebra de linha

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: modAdicao();
                    break;
                case 2:
                    modSubtracao();
                    break;
                case 3:
                    modMultiplicacao();
                    break;
                case 4:
                    modDivisao();
                    break;
                default: Console.WriteLine("Digite um número das opções");
                    break;
            }

            static void modAdicao ()
            {
                double v1;
                double v2;
                double res;
                Console.WriteLine("Digite o primeiro valor");
                v1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                v2 = double.Parse(Console.ReadLine());
                res = v1 + v2;

                Console.WriteLine($"A soma dos dois valores é {res}");                
            }

            static void modSubtracao()
            {
                double v1;
                double v2;
                double res;
                Console.WriteLine("Digite o primeiro valor");
                v1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                v2 = double.Parse(Console.ReadLine());
                res = v1 - v2;

                Console.WriteLine($"A subtração dos dois valores é {res}");

            }

            static void modMultiplicacao()
            {
                double v1;
                double v2;
                double res;
                Console.WriteLine("Digite o primeiro valor");
                v1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                v2 = double.Parse(Console.ReadLine());
                res = v1 * v2;

                Console.WriteLine($"A multiplicacão dos dois valores é {res}");

            }

            static void modDivisao()
            {
                double v1;
                double v2;
                double res;
                Console.WriteLine("Digite o primeiro valor");
                v1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                v2 = double.Parse(Console.ReadLine());
                res = v1 / v2;

                Console.WriteLine($"A divisão dos dois valores é {res}");

            }
        }
    }
}