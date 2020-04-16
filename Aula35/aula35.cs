using System;

class Veiculo{  //classe base
    private int rodas;
    public int velMax;
    public bool ligado;

    public Veiculo(int rodas){ //construtor com 1 argumento
        this.rodas=rodas;
    }
        public void ligar(){
        ligado=true;
    }

    public void desligar(){
        ligado=false;
    }

    public string getLigado(){
        return (ligado?"Sim":"Não"); //Operador ternário: primeiro valor Sim para True e segundo valor para False
/*        if (ligado){
            return "Sim";
        }else{
            return "Não";
        } */ //AO INVÉS DO IF, UTILIZAR O OPERADOR TERNÁRIO
    }

    public int getRodas(){
        return rodas;
    }

    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        }else if(rodas>40){
            this.rodas=40;
        }else{
            this.rodas=rodas;
        }
    }
}

class Carro:Veiculo{   //carro (Derivada) herda da classe Veiculo (Base)
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){//no construtor da classe derivada, deve colocar o argumento da classe base que está no método construtor
        desligar();
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

class CarroCombate:Carro{ //cadeia de herança -> CarroCombate herda de carro, e carro herda de veiculo, todos herdam de veiculo
    public int municao;

    public CarroCombate():base("Carro de Combate", "Verde"){
        municao=100;
        setRodas(6);

    }

}
class Aula35{ //Cadeia de herança e Construtor da classe base 
    static void Main(){
        Carro c1 = new Carro("Rapidão", "Vermelho");
        CarroCombate c2 = new CarroCombate();
        c1.ligar();

        Console.WriteLine("Nome...: {0}", c1.nome);
        Console.WriteLine("Cor....: {0}", c1.cor);
        Console.WriteLine("Rodas..: {0}", c1.getRodas());
        Console.WriteLine("Vel Max: {0}", c1.velMax);
        Console.WriteLine("Ligado.: {0}", c1.getLigado());
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Nome...: {0}", c2.nome);
        Console.WriteLine("Cor....: {0}", c2.cor);
        Console.WriteLine("Rodas..: {0}", c2.getRodas());
        Console.WriteLine("Vel Max: {0}", c2.velMax);
        Console.WriteLine("Ligado.: {0}", c2.getLigado());
        Console.WriteLine("Munição.: {0}",c2.municao);
        
       

    }
    
}


