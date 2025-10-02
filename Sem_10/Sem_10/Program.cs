//Fazer um programa que:
//        - armazene milhoes de números inteiros ou pouco repetidos (desordenados)
//        - retorne o menor número gerado
//        - retorne o número
//        - temporize esse processamento
//        - contabilize o número de comparações

using System.Diagnostics;
using System.Collections.Generic;
using System;

// Classe principal para organizar o código
public class ProcessadorDeNumeros_Priority
{
    // Variável para contar as comparações
    private long comparacoesContador = 0;

    // Lista auxiliar para fins de comparação com algoritmos tradicionais,
    // se for necessário contabilizar comparações *durante a inserção*.
    // Para este caso, vamos focar na contagem de comparações na busca.
    private List<int> listaAuxiliar = new();

    // Estrutura para armazenar os números.
    // Usamos o próprio valor como prioridade, criando uma Min-Heap.
    private PriorityQueue<int, int> heapDeNumeros = new();

    public void ExecutarProcessamento()
    {
        int totalDeNumeros = 5_000_000; // Por exemplo, 5 milhões

        // Geração de números aleatórios (ou quaisquer outros números)
        Random random = new Random();

        // 1. Inicia o cronômetro para medir o tempo de inserção
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // --- INSERÇÃO DOS DADOS ---
        for (int i = 0; i < totalDeNumeros; i++)
        {
            int numero = random.Next(); // Gera um número inteiro aleatório

            // Adiciona na PriorityQueue (tempo logarítmico: O(log n))
            heapDeNumeros.Enqueue(numero, numero);

            // Adiciona na Lista (tempo constante: O(1))
            listaAuxiliar.Add(numero);

            // NOTA: A contagem de comparações durante a inserção no Heap é complexa
            // e interna. É mais prático contar comparações em operações de busca/ordenação.
        }

        stopwatch.Stop();
        Console.WriteLine($"Tempo de Inserção de {totalDeNumeros} números: {stopwatch.ElapsedMilliseconds} ms");

        // --- BUSCA DO MENOR NÚMERO ---
        // 2. Reinicia o cronômetro para medir a busca
        stopwatch.Restart();

        int menorNumeroHeap = EncontrarMenorNumero_Heap();

        stopwatch.Stop();
        Console.WriteLine("\n--- Processamento com PriorityQueue (Min-Heap) ---");
        Console.WriteLine($"O menor número gerado (Heap): {menorNumeroHeap}");
        Console.WriteLine($"Tempo para encontrar o menor: {stopwatch.ElapsedTicks} ticks (Quase instantâneo!)");
        Console.WriteLine($"Comparações para encontrar o menor: 0 (já está no topo)");

        // --- BUSCA NA LISTA (PARA COMPARAÇÃO) ---
        stopwatch.Restart();
        int menorNumeroLista = EncontrarMenorNumero_Lista(listaAuxiliar);
        stopwatch.Stop();

        Console.WriteLine("\n--- Processamento com List<int> (Comparação) ---");
        Console.WriteLine($"O menor número gerado (Lista): {menorNumeroLista}");
        Console.WriteLine($"Tempo para encontrar o menor: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Comparações para encontrar o menor: {comparacoesContador}");
    }

    /// <summary>
    /// Retorna o menor número da PriorityQueue.
    /// Tempo: O(1)
    /// </summary>
    public int EncontrarMenorNumero_Heap()
    {
        // O Peek() obtém o elemento de maior prioridade (o menor) sem removê-lo.
        // É uma operação O(1) - não requer comparações.
        return heapDeNumeros.Peek();
    }

    /// <summary>
    /// Retorna o menor número da List<int> através de varredura.
    /// Tempo: O(n)
    /// </summary>
    public int EncontrarMenorNumero_Lista(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            throw new InvalidOperationException("A lista está vazia.");
        }

        int menor = numeros[0];
        comparacoesContador = 0;

        // Varre a lista inteira para encontrar o menor.
        for (int i = 1; i < numeros.Count; i++)
        {
            comparacoesContador++; // Contabiliza a comparação
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        return menor;
    }
}

public class ProcessadorDeNumeros
{
    // Variável para contar as comparações
    private long comparacoesContador = 0;

    // A única estrutura de dados para armazenar os números.
    private List<int> listaDeNumeros = new();

