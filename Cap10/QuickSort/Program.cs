namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 25, 57, 48, 37, 12, 92, 86, 33 };
            QuickSort(0, num.Length - 1, num); //chamada ao método
            mostrar(num);

            
        }

        static void QuickSort(int primeiro, int ultimo, int[] vetor)
        {
            int x;
            if (primeiro < ultimo) // verifica se primeiro é menor que o ultimo
            {
                x = Particao(primeiro, ultimo, vetor);
                QuickSort(primeiro, x - 1, vetor);
                QuickSort(x + 1, ultimo, vetor);
            }
        }

        static int Particao(int primeiro, int ultimo, int[] vetor)
        {
            int aux, pivo;
            int j = ultimo;            
            pivo = vetor[primeiro]; // o valor do primeiro vetor[0] é definido como pivô
            for (int i = ultimo; i >= primeiro; i--) // são usados os índices do vetor
            {
                // a partir do primeiro if com resultado false, é que as posições começam a serem trocadas, pois i e j, deixam de serem o mesmo índice.
                                
                if (vetor[i] >= pivo) 
                {
                    aux = vetor[j]; // faz a troca dos valores dos indices. Enquanto não houver uma verificação de if com resultado false, esse algoritmo basicamente não troca nada de lugar.
                    vetor[j] = vetor[i];
                    vetor[i] = aux;
                    j--; 
                }
            }
            return j + 1;
        }

        static void mostrar(int[] v)
        {
            string vetor = "";
            for (int i = 0; i < v.Length; i++)
            {
                vetor = vetor + v[i] + ", ";
            }
            Console.WriteLine(vetor);

        }
    }
}