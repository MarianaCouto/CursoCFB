using System;

class Aula04{ //escopo de variáveis Global e Local
    static int num = 10; //variável global
   
    static void Main(){
        int num2=0; //variável local
        Console.WriteLine(num);
    
    }
   /* void teste(){
        Console.WriteLine(Num2);
    }*/ //gera erro pq num2 está disponível somente no método main
}