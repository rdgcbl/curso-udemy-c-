using System.Globalization;


namespace Course1 {
    class ContaBancaria02 {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria02(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria02(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Saque(double valor) {
            Saldo -= valor;
            Saldo -= 5.0;
        }
        public override string ToString() {
            return "Conta "
                +Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }



    }
}
