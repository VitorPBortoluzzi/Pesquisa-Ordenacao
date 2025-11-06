
import java.util.Objects;

public class Sessao {
    public String numeroCelular;
    public String dadosSessao;
    
    public Sessao(String numeroCelular, String dadosSessao){
        this.numeroCelular = numeroCelular;
        this.dadosSessao = dadosSessao;
    }

    @Override
    public String toString() {
        return "Sessao{" + "numeroCelular=" + numeroCelular + ", dadosSessao=" + dadosSessao + '}';
    }
    
}
