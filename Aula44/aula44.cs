using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){//Struct pode ter um construtor
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;

    }
    public void info(){
        Console.WriteLine("Marca......: {0}", this.marca);
        Console.WriteLine("Modelo.....: {0}", this.modelo);
        Console.WriteLine("Cor........: {0}", this.cor);

    }
}
class Aula44{ //Struct ou Estrutura-> é um tipo que vai permitir o armazenamento de diferentes tipos de dados. Como não é uma classe não pode herdar e nem ser herdada
    static void Main(){
        
        Carro c1 = new Carro("Honda","HRV","Prata");
        Carro c2 = new Carro("VW","Golf","Azul");
        c1.info();
        c2.info();
        
    }
    
}


