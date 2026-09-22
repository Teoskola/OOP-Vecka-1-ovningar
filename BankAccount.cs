using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Vecka_1_Övningar
{
    internal class BankAccount
    {
        //Attributer 
        private decimal balance;

        //konstruktör
        public BankAccount(decimal initialBalance) //konstruktör som tar ett initialt saldo som parameter
        {
            balance = initialBalance;
            Console.WriteLine($"Your account has been created with an initial balance of {initialBalance}.");
        }

        //Metoder
        public virtual void Deposit(decimal amount) //metod för att sätta in pengar på kontot
        {
            Console.WriteLine($"{amount} has been deposited to your account. your new balance is {balance + amount}.");
                  balance += amount; // Uppdaterar saldot efter insättning    
        }

        public virtual void Withdraw(decimal amount) //metod för att ta ut pengar från kontot
        {
            Console.WriteLine($"{amount} has been withdrawn from your account. your new balance is {balance - amount}.");
            if (amount > balance) //kontrollerar om det finns tillräckligt med pengar på kontot
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
            else
            {
                balance -= amount; // Uppdaterar saldot efter uttag
            }
        }

    }
}
