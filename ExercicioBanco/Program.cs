using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            Conta c = new Conta();

            if(opcao == 's')
            {
                Console.Write("Digite um valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numConta, titular, depositoInicial);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(c);
            }
            else
            {
                c = new Conta(numConta, titular);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(c);
            }

            Console.Write("Digite um valor para depósito:");
            double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valorDepositado);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite um valor para saque: ");
            double valorSacado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(valorSacado);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}
