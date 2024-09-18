using System;
using ATMLibrary;

class Program
{
    static ATM atm = new ATM();
    static Card currentCard = null;

    static void Main(string[] args)
    {
        atm.OnMessage += (sender, message) => Console.WriteLine(message);

        while (true)
        {
            if (currentCard == null)
            {
                Console.WriteLine("Enter card number:");
                string cardNumber = Console.ReadLine();
                Console.WriteLine("Enter PIN:");
                string pin = Console.ReadLine();

                if (atm.Authenticate(cardNumber, pin))
                {
                    currentCard = atm.GetCard(cardNumber);
                    Console.WriteLine("Authentication successful");
                }
                else
                {
                    Console.WriteLine("Authentication failed");
                    continue;
                }
            }

            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Current balance: {currentCard.Account.Balance}");
                    break;
                case "2":
                    WithdrawMoney();
                    break;
                case "3":
                    DepositMoney();
                    break;
                case "4":
                    TransferMoney();
                    break;
                case "5":
                    ShowTransactionHistory();
                    break;
                case "6":
                    currentCard = null;
                    Console.WriteLine("Logged out successfully");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Check balance");
        Console.WriteLine("2. Withdraw money");
        Console.WriteLine("3. Deposit money");
        Console.WriteLine("4. Transfer money");
        Console.WriteLine("5. Transaction history");
        Console.WriteLine("6. Change card");
        Console.WriteLine("7. Exit");
    }

    static void WithdrawMoney()
    {
        Console.WriteLine("Enter amount to withdraw:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (currentCard.Account.Withdraw(amount))
            {
                Console.WriteLine($"Withdrawn {amount}. New balance: {currentCard.Account.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }

    static void DepositMoney()
    {
        Console.WriteLine("Enter amount to deposit:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            currentCard.Account.Deposit(amount);
            Console.WriteLine($"Deposited {amount}. New balance: {currentCard.Account.Balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }

    static void TransferMoney()
    {
        Console.WriteLine("Enter recipient's card number:");
        string toCardNumber = Console.ReadLine();
        Console.WriteLine("Enter amount to transfer:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            atm.Transfer(currentCard, toCardNumber, amount);
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }

    static void ShowTransactionHistory()
    {
        foreach (var transaction in currentCard.Account.Transactions)
        {
            Console.WriteLine($"{transaction.Date}: {transaction.Type} - {transaction.Amount}");
        }
    }
}