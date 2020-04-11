﻿using System;

static public class Jogador{ 
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n){ 
        energia=100;
        vivo=true;
        nome=n;
    } 
    static public void info(){
        Console.WriteLine("Nome do Jogador: {0}", nome);
        Console.WriteLine("Energia do Jogador: {0}", energia);
        Console.WriteLine("Estado do Jogador: {0}\n", vivo);
    }
}

class Inimigo{
    static public bool alerta; // como é static, de qualquer ponto do sistema ao acessar vai ter o mesmo valor
    public string nome;

    public Inimigo(string n){
        alerta=false;
        nome=n;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("--------------------------");
    }
}

class Aula31{  //Classes Static -> Não permite instanciar um objeto através da class statis, sendo assim não podem ter construtores
    static void Main(){
       
        Jogador.iniciar("Mariana");
        Jogador.info();

        Inimigo i1=new Inimigo("Doido");
        Inimigo i2=new Inimigo("Maluco");
        Inimigo i3=new Inimigo("Pirado");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();

    }

    
}

