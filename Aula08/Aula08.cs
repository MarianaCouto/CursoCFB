using System;

class Aula08{
    static void Main(){ //ler o valor do teclado
        int v1,v2,soma;
        string nome;
        string querer = "";
      //  char Operador;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Olá {0}", nome + "! Vamos brincar de adição? Digite sim ou não: ");
        querer = Convert.ToString (Console.ReadLine());
        if (querer == "não")
        {
            Console.WriteLine("Que pena! A gente brinca da próxima vez");
        }
            else if (querer == "sim")
            {
                Console.Write("Digite um número: ");
                v1 = int.Parse(Console.ReadLine()); //convertendo em inteiro
               // Console.Write("Digite a operação (+, -, *, /):");
               // Operador = Console.ReadLine();                          
                Console.Write("Agora digite mais um número: ");
                v2 = Convert.ToInt32(Console.ReadLine()); //convertendo em inteiro igual ao parse
                soma = v1 + v2;
                Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1,v2,soma);
        
            } 

            else {

                Console.WriteLine ("Esta resposta está errada!");
            }
            
        
        



    }
    
}

