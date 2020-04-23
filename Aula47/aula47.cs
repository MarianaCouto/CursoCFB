using System;

class Calc{

    public int somar(params int[] n){
        int s=0;
        for(int i=0;i<n.Length;i++){
                s+=n[i];
        }
        return s;
    }

    public double somar(params double[] n){
        double s=0;
        for(int i=0;i<n.Length;i++){
                s+=n[i];
        }
        return s;
    }

}

class Aula47{ //Sobrecarga de métodos-> Mais de um método com o mesmo nome, com parametros de entrada diferente
    static void Main(){
        Calc c1 = new Calc();

        var res=c1.somar(10,5,6,7,8);

        Console.WriteLine("A soma é: {0}", res);
     


        
    }
    
}


