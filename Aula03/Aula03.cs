using System;

class Aula03 //variáveis
{

    static void Main(){
        byte n1=10; // 0 e 255
        int num=0;
        int num1,num2,res;
        char letra='c';
        float valor=5.3f;
        string nome = "Mariana";

        num1=10;
        num2=2;
        res=num1+num2;
        
        var aux=nome;

            Console.WriteLine("Valor da variável: " + aux + "...");
            Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a " + res);

                         


    }
}