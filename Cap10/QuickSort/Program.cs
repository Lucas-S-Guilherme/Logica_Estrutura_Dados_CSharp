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
            if (primeiro < ultimo)
            {
                x = Particao(primeiro, ultimo, vetor);
                QuickSort(primeiro, x - 1, vetor);
                QuickSort(x + 1, ultimo, vetor);
            }
        }

        static int Particao(int primeiro, int ultimo, int[] vetor)
        {
            int j = ultimo;
            int aux, pivo;
            pivo = vetor[primeiro];
            for (int i = ultimo; i >= primeiro; i--)
            {
                if (vetor[i] >= pivo)
                {
                    aux = vetor[j];
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