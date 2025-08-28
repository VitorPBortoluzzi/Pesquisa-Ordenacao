

bool houveTroca = false;
int tmp;
int ini = 0;
int fim = lista.Count;
int qtdTrocas = 0;
int qtdComparacoes = 0;

do {
    houveTroca = false;
    for (int i=0; i< fim-1 ; i++){
        qtdComparacoes++;
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