namespace SolidNaPratica._03_LSP.Bad;

public class BankAccount
{
    public virtual void Withdraw(decimal amount)
    {
        // Logic to withdraw money
        Console.WriteLine("Withdrawal from bank account.");
    }
}

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient balance for withdrawal.");
        }

        Balance -= amount;
        Console.WriteLine("Withdrawal from savings account.");
    }
}