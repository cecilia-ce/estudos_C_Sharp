using System.Globalization;

namespace ExercicioBanco
{
    class Conta
    {
        public int Numero { get; private set; } 
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
            Saldo = 0.0; 
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valorDepositado)
        {
            Saldo += valorDepositado;
        }

        public void Sacar(double valorSacado)
        {
            Saldo -= valorSacado + 5.0;
        }

        public override string ToString()
        {
            return "Conta " 
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
