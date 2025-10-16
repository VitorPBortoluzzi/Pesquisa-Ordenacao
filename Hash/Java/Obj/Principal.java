import java.util.HashSet;
import java.util.Objects;
import java.util.Random;
import java.util.Scanner;

class Aluno {
    int matricula;
    String nome;
    
    public Aluno(int matricula, String nome){
        this.matricula = matricula;
        this.nome = nome;
        
    }

    @Override
    public String toString() {
        return "Aluno{" + "matricula=" + matricula + ", nome=" + nome + '}';
    }

//    @Override
//    public int hashCode() {
//        int hash = 3;
//        hash = 37 * hash + this.matricula;
//        return hash;
//    }
//
//    @Override
//    public boolean equals(Object obj) {
//        if (this == obj) {
//            return true;
//        }
//        if (obj == null) {
//            return false;
//        }
//        if (getClass() != obj.getClass()) {
//            return false;
//        }
//        final Aluno other = (Aluno) obj;
//        return this.matricula == other.matricula;
//    }

    @Override
    public int hashCode() {
        int hash = 3;
        hash = 73 * hash + this.matricula;
        hash = 73 * hash + Objects.hashCode(this.nome);
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Aluno other = (Aluno) obj;
        if (this.matricula != other.matricula) {
            return false;
        }
        return Objects.equals(this.nome, other.nome);
    }
    
    
}


public class Principal {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        Random gerador = new Random();
        
        HashSet<Aluno> tabela = new HashSet<Aluno>();
        
        String nome;
        int matricula;
        int endereco = 0;
        
        Aluno aluno;
        
        for (int i = 0; i < 5; i++){
            System.out.println("Nome: ");
            nome = teclado.nextLine();
            System.out.println("Matricula: ");
            matricula = teclado.nextInt();
            aluno = new Aluno(matricula, nome);
            
            
            endereco = aluno.hashCode();

            System.out.println("Aluno: " + aluno + ". Endereco: " + endereco);
            
            if(!tabela.add(aluno)){
                System.out.println("Aluno ja inserido: " + aluno + ". Endereco: " + endereco);
            }
            teclado.nextLine();
        }
        System.out.println("Mostrando a tabela....");
        for (Aluno item : tabela) {
            System.out.println(item);
        }
    }
}
