namespace HerançaEPolimorfismo.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } //taxa de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number,holder,balance) 
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //usando a palavra "base" se reaproveita o método da superclasse.
            Balance -= 2.0;
        }

    }
}
