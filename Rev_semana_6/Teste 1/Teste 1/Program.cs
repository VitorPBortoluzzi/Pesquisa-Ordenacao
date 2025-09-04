namespace Teste_1
{
    internal class Program
    {
        public static bool EstaOrdenadaCresc(int[] lista)
        {
            for (int i = 0; i < lista.Length - 1; i++)
            {
                if (lista[i] > lista[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool EstaOrdenadaDecr(int[] lista)
        {
            for (int i = 0; i < lista.Length - 1; i++)
            {
                if (lista[i] < lista[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] lista1 = { 1, 2, 3, 4, 5 };
            int[] lista2 = { 5, 4, 3, 2, 1 };

            Console.WriteLine(EstaOrdenadaCresc(lista1)); // True
            Console.WriteLine(EstaOrdenadaCresc(lista2)); // False
            Console.WriteLine(EstaOrdenadaDecr(lista1)); // True
            Console.WriteLine(EstaOrdenadaDecr(lista2)); // False
        }
    }
}
