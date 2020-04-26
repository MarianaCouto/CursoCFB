using System;

namespace Calc1{
    class Area{
    public static float Quad(float bas, float alt){
        if(bas==0 || alt==0){
            throw new Exception("Base ou Altura não podem ser igual a 0");
        }
        return bas*alt;

    }

}
}
namespace Calc2{//permite ter duas classes com nomes iguais e namespace diferentes
    class Area{
    public static float Quad(float bas, float alt){
        if(bas==0 || alt==0){
            throw new Exception("Base ou Altura não podem ser igual a 0");
        }
        return bas*alt;

    }

}
}

class Aula54{ //Namespaces -> método de organização para controlar o escopo, serve para agrupar as classes por tipo
    static void Main(){
        float area=0;

        try{
            area=Calc1.Area.Quad(0F,5F);
            Console.WriteLine("Area do quadrado: {0}", area );
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}", e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }
     
    }
    
}


