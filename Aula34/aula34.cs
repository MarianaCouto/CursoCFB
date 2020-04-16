using System;

class Veiculo{  //classe base
    public int rodas;
    public int velMax;
    public bool ligado;

    public void ligar(){
        ligado=true;
    }

    public void desligar(){
        ligado=false;
    }

    public string getLigado(){
        if (ligado){
            return "Sim";
        }else{
            return "Não";
        } 
    }
}

class Carro:Veiculo{   //carro (Derivada) herda da classe Veiculo (Base)
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}
class Aula34{ //Herança de classe em orientação objeto - é um recurso onde uma classe Derivada (filha) que vai herdar membros (Propriedade e classe) da classe Base (pai)
    static void Main(){
        Carro c1 = new Carro("Rapidão", "Vermelho");

        Console.WriteLine("Nome...: {0}", c1.nome);
        Console.WriteLine("Cor....: {0}", c1.cor);
        Console.WriteLine("Rodas..: {0}", c1.rodas);
        Console.WriteLine("Vel Max: {0}", c1.velMax);
        Console.WriteLine("Lig/Des: {0}", c1.getLigado());
        
       

    }
    
}


