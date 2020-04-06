using System;

class Aula23{  //Métodos para arrays #P1 (métodos para manipular vetores e matrizes)
    static void Main(){

       int[] vetor1 = new int[5];
       int[] vetor2 = new int[5];
       int[] vetor3 = new int[5];
       int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};
       Console.WriteLine(matriz[0,1]);

       Random random = new Random(); //valor aleatório, randômico
       for(int i=0;i<vetor1.Length;i++){
           vetor1[i]=random.Next(50); //Next pode inicializar sem nada, 1 valor máximo, ou 2 valores min e max
       }

       Console.WriteLine("Elementos do vetor1");
       foreach(int n in vetor1){
           Console.WriteLine(n);
       }

       //public static int BinarySearch(array,valor); Retorna a posição do elemento procurado, retorno NEGATIVO se elemento não encontrado
       Console.WriteLine("BinarySearch");
       int procurado = 33;
       int pos=Array.BinarySearch(vetor1,procurado);
       Console.WriteLine("Valor {0} está na posição {1}", procurado,pos); 
       Console.WriteLine("-----------------------------------------");

       //public statis void Copy (Array_Origem, Array_Destino, qtde_elementos); Copia os valores de um vetor para outro vetor
       Console.WriteLine("Copy");
       Array.Copy(vetor1,vetor2,vetor1.Length);
       foreach(int n in vetor2){
           Console.WriteLine(n);
       }
       Console.WriteLine("-----------------------------------------");

        //public void CopyTo(Array_Destino,a_partir_desta_posição); Copia os valores do vetor 1 para o 3
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-----------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1); //dimensão 1 ou linha 1
        Console.WriteLine("Menor índice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("-----------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("-----------------------------------------");

        //public object GetValue(long índice);
        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("-----------------------------------------");

        //public static int Indexof(array, valor);
        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("-----------------------------------------");
        
        //public static int LastIndexof(array, valor);
        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Índice do último valor 3: {0}", indice2);
        Console.WriteLine("-----------------------------------------");

        //public static void Reverse(array); // 12345 para 54321
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public void SetValue(object valor, long pos);
        vetor2.SetValue(99,0);
        for (int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("Vetor 2");
            foreach(int n in vetor2){
                Console.WriteLine(n);
            }

        //public static void Sort(array); Ordenar crescente, caso queira decrescente usar Sort e depois Reverse
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor 1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);     
        }
        Console.WriteLine("\nVetor 3");
        foreach(int n in vetor3){
            Console.WriteLine(n);     
        }

    }

}
