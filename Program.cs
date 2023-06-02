namespace Correction

{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnibankCard card = new UnibankCard("John Lennon", "84784727832", 786, 100);

            card.Deposit(500);
            card.Withdraw(100);
            Console.WriteLine($"The card balance is {card.Balance} USD.");

            AccessBankCard kart = new AccessBankCard("Shahin Azizov", "9898765421987", 987, 0);
            kart.Deposit(1000000);
            kart.Withdraw(999999);
            Console.WriteLine($"The card balance is {kart.Balance} USD.");

            LeoBankCard customer = new LeoBankCard("Arzu Yusifli", "986527219270", 24, 500);
            customer.Deposit(500);
            customer.Withdraw(100);
            Console.WriteLine($"The card balance is {customer.Balance} USD.");

            PashaBankCard milescard = new PashaBankCard("Bayim Azizli", "87654321098", 24, 40);
            milescard.Deposit(1000);
            milescard.Withdraw(100);
            Console.WriteLine($"The card balance is {milescard.Balance} USD.");
        }

    }

}
public abstract class SampleCardDetails
{
    public string FullName { get; private set; }
    public string CardNumber { get; private set; }
    public int CVV { get; private set; }
    public decimal Balance { get;  set; }
    public abstract void Withdraw(decimal amount);
    public abstract void Deposit(decimal amount);

    public SampleCardDetails(string fullname, string cardnumber, int cvv, decimal balance)
    {
        FullName = fullname;
        CardNumber = cardnumber;
        CVV = cvv;
        Balance = balance;
    }
}

internal class AccessBankCard : SampleCardDetails
{
    public AccessBankCard(string fullname, string cardnumber, int cvv, decimal balance) : base(fullname, cardnumber, cvv, balance)
    {

    }
    public override void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        amount *= 0.997m;
        Balance += amount;
    }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0) return;
        amount *= 1.016m;
        if (Balance < amount)
        {
            Console.WriteLine($"\nDear {FullName}, card balance is insufficient. Try with different amount.");
            return;
        }
        Balance -= amount;
    }
}


internal class PashaBankCard : SampleCardDetails
{
    public PashaBankCard(string fullname, string cardnumber, int cvv, decimal balance) : base(fullname, cardnumber, cvv, balance)
    {

    }
    public override void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        amount *= 0.994m;
        Balance += amount;
    }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0) return;
        amount *= 1.01m;
        if (Balance < amount)
        {
            Console.WriteLine($"\nDear {FullName}, card balance is insufficient. Try with different amount.");
            return;
        }
        Balance -= amount;
    }
}


internal class LeoBankCard : SampleCardDetails
{
    public LeoBankCard(string fullname, string cardnumber, int cvv, decimal balance) : base(fullname, cardnumber, cvv, balance)
    {

    }
    public override void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        Balance += amount;
    }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0) return;
        Balance -= amount;
        if (Balance < amount)
            Console.WriteLine($"\nDear {FullName}, card balance is insufficient. Try with different amount.");
    }
}

public class UnibankCard : SampleCardDetails
{
    public UnibankCard(string fullname, string cardnumber, int cvv, decimal balance) : base(fullname, cardnumber, cvv, balance)
    {

    }
    public override void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        Balance += amount;
    }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0) return;
        amount *= 1.015m;
        if (Balance < amount)
        {
            Console.WriteLine($"\nDear {FullName},card balance is insufficient. Try with different amount.");
            return;
        }
        Balance -= amount;
    }
}
