using System;

class Aula17{  //Arrey / Vetor unidimensionais [] Abrir e fechar o colchete quer dizer que é o array
    static void Main(){
        int[] n = new int[5]; // a primeira posição do array é sempre zero, este exemplo 0 a 4. arrey com 5 posições
        //int[] num = new int[3] {55,77,99}; //Declarando e atribuindo os valores
        int[] num = {55,77,99}; //desta forma o tamanho do array é a qtde de atribuições
        string[] veiculos = new string[3];

        veiculos[0]="Carro"; //desta forma o código fica mais legível
        veiculos[1]="Avião";
        veiculos[2]="Navio";

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine(n[1]);
        Console.WriteLine(veiculos[1]);
}
}
