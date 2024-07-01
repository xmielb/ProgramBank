using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }
    public string GetAccountNumber()
    {
        return accountNumber;
    }
    public decimal GetBalance()
    {
        return balance;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Wpłacono {amount:C}. Nowe saldo: {balance:C}");
        }
        else
        {
            Console.WriteLine("Kwota wpłaty musi być większa niż zero.");
        }
    }
    public bool Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Wypłacono {amount:C}. Nowe saldo: {balance:C}");
                return true;
            }
            else
            {
                Console.WriteLine("Niewystarczające środki na koncie.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Kwota wypłaty musi być większa niż zero.");
            return false;
        }
    }
}