    public void ExecutarProcessamento()
    {
        int totalDeNumeros = 5_000_000; // Por exemplo, 5 milhões

        // Geração de números aleatórios
        Random random = new Random();

        // 1. Inicia o cronômetro para medir o tempo de inserção
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // --- INSERÇÃO DOS DADOS ---
        // Tempo de Inserção: O(1) médio para List<int>
        for (int i = 0; i < totalDeNumeros; i++)
        {
            int numero = random.Next(); // Gera um número inteiro aleatório
            listaDeNumeros.Add(numero);
        }

        stopwatch.Stop();
        Console.WriteLine($"Tempo de Inserção de {totalDeNumeros} números: {stopwatch.ElapsedMilliseconds} ms");

        // --- BUSCA DO MENOR NÚMERO ---
        // 2. Reinicia o cronômetro para medir a busca
        stopwatch.Restart();

        int menorNumero = EncontrarMenorNumero_Lista(listaDeNumeros);

        stopwatch.Stop();

        Console.WriteLine("\n--- Processamento com List<int> (Varredura Linear) ---");
        Console.WriteLine($"O menor número gerado (Lista): {menorNumero}");
        // O tempo aqui será significativamente maior do que com o Heap
        Console.WriteLine($"Tempo para encontrar o menor: {stopwatch.ElapsedMilliseconds} ms");
        // A contagem de comparações será próxima a N-1
        Console.WriteLine($"Comparações para encontrar o menor: {comparacoesContador}");
    }

    /// <summary>
    /// Retorna o menor número da List<int> através de varredura (busca linear).
    /// Complexidade de Tempo: O(n)
    /// </summary>
    public int EncontrarMenorNumero_Lista(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            throw new InvalidOperationException("A lista está vazia.");
        }

        int menor = numeros[0];
        // Reseta o contador para medir apenas a operação de busca
        comparacoesContador = 0;

        // Varre a lista inteira a partir do segundo elemento (índice 1).
        // Isso requer N-1 comparações no total.
        for (int i = 1; i < numeros.Count; i++)
        {
            comparacoesContador++; // Contabiliza a comparação de cada item
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        return menor;
    }
}
public class InsertInHeap
{
    // Aumentei o escopo da variável para evitar um erro de compilação comum no .NET Core/5+
    // Mudei o nome da classe para seguir as convenções de C# (PascalCase)
    private const int TotalDeNumeros = 100_000_000;

    private PriorityQueue<int, int> heapDeNumeros = new();

    // Geração de números aleatórios
    // É uma boa prática inicializar o Random uma única vez
    private Random random = new Random();

    public void Exec()
    {
        Console.WriteLine($"Iniciando geração e inserção de {TotalDeNumeros:N0} números...");

        // 1. Inicia o cronômetro
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // --- INSERÇÃO DOS DADOS ---
        for (int i = 0; i < TotalDeNumeros; i++)
        {
            int numero = random.Next();

            // Adiciona na PriorityQueue: O(log n) por inserção
            // Usando o número como elemento e também como prioridade (Min-Heap)
            heapDeNumeros.Enqueue(numero, numero);
        }

        stopwatch.Stop();
        Console.WriteLine($"Tempo de Inserção total (O(N log N)): {stopwatch.ElapsedMilliseconds:N0} ms");
        Console.WriteLine($"Memória usada (aprox.): {GC.GetTotalMemory(false) / 1024 / 1024:N0} MB");

        // --- BUSCA DO MENOR NÚMERO ---
        // O(1) de complexidade, quase instantâneo.
        stopwatch.Restart();
        int menorNumeroHeap = EncontrarMenorNumero_Heap();
        stopwatch.Stop();

        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"O menor número gerado (Peek): {menorNumeroHeap}");
        Console.WriteLine($"Tempo para encontrar o menor (O(1)): {stopwatch.ElapsedTicks} ticks");
        Console.WriteLine($"Comparações para encontrar o menor: 0");
    }

    // Método para acessar o menor elemento
    public int EncontrarMenorNumero_Heap()
    {
        // Se a fila estiver vazia, Peek() lançaria uma exceção, então verificamos
        if (heapDeNumeros.Count == 0)
        {
            throw new InvalidOperationException("O heap está vazio.");
        }
        return heapDeNumeros.Peek();
    }
}

public class Program
{
    // O ponto de entrada estático exigido pelo C#
    public static void Main(string[] args)
    {
        // Cria uma instância da classe que contém a lógica do processamento
        ProcessadorDeNumeros_Priority processador_priority = new ProcessadorDeNumeros_Priority();

        // Inicia o processamento
        processador_priority.ExecutarProcessamento();

        Console.WriteLine("\n\n");

        ProcessadorDeNumeros processador = new ProcessadorDeNumeros();
        processador.ExecutarProcessamento();

        Console.WriteLine("\n\n");

        InsertInHeap inse = new InsertInHeap();
        inse.Exec();

    }
}
