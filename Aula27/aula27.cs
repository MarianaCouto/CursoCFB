using System;

class Aula27{  //Argumento params - Permite a entrada de 0 ou mais argumentos para uma função/método
    static void Main(){
        soma(6,6,6,5);
        
    }

    static void soma(params int[] n){ //pode entrar nada, 1 ou mais de um, sendo 1 ou mais percorrer o array
        int res=0;

        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados.");
        }else if(n.Length < 2){
            Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
        }else{
            for(int i=0;i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }     
    }
}

