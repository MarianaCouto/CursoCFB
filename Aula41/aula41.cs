using System;

class Carro{
    private int velMax;
    
    public int vm{// não tem os parenteses por não ser um método e sim uma propriedade
        get{//leitura
            return velMax;

        }
        set{//escrita
            if(value<0){
                velMax=0;
            }else if (value>300){
                velMax=300;
            }else velMax=value;
        }
        
    }
    public Carro(){
        vm=120;
    }

/*    public void vm(int velMax){
        this.velMax=velMax;
    }*/ // é substituido pelo acessors


}

class Aula41{ //Acessors GET e SET-> Propriedades especiais onde são flexíveis e é possível LER, ATRIBUIR OU CALCULAR o valor pelas propriedades acessors
    static void Main(){
        Carro c1 = new Carro();
        c1.vm=200;
        Console.WriteLine("Velocidade: {0}", c1.vm);
        
       
    }
    
}


