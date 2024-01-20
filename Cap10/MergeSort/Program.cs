namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }

        static void MergeSort(int[] vetor, int inicio, int fim)
        {
            if (inicio == fim)
            {
                return;
            }

            int meio = (inicio + fim) / 2;
            MergeSort(vetor, inicio, meio);
            MergeSort(vetor, meio + 1, fim);
            Merge(vetor, inicio, meio, fim);

        }

        public static void Merge(int[] vetor, int inicio, int meio, int fim)
        {
            int n = fim - inicio + 1;
            int[] b = new int[n];
            int i1 = inicio;
            int i2 = meio + 1;
            int j = 0;

            while(i1 <= meio && i2 <= fim)
            {
                if (vetor[i1] < vetor[i2])
                {
                    b[j] = vetor[i1];
                    i1++;
                }
                else
                {
                    b[j] = vetor[i2];
                    i2++;
                }
                j++;
            }

            while(i1 <= meio)
            {
                b[j] = vetor[i1];
                i1 = i1 + 1;
                j++;
            }

            while (i2 <= fim)
            {
                b[j] = vetor[i2];
                i2 = i2 + 1;
                j++;
            }

            for (j = 0; j < n; j++)
            {
                vetor[inicio +j] = b[j];
            }

        }

        static void MostrarVetor(int[] v)
        {
            string vetor = "";
            for (int i = 0; i < v.Length; i++)
            {
                vetor = vetor + v[i] + ", ";
                Console.WriteLine(vetor);
            }
        }

    }
}