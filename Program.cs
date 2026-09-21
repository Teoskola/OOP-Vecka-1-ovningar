namespace OOP_Vecka_1_Övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar ett objekt av klassen BankAccount och använder dess metoder
            BankAccount account1 = new BankAccount(100); // Skapar ett nytt bankkonto med ett initialt saldo på 100
            
            account1.Deposit(500); // Sätter in 500 på kontot
            account1.Withdraw(200); // Tar ut 200 från kontot

        }
    }
}
