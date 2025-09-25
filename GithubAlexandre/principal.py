import time

from util import Util
from ordenacao import Ordenacao

lista_bolha = []
lista_normal = []
lista_selecao = []
lista_insercao = []
lista_agitacao = []
lista_pente = []

lista_teste_bolha = [30,90,10,20,80,10,20,40,10]
lista_teste_quicksort = [30,90,10,20,80,10,20,40,10]
lista_teste_pente = [30,90,10,20,80,10,20,40,10]


tempoInicio = time.perf_counter()
qtd_comparacoes, qtd_trocas = Ordenacao.bolha(lista_teste_bolha)
tempoFim = time.perf_counter()
tempo_bolha = tempoFim - tempoInicio
print("Tempo da rotina ordenar por bolha: ", tempo_bolha , "s")      
print('Comparacoes:', qtd_comparacoes)
print('Trocas:', qtd_trocas)  



tempoInicio = time.perf_counter()
qtd_comparacoes, qtd_trocas = Ordenacao.pente(lista_teste_pente)
tempoFim = time.perf_counter()
tempo_pente = tempoFim - tempoInicio
print("Tempo da rotina ordenar por pente: ", tempo_pente , "s")      
print('Comparacoes:', qtd_comparacoes)
print('Trocas:', qtd_trocas)  

qtd_comparacoes = 0
qtd_trocas = 0
tempo_inicio = time.perf_counter()
Ordenacao.quicksort(lista_teste_quicksort, 0, len(lista_teste_quicksort) - 1)
tempo_fim = time.perf_counter()
print("Tempo da rotina ordenar por quick: ", (tempo_fim - tempo_inicio) , "s")      
print('Comparacoes:', Ordenacao.qtd_comparacoes)
print('Trocas:', Ordenacao.qtd_trocas)



# tamanho = 10000

# Util.popular_lista_aleatoria(lista_bolha, tamanho, 10000, 20000)
# lista_normal.extend(lista_bolha)
# lista_selecao.extend(lista_bolha)
# lista_insercao.extend(lista_bolha)
# lista_agitacao.extend(lista_bolha)
# lista_pente.extend(lista_bolha)

# #sort
# tempoInicio = time.perf_counter()
# lista_normal.sort()
# tempoFim = time.perf_counter()
# tempo_sort = tempoFim - tempoInicio
# print("Tempo da rotina ordenar por sort nativo: ",  tempo_sort, "s")        

# #bolha
# tempoInicio = time.perf_counter()
# qtd_comparacoes, qtd_trocas = Ordenacao.bolha(lista_bolha)
# tempoFim = time.perf_counter()
# tempo_bolha = tempoFim - tempoInicio
# print("Tempo da rotina ordenar por bolha: ", tempo_bolha , "s")      
# print('Comparacoes:', qtd_comparacoes)
# print('Trocas:', qtd_trocas)  

# #selecao
# tempoInicio = time.perf_counter()
# qtd_comparacoes, qtd_trocas = Ordenacao.selecao(lista_selecao)
# tempoFim = time.perf_counter()
# tempo_selecao = tempoFim - tempoInicio
# print("Tempo da rotina ordenar por selecao: ", tempo_selecao , "s")      
# print('Comparacoes:', qtd_comparacoes)
# print('Trocas:', qtd_trocas)  

# #insercao
# tempoInicio = time.perf_counter()
# qtd_comparacoes, qtd_trocas = Ordenacao.insercao(lista_insercao)
# tempoFim = time.perf_counter()
# tempo_insercao = tempoFim - tempoInicio
# print("Tempo da rotina ordenar por insercao: ", tempo_insercao , "s")      
# print('Comparacoes:', qtd_comparacoes)
# print('Trocas:', qtd_trocas)  


# #agitacao
# tempoInicio = time.perf_counter()
# qtd_comparacoes, qtd_trocas = Ordenacao.agitacao(lista_agitacao)
# tempoFim = time.perf_counter()
# tempo_agitacao = tempoFim - tempoInicio
# print("Tempo da rotina ordenar por agitacao: ", tempo_agitacao , "s")      
# print('Comparacoes:', qtd_comparacoes)
# print('Trocas:', qtd_trocas)  

# #pente
# tempoInicio = time.perf_counter()
# qtd_comparacoes, qtd_trocas = Ordenacao.pente(lista_pente)
# tempoFim = time.perf_counter()
# tempo_pente = tempoFim - tempoInicio
# print("Tempo da rotina ordenar por pente: ", tempo_pente , "s")      
# print('Comparacoes:', qtd_comparacoes)
# print('Trocas:', qtd_trocas)  


#Util.exibir_lista(lista_pente,"A")