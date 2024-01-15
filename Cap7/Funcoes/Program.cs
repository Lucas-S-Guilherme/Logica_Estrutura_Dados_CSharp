using System.Threading.Channels;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0 ;           

            Console.WriteLine("Qual é o número?");

            numero = int.Parse(Console.ReadLine());     
            
            Console.WriteLine($"O fatorial de {numero} é {Fatorial(numero)}");
        }

        static int Fatorial (int numero)
        {
            int f = 1;

            for (int i = 1; i <= numero; i++)
            {
                f = f * i;                
            }

            return f;
            
        }

    }
}