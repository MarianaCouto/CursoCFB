using System;


class Aula51{ //Argumentos de entrada do programa
    static void Main(string[] args){

        
        int res=0;
        
        if (args.Length > 0){
            Console.WriteLine("Qtde de argumentos {0}", args.Length);
            for(int i=0; i < args.Length; i++){
                Console.WriteLine("Argumento {0}: {1}", i, args[i]);
                res+=Int32.Parse(args[i]);              
            }
            Console.WriteLine("A soma dos argumentos é: {0}", res);
        }else{
            Console.WriteLine("Não foram passados os argumentos");
        }
        
    }
    
}


