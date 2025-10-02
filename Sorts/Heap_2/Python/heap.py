class Ordenacao:
    @staticmethod
    # def em_heap_maximo(lista):
    #     n = len(lista)
    #     for i in range(n // 2):
    #         esq = 2 * i + 1
    #         dir = 2 * i + 2
    #         if esq < n and lista[i] < lista[esq]:
    #             return False
    #         if dir < n and lista[i] < lista[dir]:
    #             return False
    #     return True

    def em_heap_maximo(lista):
        i = 0
        while (i*2+1 < len(lista)):
            fe = i * 2 + 1
            fd = i * 2 + 2
            if(lista[i] < lista[fe]):
                return False
            
            if (fd < len(lista)):
                if (lista[i] < lista[fd]):
                    return False
                
            i+=1
        
        return True


def main():
    # maior = (i - 1) /2
    # filho_esq = raiz * 2 +1
    # filho_dir = raiz * 2 + 2  
    lista = [8, 3, 6, 1, 5, 2, 7, 4]

    print("Lista Original:",lista)

    if (Ordenacao.em_heap_maximo(lista)):
        print("Em heap máximo")
    else:
        print("Não em heap maximo")


if __name__ == "__main__":
    main()