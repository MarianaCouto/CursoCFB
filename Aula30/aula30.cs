using System;

public class Jogador{ 
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){ // este é o método construtor, sem parâmetro
        energia=100;
        vivo=true;
        nome="Jogador";
    } 
    public Jogador(string n){ // este é o método construtor, com um parâmetro
        energia=100;
        vivo=true;
        nome=n;
    }  
     public Jogador(string n, int e){ // este é o método construtor, com dois parâmetros
        energia=e;
        vivo=true;
        nome=n;
    }  
    public Jogador(string n, int e, bool v){ // este é o método construtor, com três parâmetros
        energia=e;
        vivo=v;
        nome=n;
    }  
    public void info(){
        Console.WriteLine("Nome do Jogador: {0}", nome);
        Console.WriteLine("Energia do Jogador: {0}", energia);
        Console.WriteLine("Estado do Jogador: {0}\n", vivo);
    }


}

class Aula30{  //Sobrecarga de Construtores -> Mais de um construtor para uma classe, a diferença deles é o números de parâmetros (argumentos de entrada)
    static void Main(){
        Jogador j1=new Jogador();
        Jogador j2=new Jogador("Bruno");  
        Jogador j3=new Jogador("Théo",100);
        Jogador j4=new Jogador("Benegundesfirno",0,false);
       
        j1.info();
        j2.info();
        j3.info();
        j4.info();

    }

    
}

