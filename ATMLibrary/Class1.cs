using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMLibrary
{
    public class Card
    {
        public string Number { get; set; }
        public string Pin { get; set; }
        public Account Account { get; set; }
    }

    public class Account
    {
        public decimal Balance { get; private set; }
        public List<Transaction> Transactions { get; } = new List<Transaction>();

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction { Amount = amount, Type = TransactionType.Deposit, Date = DateTime.Now });
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transactions.Add(new Transaction { Amount = amount, Type = TransactionType.Withdrawal, Date = DateTime.Now });
                return true;
            }
            return false;
        }

        public List<Transaction> GetTransactionHistory(DateTime? startDate = null, DateTime? endDate = null)
        {
            return Transactions
                .Where(t => (!startDate.HasValue || t.Date >= startDate) && (!endDate.HasValue || t.Date <= endDate))
                .OrderByDescending(t => t.Date)
                .ToList();
        }
    }

    public class Transaction
    {
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer
    }

    public class ATM
    {
        private List<Card> cards = new List<Card>();
        public event EventHandler<string> OnMessage;
        public event EventHandler<Card> OnCardChanged;

        public delegate bool AuthenticationHandler(string cardNumber, string pin);
        public AuthenticationHandler Authenticate;

        public ATM()
        {
            // Ініціалізація тестових даних
            var account1 = new Account();
            account1.Deposit(1000);
            cards.Add(new Card { Number = "1234", Pin = "1111", Account = account1 });

            var account2 = new Account();
            account2.Deposit(500);
            cards.Add(new Card { Number = "5678", Pin = "2222", Account = account2 });

            // Ініціалізація делегата аутентифікації
            Authenticate = (cardNumber, pin) =>
            {
                var card = cards.Find(c => c.Number == cardNumber && c.Pin == pin);
                return card != null;
            };
        }

        public Card GetCard(string cardNumber)
        {
            return cards.Find(c => c.Number == cardNumber);
        }

        public bool Transfer(Card fromCard, string toCardNumber, decimal amount)
        {
            var toCard = GetCard(toCardNumber);
            if (toCard != null && fromCard.Account.Withdraw(amount))
            {
                toCard.Account.Deposit(amount);
                fromCard.Account.Transactions.Add(new Transaction { Amount = amount, Type = TransactionType.Transfer, Date = DateTime.Now });
                OnMessage?.Invoke(this, $"Transferred {amount} to card {toCardNumber}");
                return true;
            }
            OnMessage?.Invoke(this, "Transfer failed");
            return false;
        }

        public void ChangeCard(Card newCard)
        {
            OnCardChanged?.Invoke(this, newCard);
        }

        public List<string> GetNearbyATMs()
        {
            // Симуляція отримання списку найближчих банкоматів
            return new List<string>
            {
                "ATM1: Main Street, 123",
                "ATM2: Broadway, 456",
                "ATM3: Park Avenue, 789"
            };
        }
    }
}