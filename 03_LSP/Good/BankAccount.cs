namespace SolidNaPratica._03_LSP.Good;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; }
    public abstract void Withdraw(decimal amount);
}

public class CheckingAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine("Withdrawal from checking account.");
    }
}

public class SavingsAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Insufficient balance for withdrawal.");
            return;
        }

        Balance -= amount;
        Console.WriteLine("Withdrawal from savings account.");
    }
}
