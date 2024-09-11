using System;
using ATMLibrary;

namespace ATMConsoleApp
{
    class Program
    {
        static IATM _atm;

        static void Main(string[] args)
        {
            _atm = new ATM();
            _atm.Notify += message => Console.WriteLine($"Message: {message}");

            // Add a test card
            ((ATM)_atm).AddCard(new Card { Number = "1234", PIN = "1234", Balance = 1000 });

            bool isAuthenticated = false;
            while (true)
            {
                if (!isAuthenticated)
                {
                    Console.WriteLine("Enter card number:");
                    string cardNumber = Console.ReadLine();
                    Console.WriteLine("Enter PIN:");
                    string pin = Console.ReadLine();
                    isAuthenticated = _atm.Authenticate(cardNumber, pin);
                }
                else
                {
                    ShowMenu();
                    string choice = Console.ReadLine();
                    ProcessChoice(choice);
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw funds");
            Console.WriteLine("3. Deposit funds");
            Console.WriteLine("4. Transfer funds");
            Console.WriteLine("5. Transaction history");
            Console.WriteLine("6. Nearby ATMs");
            Console.WriteLine("7. Exit");
        }

        static void ProcessChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    _atm.CheckBalance();
                    break;
                case "2":
                    Console.WriteLine("Enter amount to withdraw:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        _atm.Withdraw(withdrawAmount);
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter amount to deposit:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        _atm.Deposit(depositAmount);
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter recipient's card number:");
                    string recipientCard = Console.ReadLine();
                    Console.WriteLine("Enter amount to transfer:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal transferAmount))
                    {
                        _atm.Transfer(recipientCard, transferAmount);
                    }
                    break;
                case "5":
                    var history = _atm.GetTransactionHistory(DateTime.Now.AddDays(-30), DateTime.Now);
                    foreach (var transaction in history)
                    {
                        Console.WriteLine($"{transaction.Date}: {transaction.Description} - {transaction.Amount}");
                    }
                    break;
                case "6":
                    var nearbyATMs = _atm.GetNearbyATMs();
                    foreach (var atm in nearbyATMs)
                    {
                        Console.WriteLine(atm);
                    }
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}