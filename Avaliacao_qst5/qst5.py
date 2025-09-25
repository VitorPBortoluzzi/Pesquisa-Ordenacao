class Ordenacao:
    @staticmethod
    def bolha_sort(lista):
        houve_troca=True
        fim = len(lista)
        while(houve_troca):
            houve_troca = False
            for i in range (fim -1):
                if (lista[i].nome > lista[i+1].nome):
                    houve_troca = True
                    tmp = lista[i]
                    lista[i] = lista[i+1]
                    lista[i+1] = tmp
                if(lista[i].nome == lista[i+1].nome):
                    if(lista[i].idade > lista[i+1].idade):
                        houve_troca = True
                        tmp = lista[i]
                        lista[i] = lista[i+1]
                        lista[i+1] = tmp
            fim-=1

    @staticmethod
    def pente(lista):
        houve_troca = True
        distancia = len(lista)
        
        while (houve_troca or distancia > 1):    
            distancia = int(distancia /1.3)
            if (distancia < 1):
                distancia = 1
            houve_troca = False
            for i in range (len(lista) - distancia):
                if (lista[i].nome > lista[i+distancia].nome):                    
                    houve_troca = True
                    tmp = lista[i]
                    lista[i] = lista[i+distancia]
                    lista[i+distancia] = tmp
                if (lista[i].nome == lista[i+distancia].nome):
                    if (lista[i].idade > lista[i+distancia].idade):                        
                        houve_troca = True
                        tmp = lista[i]
                        lista[i] = lista[i+distancia]
                        lista[i+distancia] = tmp



class Pessoa:
    def __init__(self, nome, idade):
        self.nome = nome
        self.idade = idade

    def __str__(self):
        return f"Nome: {self.nome}. Idade: {self.idade}"
    

lista_bolha = [Pessoa("Alex",50),Pessoa("Alex",20),Pessoa("Davi",45),Pessoa("Bia",20),Pessoa("Carlos",40),Pessoa("Bia",14),Pessoa("Davi",10)]
lista_pente = [Pessoa("Alex",50),Pessoa("Alex",20),Pessoa("Davi",45),Pessoa("Bia",20),Pessoa("Carlos",40),Pessoa("Bia",14),Pessoa("Davi",10)]
# for i in range(7):
#     nome = input("Digite nome: ").upper()
#     idade = input("Idade:" )

#     lista.append(Pessoa(nome,idade))

Ordenacao.bolha_sort(lista_bolha)
for pessoa in lista_bolha:
    print(pessoa)

print("\n")
Ordenacao.pente(lista_pente)
for pessoa in lista_pente:
    print(pessoa)

