using System;
using System.Collections.Generic;

class Aula57{ //Coleção List P1-> será usada toda vez que quiser substituir um array tradicional, é uma coleção mais moderna, é um array dinâmico
    static void Main(){

        List<string>carros=new List<string>();
        string[] carros2=new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argus");

        //carros2.AddRange(carros); //adiciona na lista de carros2 a lista de carros

        //carros.Clear(); //limpa

        if(carros.Contains("Fox")){ //retorna true se acha
            Console.WriteLine("Está na lista");
        }else
        {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2); //copiar para a partir da posição 2

        foreach (string c in carros){
            Console.WriteLine("Carro: {0}", c);
        }

        String ca="HRV";
        int pos=0;
        pos=carros.IndexOf(ca);  //retorna o indice da primeira ocorrência
        Console.WriteLine("Carro {0} está na posição {1}", ca,pos);

        
            
    }
}

