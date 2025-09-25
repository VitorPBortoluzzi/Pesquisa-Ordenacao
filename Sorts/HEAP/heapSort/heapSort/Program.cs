namespace heapSort
{
    internal class Program
    {
        void heapify(int[] lista)
        {
            int n = lista.Length;
            int i = 0;

            int maior = (i - 1) / 2;
            int esquerda = i * 2 + 1;
            int direita = i * 2 + 2;

            if (esquerda < n && lista[esquerda] > lista[maior])
            {
                maior = esquerda;
            }

            if (direita < n && lista[direita] > lista[maior])
            {
                maior = direita;
            }

            if (maior != 1)
            {
                int temp = lista[i];
                lista[i] = lista[maior];
                lista[maior] = temp;

                heapify(lista);
            }
        }
        void heapsort(int[] lista)
        {
            int n = lista.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(lista);
                for (int i = n - 1; i >= 0; --i)
                swap(lista[0], lista[i]);
                heapify(lista);
        }

        static void Main(string[] args)
        {
        }
    }
}
