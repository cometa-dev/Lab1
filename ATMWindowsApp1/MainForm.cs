using System;
using System.Windows.Forms;
using ATMLibrary;

namespace ATMWindowsApp1
{
    public partial class MainForm : Form
    {
        private ATM atm;
        private Card currentCard;

        public MainForm()
        {
            InitializeComponent();
            atm = new ATM();
            atm.OnMessage += Atm_OnMessage;
        }

        private void Atm_OnMessage(object sender, string e)
        {
            MessageBox.Show(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (atm.Authenticate(txtCardNumber.Text, txtPin.Text))
            {
                currentCard = atm.GetCard(txtCardNumber.Text);
                ShowMainPanel();
            }
            else
            {
                MessageBox.Show("Authentication failed");
            }
        }

        private void ShowMainPanel()
        {
            panelLogin.Visible = false;
            panelMain.Visible = true;
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            lblBalance.Text = $"Balance: {currentCard.Account.Balance}";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                if (currentCard.Account.Withdraw(amount))
                {
                    MessageBox.Show($"Withdrawn {amount}");
                    UpdateBalance();
                }
                else
                {
                    MessageBox.Show("Insufficient funds");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                currentCard.Account.Deposit(amount);
                MessageBox.Show($"Deposited {amount}");
                UpdateBalance();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                string toCardNumber = txtToCard.Text;
                atm.Transfer(currentCard, toCardNumber, amount);
                UpdateBalance();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string history = "";
            foreach (var transaction in currentCard.Account.GetTransactionHistory())
            {
                history += $"{transaction.Date}: {transaction.Type} - {transaction.Amount}\n";
            }
            MessageBox.Show(history, "Transaction History");
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            currentCard = null;
            panelMain.Visible = false;
            panelLogin.Visible = true;
        }

        private void btnNearbyATMs_Click(object sender, EventArgs e)
        {
            var nearbyATMs = atm.GetNearbyATMs();
            MessageBox.Show(string.Join("\n", nearbyATMs), "Nearby ATMs");
        }
    }
}