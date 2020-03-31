using System;

class Aula06{ //formatação do console

    static void Main(){

        int n1,n2,n3;
        n1=10; n2=20; n3=30;
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        Console.WriteLine("Os valores são: " + n1 + ", " + n2 + ", " + n3 + "...");
        Console.WriteLine ("n1={0}, n2={1}, n3={2}", n1,n2,n3); // {} indices - writeLine quebra a linha no final em relação ao Write
        Console.WriteLine ("n1=\t{0}\nn2=\t{1}\nn=\t{2}", n1,n2,n3); // caracter de escape \n enter \t tabulação
        Console.WriteLine ("Produto.........:{0,15}",produto); // 15 é o espaço dado entre o texto e a variável
        Console.WriteLine ("Vl. Compra......:{0,15:c}",valorCompra); // c é o formato de saída R$
        Console.WriteLine ("Lucro...........:{0,15:p}",lucro); // p formato de porcentagem
        Console.WriteLine ("Vl. Venda.......:{0,15:c}",valorVenda);
    }
    
}

