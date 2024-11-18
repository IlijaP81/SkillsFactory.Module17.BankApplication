using BankApplication;

class Program
{
    public static void Main(string[] args)
    {
        OrdinaryAccount.CalculateInterest(new OrdinaryAccount("Обычный", 999, 0));
        OrdinaryAccount.CalculateInterest(new OrdinaryAccount("Обычный", 1001, 0));
        SalaryAccount.CalculateInterest(new SalaryAccount("Зарплатный", 500, 0));
    }
}
