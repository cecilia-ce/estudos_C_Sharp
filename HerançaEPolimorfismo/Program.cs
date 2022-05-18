using HerançaEPolimorfismo.Entities;

namespace HerançaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING >>> Conversão da subclasse para a superclasse

            Account acc1 = bacc; //isso é possível porque o bacc é uma account.
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1005, "Ana", 0.0, 0.01);

            //DOWNCASTING >>> Conversão de uma superclasse para uma subclasse. É uma operação insegura, só deve ser usado apenas quando for necessário e deve ser testado. 

            BusinessAccount acc4 = (BusinessAccount)acc2; //para que o compilador aceite a conversão, tem que fazer um cast, porque ele considera apenas o tipo da variável. 
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3; 
            // No comando acima o compilador não vai apresentar erro aqui, porém, ao executar vai dar um erro, porque                                              
            // embora acc3 tenha sido convertido para o tipo Account, seu conteúdo foi instanciado como
            // SavingsAccount que não é compatível com o BusinessAccount. 
            
            //Esse problema pode ser resolvido usando um if e um is:
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; //abaixo tem outra forma de fazer um casting
                BusinessAccount acc5 = acc3 as BusinessAccount;
            }
            else
            {
                System.Console.WriteLine("Não é possível converter!");
            }
            */

            //SOBREPOSIÇÃO -- Virtual e Override

            Account conta1 = new Account(1001, "Alex", 500.0);
            Account conta2 = new SavingsAccount(1002, "Ana", 500.0, 0.0);

            conta1.Withdraw(10.0);
            conta2.Withdraw(10.0);

            System.Console.WriteLine(conta1.Balance);
            System.Console.WriteLine(conta2.Balance);


        }
    }
}
