import java.util.HashSet;
import java.util.Random;
import java.util.Scanner;

public class Principal {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        
        Random gerador = new Random();
        HashSet<String> tabela = new HashSet<String>();
        String frase;
        int endereco;
        
        for (int i = 0; i < 5; i++){
            System.out.println("Frase ");
            frase = teclado.nextLine();
            endereco = frase.hashCode();
            System.out.println("Frase: " + frase + ". endereco: " + endereco);
            
            if(!tabela.add(frase)){
                System.out.println("Frase ja inserido: " + frase + ". Endereco: " + endereco);
            }
        }
        
        for (String item : tabela) {
            System.out.println(item);
        }
    }
}
