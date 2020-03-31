using System;

class Aula11{  // type cast conversão de um tipo em outro -- ler teipecast implícito não precisa converter float recebe int
    static void Main(){

        int n1=10;
        float n2=n1;
        float n3=10.5f;
        int n4=(int)n3;  //isto é uma operação de type cast
        short n5=(short)n1;


        Console.WriteLine(n2);
        Console.WriteLine(n4);



    }
    


}

