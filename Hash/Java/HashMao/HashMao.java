import java.util.ArrayList;
import java.util.Scanner;
//Controlar duplicadas e fazer um mecanismo de buscas: tabela na posição x endereco y
class Util {
    public static int hash(int numero, int tamanho){
        return numero % tamanho;
    }
    
    //necessário?
    public static int[] busca(ArrayList<Integer>[] tabela, int numero){
        for (int i = 0; i <tabela.length; i++){
            for (int j = 0; j <tabela[i].size(); j++){
                if(tabela[i].get(j).equals(numero)){
                    return new int[] {i, j};
                }
            }
        } 
        return null;
    }
}


public class HashMao {
    public static void main(String[] args) {
        
        // Principio da tabela hash:
//Cria um vetor (array) de 10 posições, cada um será uma lista;
        ArrayList<Integer>[] tabela = new ArrayList[10];
        
//Inicializa cada posição do vetor com uma nova lista
        for (int i = 0; i < tabela.length; i++){
            tabela[i] = new ArrayList<>();
        }
        
//receber um numero
        Scanner teclado = new Scanner(System.in);
        int numero, endereco;
        for (int i = 0; i < 5; i++){
            System.out.println("Numero: ");
            numero = teclado.nextInt();
            
            //calcular o endereco do numero dentro da tabela para o espalhamento
            endereco =  Util.hash(numero,tabela.length);
            System.out.println("Endereco gerado: " + endereco);
            
            
            boolean existe = false;
            for (int j = 0; j <tabela[endereco].size(); j++){
                if(tabela[endereco].get(j).equals(numero))
                    existe = true;
            }
            //inserir o numero no endereco gerado
//            tabela[endereco].add(numero);
            if (!existe){
                tabela[endereco].add(numero);
            } else {
                System.out.println("Número " + numero + " já existe na posição " + endereco);
            }         
            
//            if (!tabela[endereco].contains(numero)) {
//                tabela[endereco].add(numero);
//            } else {
//                System.out.println("Número " + numero + " já existe na posição " + endereco);
//            }
        }
        
        System.out.println("Ferramenta de busca....");
        int numeroBusca;
        System.out.println("Insira o numero que deseja procurar na tabela hash: ");
        numeroBusca = teclado.nextInt();
        int[] posicaoencontrada = Util.busca(tabela, numeroBusca);
        if (posicaoencontrada != null) {
            System.out.println("Número " + numeroBusca + " encontrado na posição " + posicaoencontrada[0] + "; Index: " + (posicaoencontrada[1]+1));
        } else {
            System.out.println("Número " + numeroBusca + " não encontrado.");
        }



       //        percorrendo o vetor e imprimindo o conteúdo:
        for (int i = 0; i <tabela.length; i++){
            System.out.println("Posicao " + i + ": " + tabela[i]);
        }
        
        
    }
 
}
