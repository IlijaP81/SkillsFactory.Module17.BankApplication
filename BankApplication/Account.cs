namespace BankApplication;

abstract public class Account : ICalculator
{
    // тип учетной записи
    public string Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }

    public Account(string type, double balance, double interest)
    {
        Type = type;
        Balance = balance;
        Interest = interest;
    }

    void ICalculator.CalculateInterest(Account account) { }
}

public class OrdinaryAccount : Account
{
    public OrdinaryAccount(string type, double balance, double interest) : base(type, balance, interest) { }

    /// <summary>
    /// Расчет процентной ставки обычного аккаунта по правилам банка
    /// </summary>
    /// <param name="account"></param>
    public static void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.4;
        if (account.Balance < 1000) account.Interest -= account.Balance * 0.2;
        else account.Interest -= account.Balance * 0.4;
        Console.WriteLine($"Размер процентов для типа счета {account.Type} " +
                          $"при балансе {account.Balance} руб. составляет {account.Interest} рублей");
    }
}

public class SalaryAccount : Account
{
    public SalaryAccount(string type, double balance, double interest) : base(type, balance, interest) { }

    /// <summary>
    /// Расчет процентной ставк зарплатного аккаунта по правилам банка
    /// </summary>
    /// <param name="account"></param>
    public static void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.5;
        Console.WriteLine($"Размер процентов для типа счета {account.Type} " +
                          $"при балансе {account.Balance} руб. составляет {account.Interest} рублей");
    }
}