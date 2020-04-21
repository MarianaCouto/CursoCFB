using System;

class Veiculo{//classe Base
    public int velAtual;
    private int velMaxima; //private restringe ao acesso ao membro somente dos métodos desta classe, a classe derivada não terá acesso aos membros private
    protected bool ligado; //protected permite acesso aos membros pela classe base e pelas classes derivadas 

    public Veiculo(int velMaxima){
        velAtual=0;
        this.velMaxima=velMaxima;
        ligado=false;
        
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVelMaxima(){
        return velMaxima;
    }
}

class Carro:Veiculo{
    public string nome;

    public Carro(string nome, int vm):base(vm){//Derivada de veículo
        this.nome=nome;
        ligado=true;


    }

}
class Aula36{ //Membros Protected
    static void Main(){

        Carro carro = new Carro("Bonitão", 120);
        Console.WriteLine("Nome do carro: {0}", carro.nome);
        Console.WriteLine("Veloc Max....: {0}", carro.getVelMaxima());
        Console.WriteLine("Ligado.......: {0}", carro.getLigado());



    }
    
}


