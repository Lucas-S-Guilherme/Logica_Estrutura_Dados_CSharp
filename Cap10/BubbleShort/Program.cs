namespace BubbleShort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Número de vetores
            int numeroDeVetores = 1000;           

            // Criar uma instância da classe Random para gerar números aleatórios
            Random random = new Random();

            // Criar e preencher uma matriz com números aleatórios
            int[] matriz = new int[numeroDeVetores];
            for (int i = 0; i < numeroDeVetores; i++)
            {                         
                    matriz[i] = random.Next(1000); // Números aleatórios de 0 a 999                
            }

            // Exemplo: Exibindo os primeiros 50 elementos do primeiro vetor
            Console.WriteLine("Primeiros 50 elementos do vetor desordenado:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write(matriz[i] + " ");
            }

            // método para ordenar
            BolhaIterativaCrescente(matriz);
            
            
            // Exemplo: Exibindo os primeiros 50 elementos do primeiro vetor
            Console.WriteLine("\n\nPrimeiros 50 elementos do primeiro vetor ordenado:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write(matriz[i] + " ");
            }

            Console.ReadLine();

        }

        static int[] BolhaIterativaCrescente(int[] v)
        {
            int i, j, aux;
            for (j = v.Length - 1; j>= 1; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i+1] = aux;
                    }
                }
            }
            return v;
        }

    }
}