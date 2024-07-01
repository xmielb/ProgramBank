using System;

public class BankAccount
{
    // Prywatne właściwości
    private string accountNumber;
    private decimal balance;

    // Konstruktor
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    // Metoda do pobierania numeru konta
    public string GetAccountNumber()
    {
        return accountNumber;
    }

    // Metoda do pobierania bieżącego salda
    public decimal GetBalance()
    {
        return balance;
    }

    // Metoda do dokonywania wpłat na konto
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

    // Metoda do dokonywania wypłat z konta (jeśli saldo jest wystarczające)
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
