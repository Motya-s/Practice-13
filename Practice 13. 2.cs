using System;

public class BankAccount
{
    private int number;
    private string name;
    private double price;
    public int Number { get { return number; } set { number = value; } }
    public string Name { get { return name; } set { name = value; } }
    public double Price { get { return price; } set { price = value; } }
}
public class ChekingAccount : BankAccount
{
    private double Overdraft { get; set; }

    public void Overdraft_facility(double Overdraft)
    {
        Console.WriteLine($"Ваш лимит овердрафта {Overdraft}");
    }
}
public class SevingsAccount : BankAccount
{
    private int Percent { get; set; }
    public void Interest_rate(int Percent)
    {
        Console.WriteLine($"Ваша процентная ставка состовляет {Percent}%");
    }
}
public class CreditAccount : BankAccount
{
    private double Credit { get; set; }
    private DateTime Data { get; set; }
    public void Loan_repayment(double Credit, DateTime Data)
    {
        Console.WriteLine($"Ваш долг по кредиту состовляет {Credit}, Вы должны выплатить его до: {Data}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ChekingAccount chekingAccount = new ChekingAccount();
        chekingAccount.Overdraft_facility(1000);
        SevingsAccount sevingsAccount = new SevingsAccount();
        sevingsAccount.Interest_rate(12);
        CreditAccount creditAccount = new CreditAccount();
        creditAccount.Loan_repayment(15000, DateTime.Today);
    }
}