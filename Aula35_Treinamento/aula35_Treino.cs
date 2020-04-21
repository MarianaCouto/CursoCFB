using System;

class SerHumano{  //classe base

    public string nome;
    public int idade;
    public string raça;
    public string sexo;
    public bool vivo;

    public SerHumano(string nome, int idade, string raça, string sexo, bool vivo){ //construtor com 1 argumento
        this.nome=nome;
        this.idade=idade;
        this.raça=raça;
        this.sexo=sexo;
        this.vivo=vivo;
    }
    
}

class Mulher:SerHumano{   //carro (Derivada) herda da classe Veiculo (Base)
        public int gestações;
    public Mulher(int gestações):base("Mariana",35,"Branca","Feminino",true){//no construtor da classe derivada, deve colocar o argumento da classe base que está no método construtor
        this.gestações=gestações;
    }
}

class MulherGravida:Mulher{ //cadeia de herança -> CarroCombate herda de carro, e carro herda de veiculo, todos herdam de veiculo
    public int filhos;

    public MulherGravida(int filhos):base(1){
        this.filhos=filhos;

    }

}
class Aula35_Treino{ //Cadeia de herança e Construtor da classe base 
    static void Main(){
        MulherGravida m1 = new MulherGravida(3);
       

        Console.WriteLine("Nome........: {0}", m1.nome);
        Console.WriteLine("Idade.......: {0}", m1.idade);
        Console.WriteLine("Raça........: {0}", m1.raça);
        Console.WriteLine("Sexo........: {0}", m1.sexo);
        Console.WriteLine("Vivo........: {0}", m1.vivo);
        Console.WriteLine("Gestações...: {0}", m1.gestações);
        Console.WriteLine("Filhos......: {0}", m1.filhos);

    }
    
}


