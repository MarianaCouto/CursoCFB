using System;

class Aula13{  //if else
    static void Main(){
     int res,n1,n2,n3,n4;
        res=n1=n2=n3=n4=0;
        string aluno;
        string resultado;

        Console.Write("Digite o nome do aluno: ");
        aluno=Console.ReadLine();

        Console.Write("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());
        
        Console.Write("Digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;
     
        //>= 60 - Aprovado
        //59 e 40 - Recuperação
        //<30 - Reprovado

        if (res < 40){
            resultado="reprovado";
        }else if (res < 60){
            resultado="recuperação";
        }else{
            resultado="aprovado";
        }

        Console.WriteLine("O Aluno {0} possui o total de notas {1} e foi {2}",aluno,res,resultado);


    }
    
}

