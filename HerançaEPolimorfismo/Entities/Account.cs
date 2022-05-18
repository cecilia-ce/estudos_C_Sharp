﻿namespace HerançaEPolimorfismo.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }


        public virtual void Withdraw(double amount) //a palavra "virtual" indica que esse método pode ser sobrescrito nas subclasses.
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount; 
        }
    }
}
