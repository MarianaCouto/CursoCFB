using System;

class Aula10{  // Enum ou Enumeradores

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

        static void Main(){
            
            DiasSemana ds = (DiasSemana)3;    // ou assim DiasSemana ds = DiasSemana.Domingo;
            int ds1 = (int) DiasSemana.Sexta;  // ou descobrir o indice de um valor
            Console.WriteLine(ds);
            Console.WriteLine(ds1);



    }
    
}

