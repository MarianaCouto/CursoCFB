using System;

class Aula20{  //While / Estruturas de iteração ("Enquanto" é mais utilizado quando não sabemos a qtde de repetição)
    static void Main(){

        int[] num2 = new int[10];

        int i = 0;
             //expressão lógica enquanto for verdadeira
        while(i<num2.Length){
            num2[i]=i;
            Console.WriteLine("Valor de num2 na posição {0}: {1}", i,num2[i]);
            i++;
        }
        Console.WriteLine("Fim do loop");
    }
}
