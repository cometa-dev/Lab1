namespace ATMWindowsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.tabPageNearbyATMs = new System.Windows.Forms.TabPage();
            
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblPIN = new System.Windows.Forms.Label();
            
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btnNearbyATMs = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRecipientCard = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRecipientCard = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.listBoxNearbyATMs = new System.Windows.Forms.ListBox();
            
            this.tabControl.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.tabPageNearbyATMs.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            
            this.tabControl.Controls.Add(this.tabPageLogin);
            this.tabControl.Controls.Add(this.tabPageOperations);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Controls.Add(this.tabPageNearbyATMs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 361);
            this.tabControl.TabIndex = 0;
            
            // tabPageLogin
            this.tabPageLogin.Controls.Add(this.panelLogin);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(426, 335);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            
            // tabPageOperations
            this.tabPageOperations.Controls.Add(this.panelOperations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperations.Size = new System.Drawing.Size(426, 335);
            this.tabPageOperations.TabIndex = 1;
            this.tabPageOperations.Text = "Operations";
            this.tabPageOperations.UseVisualStyleBackColor = true;
            
            // tabPageHistory
            this.tabPageHistory.Controls.Add(this.listBoxHistory);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(426, 335);
            this.tabPageHistory.TabIndex = 2;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            
            // tabPageNearbyATMs
            this.tabPageNearbyATMs.Controls.Add(this.listBoxNearbyATMs);
            this.tabPageNearbyATMs.Location = new System.Drawing.Point(4, 22);
            this.tabPageNearbyATMs.Name = "tabPageNearbyATMs";
            this.tabPageNearbyATMs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNearbyATMs.Size = new System.Drawing.Size(426, 335);
            this.tabPageNearbyATMs.TabIndex = 3;
            this.tabPageNearbyATMs.Text = "Nearby ATM's";
            this.tabPageNearbyATMs.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPIN);
            this.panelLogin.Controls.Add(this.txtCardNumber);
            this.panelLogin.Controls.Add(this.lblCardNumber);
            this.panelLogin.Controls.Add(this.lblPIN);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(3, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(420, 329);
            this.panelLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(172, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(172, 126);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(100, 20);
            this.txtPIN.TabIndex = 1;
            
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(72, 103);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(94, 13);
            this.lblCardNumber.TabIndex = 3;
            this.lblCardNumber.Text = "Card Number:";
            
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(72, 129);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(32, 13);
            this.lblPIN.TabIndex = 4;
            this.lblPIN.Text = "PIN:";
            
            
            this.lblCardNumber.Location = new System.Drawing.Point(50, 80);
            this.lblCardNumber.Size = new System.Drawing.Size(100, 20);
            this.lblCardNumber.Text = "Card Number:";
            this.lblCardNumber.Visible = true;

            this.txtCardNumber.Location = new System.Drawing.Point(160, 80);

            this.lblAmount.Location = new System.Drawing.Point(50, 110);
            this.lblAmount.Size = new System.Drawing.Size(100, 20);
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Visible = true;

            this.txtAmount.Location = new System.Drawing.Point(160, 110);

            // Добавляем метки на панель операций
            this.panelOperations.Controls.Add(this.lblCardNumber);
            this.panelOperations.Controls.Add(this.lblAmount);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(172, 100);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCardNumber.TabIndex = 0;
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.btnNearbyATMs);
            this.panelOperations.Controls.Add(this.btnHistory);
            this.panelOperations.Controls.Add(this.btnTransfer);
            this.panelOperations.Controls.Add(this.btnDeposit);
            this.panelOperations.Controls.Add(this.btnWithdraw);
            this.panelOperations.Controls.Add(this.btnCheckBalance);
            this.panelOperations.Controls.Add(this.txtAmount);
            this.panelOperations.Controls.Add(this.txtRecipientCard);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperations.Location = new System.Drawing.Point(3, 3);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(420, 329);
            this.panelOperations.TabIndex = 1;
            // 
            // btnNearbyATMs
            // 
            this.btnNearbyATMs.Location = new System.Drawing.Point(215, 174);
            this.btnNearbyATMs.Name = "btnNearbyATMs";
            this.btnNearbyATMs.Size = new System.Drawing.Size(100, 30);
            this.btnNearbyATMs.TabIndex = 7;
            this.btnNearbyATMs.Text = "Nearby ATM's";
            this.btnNearbyATMs.UseVisualStyleBackColor = true;
            this.btnNearbyATMs.Click += new System.EventHandler(this.btnNearbyATMs_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(215, 138);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 30);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(215, 102);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 30);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(109, 174);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 30);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(109, 138);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 30);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(109, 102);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(100, 30);
            this.btnCheckBalance.TabIndex = 2;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(215, 42);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // txtRecipientCard
            // 
            this.txtRecipientCard.Location = new System.Drawing.Point(215, 68);
            this.txtRecipientCard.Name = "txtRecipientCard";
            this.txtRecipientCard.Size = new System.Drawing.Size(100, 20);
            this.txtRecipientCard.TabIndex = 0;
            
            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(106, 45);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Сумма:";
            
            
            // lblRecipientCard
            this.lblRecipientCard.AutoSize = true;
            this.lblRecipientCard.Location = new System.Drawing.Point(106, 71);
            this.lblRecipientCard.Name = "lblRecipientCard";
            this.lblRecipientCard.Size = new System.Drawing.Size(103, 13);
            this.lblRecipientCard.TabIndex = 9;
            this.lblRecipientCard.Text = "Карта получателя:";
            
            // lblBalance
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(106, 15);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(47, 13);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Баланс:";
            
            // listBoxHistory
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(3, 3);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(420, 329);
            this.listBoxHistory.TabIndex = 0;
            
            // listBoxNearbyATMs
            this.listBoxNearbyATMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNearbyATMs.FormattingEnabled = true;
            this.listBoxNearbyATMs.Location = new System.Drawing.Point(3, 3);
            this.listBoxNearbyATMs.Name = "listBoxNearbyATMs";
            this.listBoxNearbyATMs.Size = new System.Drawing.Size(420, 329);
            this.listBoxNearbyATMs.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "ATM";
            this.tabControl.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageOperations.ResumeLayout(false);
            this.tabPageHistory.ResumeLayout(false);
            this.tabPageNearbyATMs.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.panelOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageNearbyATMs;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btnNearbyATMs;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRecipientCard;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRecipientCard;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.ListBox listBoxNearbyATMs;
    }
}