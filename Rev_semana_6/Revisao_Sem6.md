##

Revisão: bolha, seleção, inserção, agitação, pente, shell  
### O que é ordenação e por que é importante ordenar estruturas de dados:  
    Ordenação: Colocar dados/valores/recursos em ordem seguindo um conjunto de regras;  
        - Com a ordenação de estruturas de dados é possivel a realização de pesquisa/análise, operações e funções de forma mais eficientes e rápidas.

### Explique o que é estabilidade e complexidade. Se necessário, dar exemplos. Quais os métodos estudados que são estáveis e quais que são instáveis  
    - Estabilidade: Refere-se à capacidade de um algoritmo manter a ordem relativa de elementos com chaves iguais;
    - Complexidade: Refere-se à uma medida de desempenho e eficiência de um algoritmo. Geralmente Big O;

    Algoritmos Estáveis: 
        * Bolha;
        * Inserção;
        * Agitação;

    Algoritmos Instáveis:
        * Seleção;
        * Pente
        * Shell

### Dos métodos estudados, quais suas complexidades? Como é avaliada a complexidade de um método de ordenação?
A Complexidade é avaliada com base no numero de operções que o algoritmo realiza por "entradas";
* [BubbleSort](https://sortvisualizer.com/bubblesort/) (Bolha) : Complexidade média de O(n²)  
* [SelectionSort](https://sortvisualizer.com/selectionsort/) (Seleção) : Complexidade média de O(n²)
* [InsertionSort](https://sortvisualizer.com/insertionsort/) (Inserção) : Complexidade média de O(n²)
* [ShakerSort](https://sortvisualizer.com/shakersort/) (Agitação) : Complexidade média de O(n²)
* [CombSort](https://sortvisualizer.com/combsort/) (Pente) : Complexidade Melhor caso: O(n * log n) | Pior Caso: O(n²)  
* [ShellSort](https://sortvisualizer.com/shellsort/) (Concha) : Complexidade Melhor caso: O(n * log n) | Pior caso: O(n²) --> Depende muito da sequencia de gaps


### Dos métodos estudados, qual o melhor método de ordenação?
- Depende: "Qual o tamanho da lista? Qual o nivel de ordenação dela? É necessário estabilidade na lista? Complexidade suportada?"

### Faça um método na sua linguagem de preferência que retorne true/True se a lista enviada como parâmetro está ordenada, o false/False caso contrário    
[EstaOrdenada](./Teste%201/Teste%201/Program.cs)

### Da a sequência de valores na estrutura abaixo, contabilize quantas comparações e quantas trocas há para os métodos:
        - bolha
        - pente
        - seleção

        0   1   2   3   4   5   6   7   8  
        30  90  10  20  80  10  20  40  10

    ```
        Tempo da rotina ordenar por bolha:  1.559999964229064e-05 s
        Comparacoes: 56
        Trocas: 20
        Tempo da rotina ordenar por pente:  1.5999999959603883e-05 s
        Comparacoes: 37
        Trocas: 8
        Tempo da rotina ordenar por selecao:  1.2000000424450263e-05 s
        Comparacoes: 36
        Trocas: 6
    ```

### Na sua linguagem de preferência, implemente (sem consulta) seu método escolhido para saber.  
    [CombSortProgram](./CombSort/CombSort/Program.cs)