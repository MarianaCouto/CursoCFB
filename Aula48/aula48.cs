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
    
    // exemplo Fatorial de 5! = 5*4*3*2*1
    public int fat(int n){
        int res;
        if(n<=1){
            res=1;
        }else {
            res=n*fat(n-1);
        }
        return res;

    }


}

class Aula48{ //Recursividade -> é uma função chamando ela mesmo, substitui o loop For por exemplo -> Fatorial de 5! = 5*4*3*2*1
    static void Main(){
        Calc c1 = new Calc();

        var res=c1.fat(5);

        Console.WriteLine("O fatorial é: {0}", res);
     


        
    }
    
}


