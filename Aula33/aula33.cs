using System;

class Jogador{
    private int energia;
    private string nome;

    public Jogador(string nome){//construtor
        this.nome=nome;
        energia=100;

    }

    public int getEnergia(){ // get obter, não precisa ter este nome
        return energia;

    }
    public string getNome(){ // get obter, não precisa ter este nome
        return nome;;

    }

    public void setEnergia(int e){
        if (e<0){
            if (energia+e < 0){
                energia=0;
            }else{
                energia+=e;
            }   
        }else if (e>0){
             if (energia+e > 100){
                energia=100;
            }else{
                energia+=e;
            }   
    }

}

class Aula33{ //Public vs Private -> as variáveis private só podem ser utilizadas por dentro da classe
    static void Main(){
        Jogador j1=new Jogador("Jogador1");
        j1.setEnergia(-30);
        j1.setEnergia(10);
     

        Console.WriteLine("Nome...: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());

    }
    
}
}

