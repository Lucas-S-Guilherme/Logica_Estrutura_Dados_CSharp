namespace MergeSort
{
    internal class Program // foi adicionada várias linhas de método de impressão, para melhor entender a execução do algoritmo
    {
        static void Main(string[] args)
        {
            int[] num = { 25, 57, 48, 37, 12, 92, 86, 33 };
            int recursao = 0; //variável para "enxergar" quantas recursões são feitas

            MostrarVetor(num);
            MergeSort(num, 0, num.Length - 1, ref recursao);
            MostrarVetor(num);           

        }

        static void MergeSort(int[] vetor, int inicio, int fim, ref int recursao) // adicionado recursao para visualizar laço
        {
            if (inicio == fim) // condição de saída
            {
                return;
            }
                       
            int meio = (inicio + fim) / 2;
            recursao++;

            Console.WriteLine($"\n#################  {recursao}ª RECURSAO #################");

            Console.WriteLine("Feita Recursão 1º subconjunto"); // acrescentado para acompanhar recursões
            MergeSort(vetor, inicio, meio, ref recursao);// utiliza meio como fim - subconjunto à esquerda do meio
            Console.WriteLine($"Inicio do 1º subconjunto: {inicio}" +
                $"\n Fim do 1º subconjunto {fim} ");

            Console.WriteLine("Feita Recursão 2º subconjunto");
            MergeSort(vetor, meio + 1, fim, ref recursao); // utiliza meio +1 como inicio - subconjunto à direita do meio
            Console.WriteLine($"Inicio do 2º subconjunto: {inicio}" +
                $"\n Fim do 2º subconjunto {fim} ");

            Console.WriteLine("Rodado Merge");
            Merge(vetor, inicio, meio, fim);

            Console.WriteLine("---Executado MergeSort até o fim--- \n");

        }

        public static void Merge(int[] vetor, int inicio, int meio, int fim)
        {
            int n = fim - inicio + 1; // calcula tamanho do vetor
            int[] b = new int[n]; //vetor auxiliar, armazena valores ordenados
            int i1 = inicio; // auxilia no controle dos laços
            int i2 = meio + 1; // auxilia no controle dos laços
            int j = 0; // variável utilizada para controlar as posições do vetor b

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

            Console.WriteLine("Fim algoritmo MERGE");

        }

        static void MostrarVetor(int[] v)
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