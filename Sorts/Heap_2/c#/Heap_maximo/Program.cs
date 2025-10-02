using System.Reflection.Metadata.Ecma335;

public class Ordenacao
{
    public static bool EmHeapMaximo(List<int> lista)
    {
        int n = lista.Count;

        for (int i = 0; i < n / 2; i++) {
            int esq = 2 * i + 1;
            int dir = 2 * i + 2;

            if (esq < n && lista[i] < lista[esq])
            {
                return false;
            }
            if (dir < n && lista[i] < lista[dir])
            {
                return false;
            }

        }
        return true;
    } 

}

public class Program
{
    public static void Main()
    {
        // Heap Máximo válido
        List<int> heapMaximo = new List<int> { 10, 8, 9, 3, 5, 7 };
        Console.WriteLine($"É um Heap Máximo? {Ordenacao.EmHeapMaximo(heapMaximo)}"); // Saída: True

        // Não é Heap Máximo (10 < 12)
        List<int> naoHeap = new List<int> { 10, 8, 12, 3, 5, 7 };
        Console.WriteLine($"É um Heap Máximo? {Ordenacao.EmHeapMaximo(naoHeap)}"); // Saída: False
    }
}