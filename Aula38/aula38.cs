using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void info(){} //virtual indica que o método será sobrescrito
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Derivada 1");
    }   
    override public void info(){ // override vai sobrepor o método da classe base
        Console.WriteLine("Derivada 1");
    }

}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Derivada 2");
    }            
    override public void info(){ // override vai sobrepor o método da classe base
        Console.WriteLine("Derivada 2");
    }
}

class Aula38{ //Métodos virtuais -> são métodos com mesmo nome em classes diferentes e ações diferentes, uma classe que herda a outra, que tem método com o mesmo nome do método da classe base
    static void Main(){
        Base Ref; //Precisa ser Ref escrito desta forma
        Derivada1 d1 = new Derivada1(); 
        Derivada2 d2 = new Derivada2(); 
        
        Ref=d2;
        Ref.info();
    }
    
}


