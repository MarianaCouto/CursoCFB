using System;

class Aula24{  //Métodos 
    static void Main(){
        int v1, v2, r;
        Console.WriteLine("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2=int.Parse(Console.ReadLine());
        cfb();
        //soma(v1,v2);
        r=somaretorna(v1,v2);
        Console.WriteLine("A soma de {0} e {1} é: {2}", v1,v2,r);
     }

    static void cfb(){  // void não retorna nada, entre () os parâmetros
        Console.WriteLine("CFB Cursos");
    }

/*    static void soma(int n1, int n2){ //2 argumentos, parametros de entrada
        int res=n1+n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1,n2,res);
    }*/

    static int somaretorna(int n1, int n2){ //2 argumentos, parametros de entrada, int é o tipo do valor retornado
        int res=n1+n2;
        return res;
    }

}

