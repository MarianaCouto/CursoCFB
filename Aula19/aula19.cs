using System;

class Aula19{  //Loop FOR / Estruturas de iteração ("Para" é mais utilizado quando sabemos a qtde de repetição)
    static void Main(){
        int[] num2 = new int[10];

            //expressões inicialização, condição execução, incremento ou decremento
        for (int num=0;num<10;num++) { //num=num+1 ou num+=1 ou num++ // testa, incrementa, executa
            Console.WriteLine("Valor de num: {0} ", num);
        } 

        for (int i=0;i<num2.Length;i++) { //num=num+1 ou num+=1 ou num++
            num2[i]=i;   
            Console.WriteLine("Valor de num2 na posição {0}: {1}", i,num2[i]);
        }
    }
}
