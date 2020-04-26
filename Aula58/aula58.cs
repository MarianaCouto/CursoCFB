using System;
using System.Collections.Generic;

class Aula58{ //Coleção List P2-> Continuação da list
    static void Main(){

        List<string>carros=new List<string>();
        string[] carros2=new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //carros2.AddRange(carros); //adiciona na lista de carros2 a lista de carros

        //carros.Clear(); //limpa

        if(carros.Contains("Fox")){ //retorna true se acha
            Console.WriteLine("Está na lista");
        }else
        {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2); //copiar para a partir da posição 2

        carros.Insert(1,"Cruze");  //inserir elementos em uma posição determinada

        //carros.RemoveAt(0); // remove na posição indicada

        //carros.Remove("Argo"); //remove o registro

       /* if(carros.Remove("Argo")){
            Console.WriteLine("Carro removido");
        }else
        {
            Console.WriteLine("Carro não removido");
        }*/

        carros.Reverse(); //inverte a lista
        carros.Sort(); //ordena por ordem alfabética

        int tamanho=carros.Count;
        carros.Capacity=15;
        int capacidade=carros.Capacity;

        Console.WriteLine("Quantidade de carros: {0}", tamanho);
        Console.WriteLine("Capacidade: {0}", capacidade);
 
        foreach (string c in carros){
            Console.WriteLine("Carro: {0}", c);
        }

        int pos2=carros.LastIndexOf("HRV");//retorna a última posição de um determinado elemento

        String ca="HRV";
        int pos=0;
        pos=carros.IndexOf(ca);  //retorna o indice da primeira ocorrência
        Console.WriteLine("Carro {0} está na posição {1}", ca,pos);
        Console.WriteLine("Último HRV está na posição {0}", pos2);


        
            
    }
}

