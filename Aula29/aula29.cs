using System;

public class Jogador{ 
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){ // este é o método construtor, que será executado automaticamente ao instanciar o objeto da classe
        energia=100;
        vivo=true;
        nome=n;

    }  
    ~Jogador(){ //este é o destrutor, precedido de um ~
        Console.WriteLine("Jogador {0} foi destruído", nome);

    }

}

class Aula29{  //Construtores (é o método (tem o mesmo nome da classe) que vai inicializar as variáveis do objeto instanciado da classe) e Destrutores (será executado quando a classe for destruída, será chamado antes do objeto ser destruído pelo Garbage collector)
    static void Main(){
        string nome1, nome2;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1=Console.ReadLine();
        Console.WriteLine("Digite o nome do jogador 2: ");
        nome2=Console.ReadLine();


        Jogador j1=new Jogador(nome1);  // Objetos - new aloca a memória necessária e retorna o endereço na memória
        Jogador j2=new Jogador(nome2);
       
        j1.energia=50;
        Console.WriteLine("Energia do jogador {0}: {1}", j1.nome,j1.energia);
        Console.WriteLine("Energia do jogador {0}: {1}", j2.nome,j2.energia);
        
    }

    
}

