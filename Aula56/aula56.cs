using System;
using System.Collections.Generic;

class Aula56{ //Coleção LinkedList / Lista duplamente encadeada-> onde cada elemento é um nó da lista, que tem um link para o elemento anterior e posterior
    static void Main(){

        LinkedList<string> transporte = new LinkedList<string>();

        transporte.AddFirst("Carro"); //adiciona no inicio da lista
        transporte.AddFirst("Avião");
        transporte.AddFirst("Navio");
        transporte.AddFirst("Motocicleta");
        transporte.AddLast("Bicicleta"); //adiciona no fim da lista

        LinkedListNode<string> no;
        no=transporte.FindLast("Navio"); //encontrar ultimo
        transporte.AddAfter(no, "Patinete"); // adicionar após
        transporte.AddBefore(no, "Patins"); // adicionar antes

        //transporte.Clear();

        if(transporte.Find("Carro")==null){ //procurar na lista
            Console.WriteLine("Não encontrado");
        }else
        {
            Console.WriteLine("Elemento encontrado");
        }

        //transporte.Remove("Navio"); //remover da lista
        transporte.RemoveFirst(); //remove o primeiro
        transporte.RemoveLast(); //remove o último



        foreach(string t in transporte){

            Console.WriteLine("Tranporte: {0}", t);

        }
        
            
    }
}

