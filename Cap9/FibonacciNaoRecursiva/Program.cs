using System.Security.Cryptography.X509Certificates;

namespace FibonacciNaoRecursiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero;
            Console.WriteLine("Digite o n-ésimo elemento");
            numero = long.Parse(Console.ReadLine());
            Console.WriteLine($"O elemento da sequência é {fibonacciRecursiva(numero)}");


        }

        public static long fibonacciNaoRecursiva (long n)
        {
            long ultimo, i, penultimo, seguinte;
            ultimo = 1;
            penultimo = 0;
            i = 3;
            if (n == 1) return 0;
            if (n == 2) return 1;

            while (n >= i)
            {
                seguinte = ultimo + penultimo;
                penultimo = ultimo;
                ultimo = seguinte;
                i++;
            }
            return ultimo;
        }

        public static long fibonacciRecursiva (long n)
        {
            long num = 0;
            if (n==1) return 0;
            else if (n==2) return 1;
            else if (n>=3)
            {
                num = (fibonacciRecursiva(n - 1) + fibonacciRecursiva(n - 2));
            }
            return num;
        }



    }
}