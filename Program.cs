using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount("123456789", 1000.00m);
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Sprawdź numer konta");
            Console.WriteLine("2. Sprawdź saldo");
            Console.WriteLine("3. Wpłać środki");
            Console.WriteLine("4. Wypłać środki");
            Console.WriteLine("5. Wyjdź");
            Console.Write("Twój wybór: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Numer konta: {myAccount.GetAccountNumber()}");
                    break;
                case "2":
                    Console.WriteLine($"Bieżące saldo: {myAccount.GetBalance():C}");
                    break;
                case "3":
                    Console.Write("Podaj kwotę do wpłaty: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        myAccount.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa kwota.");
                    }
                    break;
                case "4":
                    Console.Write("Podaj kwotę do wypłaty: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        myAccount.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa kwota.");
                    }
                    break;
                case "5":
                    running = false;
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
