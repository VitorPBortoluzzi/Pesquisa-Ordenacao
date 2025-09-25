class Ordenacao:
    @staticmethod
    def bolha(lista):
        houve_troca = True
        qtd_comparacoes = 0
        qtd_trocas = 0
        while (houve_troca):    
            houve_troca = False
            for i in range (len(lista) - 1):
                qtd_comparacoes+=1
                if (lista[i] > lista[i+1]):
                    qtd_trocas+=1
                    houve_troca = True
                    tmp = lista[i]
                    lista[i] = lista[i+1]
                    lista[i+1] = tmp
                    
        return qtd_comparacoes, qtd_trocas #medem a complexidade do algoritmo
    
    @staticmethod
    def selecao(lista):
        qtd_comparacoes = 0
        qtd_trocas = 0
        for i in range(len(lista) - 1):
            posMenor = i
            for j in range(i+1, len(lista)):
                qtd_comparacoes+=1
                if (lista[j] < lista[posMenor]):
                    posMenor = j
            if (i != posMenor):
                qtd_trocas+=1
                tmp = lista[i]
                lista[i] = lista[posMenor]
                lista[posMenor] = tmp
                
        return qtd_comparacoes, qtd_trocas
    
    
    @staticmethod
    def insercao(lista):
        qtd_comparacoes = 0
        qtd_trocas = 0

        for i in range(1, len(lista)):
            tmp = lista[i]
            for j in range(i - 1, -2, -1):
                qtd_comparacoes+=1
                if (tmp < lista[j]):
                    lista[j + 1] = lista[j]
                    qtd_trocas+=1
                else:
                    break

            lista[j + 1] = tmp
            qtd_trocas+=1
            
        return qtd_comparacoes, qtd_trocas
    
    @staticmethod
    def agitacao(lista):
        houveTroca = True
        a = len(lista)
        ini = 0
        fim = a-1
        qtd_comparacoes = 0
        qtd_trocas = 0
        
        while(houveTroca == True):
            houveTroca = False
            
            for i in range(ini,fim):
                qtd_comparacoes+=1
                if(lista[i] > lista[i+1]):
                    qtd_trocas+=1
                    tmp = lista[i]
                    lista[i] = lista[i+1]
                    lista[i+1] = tmp
                    houveTroca = True

            if(houveTroca == False):
                break
            
            houveTroca = False
            fim -=1
            
            for i in range(fim, ini ,-1):
                qtd_comparacoes+=1
                if (lista[i] < lista[i - 1]):
                    qtd_trocas+=1
                    tmp = lista[i]
                    lista[i] = lista[i-1]
                    lista[i-1] = tmp
                    houveTroca = True
        ini +=1
        return qtd_comparacoes, qtd_trocas
    
    @staticmethod
    def pente(lista):
        houve_troca = True
        distancia = len(lista)
        qtd_comparacoes = 0 
        qtd_trocas = 0
        
        while (houve_troca or distancia > 1):    
            distancia = int(distancia /1.3)
            if (distancia < 1):
                distancia = 1
            houve_troca = False
            for i in range (len(lista) - distancia):
                qtd_comparacoes+=1
                if (lista[i] > lista[i+distancia]):
                    qtd_trocas+=1
                    houve_troca = True
                    tmp = lista[i]
                    lista[i] = lista[i+distancia]
                    lista[i+distancia] = tmp
                    
        return qtd_comparacoes, qtd_trocas
    
#     @staticmethod
#     def shell(lista):
#         n = len(lista)
#         qtd_comparacoes = 0 
#         qtd_trocas = 0
        
#         referenciaTamanho = 3
        
#         while(distancia > 1):
#             distancia = int(distancia / referenciaTamanho)
            
#             for i in range (distancia,n):
#                 tmp = lista[i]
                
                
    
    
#     void shell(Lista<> lista) {
#     int i, j;
#     int tmp;
#     int qtdComparacoes = 0, qtdTrocas = 0;
#     int distancia = 1;

#     int referenciaTamanho = 3;

#     do {
#         distancia = referenciaTamanho * distancia + 1;
#     } while (distancia < n);
    

#     do {
#         distancia = (int)distancia / referenciaTamanho;
        
#         for (i = distancia; i < n; i++) {
#             tmp = vetor[i];
#             for (j = i - distancia; j >= 0; j = j - distancia) {
#                 qtdComparacoes++;
#                 if (tmp < vetor[j]) {
#                     vetor[j + distancia] = vetor[j];
#                     qtdTrocas++;
#                 } else break;
#             }
#             vetor[j + distancia] = tmp;
#             qtdTrocas++;
#         }
#     } while (distancia > 1);
# }

    qtd_comparacoes = 0
    qtd_trocas = 0

    @staticmethod
    def particiona(lista, ini, fim):
    
        pivo = lista[ini]   # escolhe o primeiro elemento como pivô
        i = ini + 1
        j = fim

        while i <= j:
            # anda da esquerda para a direita até achar alguém maior que o pivô
            while i <= fim and lista[i] <= pivo:
                Ordenacao.qtd_comparacoes += 1
                i += 1

            # anda da direita para a esquerda até achar alguém menor que o pivô
            while j > ini and lista[j] > pivo:
                Ordenacao.qtd_comparacoes += 1
                j -= 1

            if i < j:
                Ordenacao.qtd_trocas += 1
                lista[i], lista[j] = lista[j], lista[i]

        # coloca o pivô na posição correta
        Ordenacao.qtd_trocas += 1
        lista[ini], lista[j] = lista[j], lista[ini]

        return j  # posição final do pivô

    @staticmethod
    def quicksort(lista, ini, fim):
        if ini < fim:
            pivo = Ordenacao.particiona(lista, ini, fim)
            Ordenacao.quicksort(lista, ini, pivo - 1)
            Ordenacao.quicksort(lista, pivo + 1, fim)