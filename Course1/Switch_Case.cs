/*
using System;
namespace Switch_Case {
    class Program {
        static void Main(string [] args) {

        }
int x = int.Parse(Console.ReadLine());          int x = int.Parse(Console.ReadLine());
string day;                                     string day;

if (x == 1) {                                   switch (x) {   
    day = "Sunday";                                 case 1:        CASO ELA SEJA 1, A VARIAVEL DAY RECEBE DOMINGO
}                                                       day = "Monday";
else if (x == 2) {                                      break;
    day = "Monday";                                 case 2:
}                                                       day = "Tuesday";
else {                                                  break;
    day = "Invalid value";                          default:      NAO DEU CERTO NENHUM DOS CASOS ACIMA ENTAO DEFAULT RECEBE O DAY INVALIDO  
}                                                      day = "Invalido"
    Console.WriteLine("Day: " + day);                  break;    
                                                    }
                                                    Console.WriteLine("Valor Invalido: " + day);



    
}
    }
        }

*/