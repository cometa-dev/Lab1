using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMLibrary
{
    public class Card
    {
        public string Number { get; set; }
        public string PIN { get; set; }
        public decimal Balance { get; set; }
    }

    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    public delegate void NotificationHandler(string message);

    public interface IATM
    {
        event NotificationHandler Notify;
        bool Authenticate(string cardNumber, string pin);
        decimal CheckBalance();
        List<Transaction> GetTransactionHistory(DateTime from, DateTime to);
        bool Withdraw(decimal amount);
        bool Deposit(decimal amount);
        bool Transfer(string toCardNumber, decimal amount);
        List<string> GetNearbyATMs();
    }

    public class ATM : IATM
    {
        private Card _currentCard;
        private List<Card> _cards;
        private List<Transaction> _transactions;

        public event NotificationHandler Notify;

        public ATM()
        {
            _cards = new List<Card>();
            _transactions = new List<Transaction>();
        }

        public bool Authenticate(string cardNumber, string pin)
        {
            _currentCard = _cards.FirstOrDefault(c => c.Number == cardNumber && c.PIN == pin);
            if (_currentCard != null)
            {
                OnNotify("Authentication successful");
                return true;
            }
            OnNotify("Authentication failed");
            return false;
        }

        public decimal CheckBalance()
        {
            if (_currentCard == null)
            {
                OnNotify("Please authenticate first");
                return 0;
            }
            OnNotify($"Balance: {_currentCard.Balance}");
            return _currentCard.Balance;
        }

        public List<Transaction> GetTransactionHistory(DateTime from, DateTime to)
        {
            if (_currentCard == null)
            {
                OnNotify("Please authenticate first");
                return new List<Transaction>();
            }
            var filteredTransactions = _transactions.Where(t => t.Date >= from && t.Date <= to).ToList();
            OnNotify($"Found {filteredTransactions.Count} transactions");
            return filteredTransactions;
        }

        public bool Withdraw(decimal amount)
        {
            if (_currentCard == null || _currentCard.Balance < amount)
            {
                OnNotify("Insufficient funds or authentication error");
                return false;
            }
            _currentCard.Balance -= amount;
            _transactions.Add(new Transaction { Date = DateTime.Now, Description = "Cash withdrawal", Amount = -amount });
            OnNotify($"Withdrawn {amount}. New balance: {_currentCard.Balance}");
            return true;
        }

        public bool Deposit(decimal amount)
        {
            if (_currentCard == null)
            {
                OnNotify("Please authenticate first");
                return false;
            }
            _currentCard.Balance += amount;
            _transactions.Add(new Transaction { Date = DateTime.Now, Description = "Deposit", Amount = amount });
            OnNotify($"Deposited {amount}. New balance: {_currentCard.Balance}");
            return true;
        }

        public bool Transfer(string toCardNumber, decimal amount)
        {
            if (_currentCard == null || _currentCard.Balance < amount)
            {
                OnNotify("Insufficient funds or authentication error");
                return false;
            }
            var recipientCard = _cards.FirstOrDefault(c => c.Number == toCardNumber);
            if (recipientCard == null)
            {
                OnNotify("Recipient card not found");
                return false;
            }
            _currentCard.Balance -= amount;
            recipientCard.Balance += amount;
            _transactions.Add(new Transaction { Date = DateTime.Now, Description = $"Transfer to card {toCardNumber}", Amount = -amount });
            OnNotify($"Transferred {amount} to card {toCardNumber}. New balance: {_currentCard.Balance}");
            return true;
        }

        public List<string> GetNearbyATMs()
        {
            // This is a stub. In a real application, there would be logic to get a list of nearby ATMs
            return new List<string> { "ATM1: 1 Central St.", "ATM2: 5 Park Ave.", "ATM3: 10 Main St." };
        }

        protected virtual void OnNotify(string message)
        {
            Notify?.Invoke(message);
        }

        // Method for adding cards (for demonstration purposes)
        public void AddCard(Card card)
        {
            _cards.Add(card);
        }
    }
}