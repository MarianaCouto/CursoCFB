using System;

public class Jogador{ // quando não define o modificador ela é publica
    public int energia=100;
    public bool vivo=true;
    

}

class Aula28{  //Classes e Objetos
    static void Main(){
        Jogador j1=new Jogador();  // Objetos - new aloca a memória necessária e retorna o endereço na memória
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();

        j1.energia=50;
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
        
    }

    
}

