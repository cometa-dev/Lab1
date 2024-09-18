namespace ATMWindowsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();

            this.panelMain = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnNearbyATMs = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtToCard = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblToCard = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // panelLogin
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPin);
            this.panelLogin.Controls.Add(this.txtCardNumber);
            this.panelLogin.Controls.Add(this.lblPin);
            this.panelLogin.Controls.Add(this.lblCardNumber);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(300, 150);
            this.panelLogin.TabIndex = 0;

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(100, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // txtPin
            this.txtPin.Location = new System.Drawing.Point(100, 60);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 1;

            // txtCardNumber
            this.txtCardNumber.Location = new System.Drawing.Point(100, 20);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCardNumber.TabIndex = 0;

            // lblPin
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(20, 63);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(28, 13);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "PIN:";

            // lblCardNumber
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(20, 23);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number:";

            // panelMain
            this.panelMain.Controls.Add(this.lblBalance);
            this.panelMain.Controls.Add(this.btnWithdraw);
            this.panelMain.Controls.Add(this.btnDeposit);
            this.panelMain.Controls.Add(this.btnTransfer);
            this.panelMain.Controls.Add(this.btnHistory);
            this.panelMain.Controls.Add(this.btnChangeCard);
            this.panelMain.Controls.Add(this.btnNearbyATMs);
            this.panelMain.Controls.Add(this.txtAmount);
            this.panelMain.Controls.Add(this.txtToCard);
            this.panelMain.Controls.Add(this.lblAmount);
            this.panelMain.Controls.Add(this.lblToCard);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(300, 300);
            this.panelMain.TabIndex = 1;
            this.panelMain.Visible = false;

            // lblBalance
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(20, 20);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance: ";

            // btnWithdraw
            this.btnWithdraw.Location = new System.Drawing.Point(20, 50);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 30);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            // btnDeposit
            this.btnDeposit.Location = new System.Drawing.Point(180, 50);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 30);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // btnTransfer
            this.btnTransfer.Location = new System.Drawing.Point(20, 90);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 30);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);

            // btnHistory
            this.btnHistory.Location = new System.Drawing.Point(180, 90);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 30);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);

            // btnChangeCard
            this.btnChangeCard.Location = new System.Drawing.Point(20, 130);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(100, 30);
            this.btnChangeCard.TabIndex = 5;
            this.btnChangeCard.Text = "Change Card";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);

            // btnNearbyATMs
            this.btnNearbyATMs.Location = new System.Drawing.Point(180, 130);
            this.btnNearbyATMs.Name = "btnNearbyATMs";
            this.btnNearbyATMs.Size = new System.Drawing.Size(100, 30);
            this.btnNearbyATMs.TabIndex = 6;
            this.btnNearbyATMs.Text = "Nearby ATMs";
            this.btnNearbyATMs.UseVisualStyleBackColor = true;
            this.btnNearbyATMs.Click += new System.EventHandler(this.btnNearbyATMs_Click);

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(100, 180);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 7;

            // txtToCard
            this.txtToCard.Location = new System.Drawing.Point(100, 210);
            this.txtToCard.Name = "txtToCard";
            this.txtToCard.Size = new System.Drawing.Size(100, 20);
            this.txtToCard.TabIndex = 8;

            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 183);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount:";

            // lblToCard
            this.lblToCard.AutoSize = true;
            this.lblToCard.Location = new System.Drawing.Point(20, 213);
            this.lblToCard.Name = "lblToCard";
            this.lblToCard.Size = new System.Drawing.Size(48, 13);
            this.lblToCard.TabIndex = 10;
            this.lblToCard.Text = "To Card:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 321);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "ATM";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblCardNumber;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnNearbyATMs;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtToCard;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblToCard;
    }
}