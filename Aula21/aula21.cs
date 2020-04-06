using System;

class Aula21{  //DO WHILE / Estruturas de iteração ("Faça isto Enquanto" garante que pelo menos 1 vez será executado)
    static void Main(){
/*        int num=5;
        do{
            Console.WriteLine("CFB Cursos");
        }while (num<5);*/

        string senha="123";
        string senhauser;
        int tentativas = 0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser=Console.ReadLine();
            tentativas++;
        }while(senhauser != senha);

        Console.Clear();
        Console.WriteLine("Senha correta, tentativas: {0}", tentativas);
        

    }
}
