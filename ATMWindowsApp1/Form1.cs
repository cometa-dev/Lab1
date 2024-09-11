using System;
using System.Windows.Forms;
using ATMLibrary;

namespace ATMWindowsApp1
{
    public partial class Form1 : Form
    {
        private IATM _atm;

        public Form1()
        {
            InitializeComponent();
            _atm = new ATM();
            _atm.Notify += message => MessageBox.Show(message, "Message");

            // Add a test card
            ((ATM)_atm).AddCard(new Card { Number = "1234", PIN = "1234", Balance = 1000 });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_atm.Authenticate(txtCardNumber.Text, txtPIN.Text))
            {
                panelOperations.Visible = true;
                panelLogin.Visible = false;
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            _atm.CheckBalance();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                _atm.Withdraw(amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount", "Error");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                _atm.Deposit(amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount", "Error");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                _atm.Transfer(txtRecipientCard.Text, amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount", "Error");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var history = _atm.GetTransactionHistory(DateTime.Now.AddDays(-30), DateTime.Now);
            listBoxHistory.Items.Clear();
            foreach (var transaction in history)
            {
                listBoxHistory.Items.Add($"{transaction.Date}: {transaction.Description} - {transaction.Amount}");
            }
        }

        private void btnNearbyATMs_Click(object sender, EventArgs e)
        {
            var nearbyATMs = _atm.GetNearbyATMs();
            listBoxNearbyATMs.Items.Clear();
            foreach (var atm in nearbyATMs)
            {
                listBoxNearbyATMs.Items.Add(atm);
            }
        }
    }
}