using System;

abstract class Veiculo{ //Classe Base Abstrata
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){// o construtor não é abstrato
        ligado=false;
        velAtual=0;
    }

    public void setLigado(bool ligado){
        this.ligado=ligado;
    }

    public bool getLigado(){
        return ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }

    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    
    public Carro(){
        ligado=true;
        velMaxima=120;
    }

    override public void aceleracao(int mult){
        velAtual+=10*mult;

    }
}

class Aula39{ //Classes abstratas e métodos abstratos -> Classe de referência para classes que vão herdar a classe abstratas, não podem ser instanciadas, só servem para serem herdadas. Nos métodos abstratos não implementamos o comportamento do método, só criamos o protótipo que vai servir como referencia para classes que estão herdando as classes abstratas e são obrigatórios nas classes derivadas.
    static void Main(){
        
        Carro carro1 = new Carro();
        carro1.setLigado(false);

        carro1.aceleracao(1);
        Console.WriteLine(carro1.getVelAtual());
        Console.WriteLine(carro1.getLigado());
        
    }
    
}


