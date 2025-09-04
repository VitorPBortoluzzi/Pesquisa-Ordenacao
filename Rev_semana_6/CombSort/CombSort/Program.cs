using System;

namespace CombSort
{
    internal class Program
    {
        public static void combSort(int[] lista)
        {
            bool houveTroca = true;
            int distancia = lista.Length;

            while (houveTroca || distancia > 1)
            {
                distancia = (int)(distancia / 1.3);
                if (distancia < 1)
                    distancia = 1;

                houveTroca = false;

                for (int i = 0; i < lista.Length - distancia; i++)
                {
                    if (lista[i] > lista[i + distancia])
                    {
                        int tmp = lista[i];
                        lista[i] = lista[i + distancia];
                        lista[i + distancia] = tmp;
                        houveTroca = true;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] lista_teste_pente = { 30, 90, 10, 20, 80, 10, 20, 40, 10 };
            combSort(lista_teste_pente);
            Console.WriteLine(string.Join(", ", lista_teste_pente));
        }
    }
}
