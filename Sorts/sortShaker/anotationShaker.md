##

```cs
bool houveTroca = false;


do {
    houveTroca = false
    for (int i=0; i< fim-1 ; i++){
        qtdComparacores++;
        if(lista[i]> lista[i+1]){
            qtdTrocas++;
            houveTroca = true;
            tmp = lista[i];
            lista[i+1] = tmp;
        }
    }

    if (!houveTroca){
        break;
    } fim --;

    houveTroca = false;
    for (int i=0; i > ini+1; i--){
        qtdComparacoes++;
        if(lista[i] < lista[i-1]){
            qtdTrocas++;
            houveTroca = true;
            tmp = lista[i];
            lista[i] = lista[i-1];
            lista[i-1] = tmp;
        }
    }
} while (houveTroca);

```