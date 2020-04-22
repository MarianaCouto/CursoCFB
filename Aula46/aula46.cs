﻿using System;

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }
    public Ovo botar(){//metodo-> acesso, tipo retorno, nome metodo (método que retorna o tipo de objeto ovo)
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo=numOvo;
        this.minhaGalinha=minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minhaGalinha );

    }
}

class Aula46{ //Métodos que retornam objetos
    static void Main(){
        Galinha g1 = new Galinha("Beneditasgildimar");
        Galinha g2 = new Galinha("Felizbertaniazilda");
        Galinha g3 = new Galinha("Marisgertrudeszela");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();

        
     


        
    }
    
}


