/*using System;
using System.Globalization;

namespace Course1 {
    class Program {
        static void Main(string[] args) {

            EXERCICIO 60 *************************


            ContaBancaria02 banco;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = (Console.ReadLine());
            Console.Write("Havera deposito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's' || depositoInicial == 'S') {
                Console.Write("Entre o valor de deposito inicial: ");
                double valorDepInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                banco = new ContaBancaria02(numero, titular, valorDepInicial);
                Console.WriteLine();
            }
            else {
                banco = new ContaBancaria02(numero, titular);
            }


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");

            double valoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Deposito(valoDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Saque(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);



        }
    }
}*/