class Aluno:
    def __init__(self, nome, curso):
        self.nome = nome
        self.curso = curso

    def __str__(self):
        return f"Nome: {self.nome}. Curso: {self.curso}"
    
lista = []
for i in range(4):
    nome = input("Digite nome: ").upper()
    curso = input("Curso:" ).upper()

    lista.append(Aluno(nome,curso))


# ordenar por curso e nome;
lista.sort(key = lambda aluno: (aluno.curso, aluno.nome))

# copia a lista para nova lista "ordenar por nome"
# ordenar por curso e nome
ordenar_por_nome = sorted(lista, key = lambda aluno: (aluno.curso, aluno.nome))

for aluno in lista:
    print(aluno)