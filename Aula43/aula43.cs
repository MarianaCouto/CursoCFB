using System;

public interface Veiculo{
    void ligar();
    void desligar();
    void info();

}

public interface Combate{
    void disparar();

}

class Carro:Veiculo,Combate{
    public bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
        
    }

    public void setMunicao(int qtde){
        this.municao=qtde;
    }
    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }
    public void info(){}
    public void disparar(){}
    
}
    
class Aula43{ //Interfaces->classes que só implementam métodos ou os protótipos (assinatura) dos métodos, não utiliza as propriedades/campos- não tem construtor nem destrutor. As classes derivadas precisam ter todos os métodos da base
    static void Main(){
       Carro c1 = new Carro();
        
       
    }
    
}


