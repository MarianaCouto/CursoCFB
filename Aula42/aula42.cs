using System;

class Carro{
    private int[] velMax=new int[5]{80,120,160,240,500};
    
    public int this[int i]{// [indice do vetor para indicar a posição do array/vetor]
        get{//leitura
            return velMax[i];

        }
        set{//escrita
            if(value<0){
                velMax[i]=0;
            }else if (value>300){
                velMax[i]=300;
            }else velMax[i]=value;
        }
        
    }
    public Carro(){
      
    }
}

class Aula42{ //Indexadores de Classes -> o indexador vai permitir aos objetos serem utilizados como array
    static void Main(){
        Carro c1 = new Carro();
        //c1[4]=600;
        Console.WriteLine("Velocidade: {0}", c1[4]);
        
       
    }
    
}


