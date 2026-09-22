using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Vecka_1_Övningar
{
    internal class SavingsAccount : BankAccount
    {
        //Attributer
        private decimal SavingsBalance; //privat attribut för att hålla reda på saldot på sparkontot

        //Konstruktör
        public SavingsAccount(decimal initialBalance) : base(initialBalance) //konstruktör som tar ett initialt saldo som parameter och anropar basklassens konstruktör
        {
            Console.WriteLine($"Your savings account has been created with an initial balance of {initialBalance}.");


        }
        //Metoder
        public override void Deposit(decimal amount) //metod för att sätta in pengar på kontot
        {
            Console.WriteLine($"{amount} has been deposited to your savings account. your new balance is {SavingsBalance + amount}.");
            SavingsBalance += amount; // Uppdaterar saldot efter insättning    
        }

        public override void Withdraw(decimal amount) //metod för att ta ut pengar från kontot
        {
            Console.WriteLine($"{amount} has been withdrawn from your savings account. your new balance is {SavingsBalance - amount}.");
            if (amount > SavingsBalance) //kontrollerar om det finns tillräckligt med pengar på kontot
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
            else
            {
                SavingsBalance -= amount; // Uppdaterar saldot efter uttag
            }
        }

    }
}
