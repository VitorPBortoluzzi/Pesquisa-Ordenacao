
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.HashMap;
import java.util.Scanner;

public class Principal {/*
    public static void main(String[] args) {
        HashMap<String, Sessao> sessoes = new HashMap<>();
        
        try (BufferedReader br = new BufferedReader(new FileReader("telephony_sessions.txt"))) {
            String linha;
            while ((linha = br.readLine()) != null) {
                String[] partes = linha.split(";", 2); // divide só no primeiro ponto-e-vírgula
                String numero = partes[0];
                String dados = partes[1];

                sessoes.put(numero, new Sessao(numero, dados));
            }
        } catch (IOException e) {
            System.out.println("Erro ao ler arquivo: " + e.getMessage());
            return;
        }
        
        Scanner scanner = new Scanner(System.in);
        System.out.print("Digite um número de celular para buscar: ");
        String numeroBusca = scanner.nextLine().trim();

        Sessao resultado = sessoes.get(numeroBusca);

        if (resultado != null) {
            System.out.println("\nSessão encontrada:\n" + resultado.dadosSessao);
        } else {
            System.out.println("\nNúmero não encontrado na base!");
        }
    }*/
}
