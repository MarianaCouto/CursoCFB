using System;

class Aula25{  //Passagem por valor e por referência (referência usa o mesmo endereço de memória)
    static void Main(){
        int num=50;
        dobrar1(ref num);
        Console.WriteLine(num);
       
    }

    static void dobrar1(ref int valor){

        valor*=2; //dobrar o valor por 2
        
    }
    static void dobrar2(int valor){

        valor*=2; //como não tem a referência, o valor acima é impresso sem dobrar
        
    }
}

