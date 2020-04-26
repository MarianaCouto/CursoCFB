using System;
using System.Collections.Generic;

class Aula55{ //Coleção Dictionary -> Coleção de dados aonde tem uma dupla onde o dado é relacionado por uma chave e um valor
    static void Main(){
       
        Dictionary <int, string> veiculos = new Dictionary <int, string>(); //tipo chave, tipo valor -> Dictionary é uma classe, aqui está declarado um objeto desta classe
        
        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Aviao");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        //veiculos.Clear(); //limpa o dictionary
        veiculos.Remove(20); //remove a chave 20 da coleção
        
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        int chave=20;
        if(veiculos.ContainsKey(chave)){//Retorna se a chave existe na coleção, se achar a chave ele retorna true
            Console.WriteLine("A chave {0} está na coleção.", chave);

        }else{
            Console.WriteLine("A chave {0} não está na coleção.", chave);
        }

        veiculos[15]="Bicicleta"; //mudou o valor 15 de Patinete para Bicicleta

        String valor="Bicicleta";
        if(veiculos.ContainsValue(valor)){//Retorna se o valor existe na coleção, se achar o valor ele retorna true
            Console.WriteLine("O valor {0} está na coleção.", valor);

        }else{
            Console.WriteLine("O valor {0} não está na coleção.", valor);
        }

        foreach(KeyValuePair<int,string> lista in veiculos){
            Console.WriteLine(lista.Value);
        }


    
    
}
}

