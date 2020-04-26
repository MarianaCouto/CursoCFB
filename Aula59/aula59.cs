using System;
using System.Collections.Generic;

class Aula59{ //Coleção Queue (Fila)-> particularidade onde o primeiro elemento a entrar é o primeiro a sair Fist in First out
    static void Main(){

       //string[] vs={"Carro", "Moto", "Navio", "Aviao"}; // pode iniciar uma coleção existente
        Queue<string>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro"); //Adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v="Avião";
        if(veiculos.Contains(v)){ //método que verifica se contem na fila
            Console.WriteLine("Veículo "+ v + " encontrado");
        }else{
            Console.WriteLine("Veículo " + v + " não está na fila");
        }

        // veiculos.Clear(); // limpa a fila
        //Console.WriteLine("Primeiro Veiculo: "+veiculos.Dequeue()); //retorna o primeiro veiculo e remove ele da fila
        //Console.WriteLine("Tamanho da fila: "+veiculos.Count);
        Console.WriteLine("Primeiro veiculo: "+veiculos.Peek()); //retorna o primeiro veiculo e não remove
           
        /*foreach(string list in veiculos){
            Console.WriteLine("Veiculo: {0}", list);
        } */       
        Console.WriteLine("Tamanho da fila: "+veiculos.Count);

        while (veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
        }  
        Console.WriteLine("Tamanho da fila: "+veiculos.Count);             
    } 
    
}

