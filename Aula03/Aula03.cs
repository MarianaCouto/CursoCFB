using System;

class Aula03 //Declaração de variáveis c# é uma linguagem fortemente tipada
{

    static void Main(){
        byte n1=10; // variável de 8 bits que pode receber entre 0 e 255
        int num=0; //caso não atribua um valor, o valor é zero.. int pode receber um valor negativo
        int num1,num2,res;
        char letra='c';
        float valor=5.3f;
        string nome = "Mariana";

        num1=10;
        num2=2;
        res=num1+num2;
        
        var aux=nome; //quando usa o var não especifica o tipo da variável na declaração, pq pega o tipo da atribuição

            Console.WriteLine("Valor da variável: " + aux + "...");
            Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a " + res);

                         


    }
}