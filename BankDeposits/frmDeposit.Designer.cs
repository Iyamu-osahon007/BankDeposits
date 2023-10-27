namespace BankDeposits
{
    partial class frmDeposit
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
            label1 = new Label();
            txtAccountHolder = new TextBox();
            grpDepositInfo = new GroupBox();
            txtNumChecks = new TextBox();
            label5 = new Label();
            txtCheckAmt = new TextBox();
            label4 = new Label();
            txtCashAmt = new TextBox();
            label3 = new Label();
            txtAccountNumber = new TextBox();
            label2 = new Label();
            btnMakeDeposit = new Button();
            btnNewAccount = new Button();
            lblDepositSummary = new Label();
            label7 = new Label();
            lblTotalDisplay = new Label();
            btnExit = new Button();
            grpDepositInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 0;
            label1.Text = "Account Holder";
            // 
            // txtAccountHolder
            // 
            txtAccountHolder.Location = new Point(62, 57);
            txtAccountHolder.Margin = new Padding(4, 3, 4, 3);
            txtAccountHolder.Name = "txtAccountHolder";
            txtAccountHolder.Size = new Size(344, 23);
            txtAccountHolder.TabIndex = 1;
            // 
            // grpDepositInfo
            // 
            grpDepositInfo.Controls.Add(txtNumChecks);
            grpDepositInfo.Controls.Add(label5);
            grpDepositInfo.Controls.Add(txtCheckAmt);
            grpDepositInfo.Controls.Add(label4);
            grpDepositInfo.Controls.Add(txtCashAmt);
            grpDepositInfo.Controls.Add(label3);
            grpDepositInfo.Controls.Add(txtAccountNumber);
            grpDepositInfo.Controls.Add(label2);
            grpDepositInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpDepositInfo.Location = new Point(62, 87);
            grpDepositInfo.Margin = new Padding(4, 3, 4, 3);
            grpDepositInfo.Name = "grpDepositInfo";
            grpDepositInfo.Padding = new Padding(4, 3, 4, 3);
            grpDepositInfo.Size = new Size(344, 175);
            grpDepositInfo.TabIndex = 2;
            grpDepositInfo.TabStop = false;
            grpDepositInfo.Text = "Deposit Information";
            // 
            // txtNumChecks
            // 
            txtNumChecks.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumChecks.Location = new Point(130, 129);
            txtNumChecks.Margin = new Padding(4, 3, 4, 3);
            txtNumChecks.Name = "txtNumChecks";
            txtNumChecks.Size = new Size(173, 20);
            txtNumChecks.TabIndex = 9;
            txtNumChecks.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(43, 129);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 13);
            label5.TabIndex = 8;
            label5.Text = "# of Checks:";
            // 
            // txtCheckAmt
            // 
            txtCheckAmt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCheckAmt.Location = new Point(130, 99);
            txtCheckAmt.Margin = new Padding(4, 3, 4, 3);
            txtCheckAmt.Name = "txtCheckAmt";
            txtCheckAmt.Size = new Size(173, 20);
            txtCheckAmt.TabIndex = 7;
            txtCheckAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(33, 99);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 13);
            label4.TabIndex = 6;
            label4.Text = "Total Check $:";
            // 
            // txtCashAmt
            // 
            txtCashAmt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCashAmt.Location = new Point(130, 69);
            txtCashAmt.Margin = new Padding(4, 3, 4, 3);
            txtCashAmt.Name = "txtCashAmt";
            txtCashAmt.Size = new Size(173, 20);
            txtCashAmt.TabIndex = 5;
            txtCashAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(41, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 13);
            label3.TabIndex = 4;
            label3.Text = "Total Cash $:";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccountNumber.Location = new Point(130, 39);
            txtAccountNumber.Margin = new Padding(4, 3, 4, 3);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(173, 20);
            txtAccountNumber.TabIndex = 3;
            txtAccountNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(52, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 13);
            label2.TabIndex = 0;
            label2.Text = "Account #:";
            // 
            // btnMakeDeposit
            // 
            btnMakeDeposit.BackColor = Color.Green;
            btnMakeDeposit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMakeDeposit.ForeColor = Color.White;
            btnMakeDeposit.Location = new Point(237, 269);
            btnMakeDeposit.Margin = new Padding(4, 3, 4, 3);
            btnMakeDeposit.Name = "btnMakeDeposit";
            btnMakeDeposit.Size = new Size(169, 43);
            btnMakeDeposit.TabIndex = 3;
            btnMakeDeposit.Text = "Make &Deposit";
            btnMakeDeposit.UseVisualStyleBackColor = false;
            btnMakeDeposit.Click += btnMakeDeposit_Click;
            // 
            // btnNewAccount
            // 
            btnNewAccount.Enabled = false;
            btnNewAccount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewAccount.Location = new Point(62, 269);
            btnNewAccount.Margin = new Padding(4, 3, 4, 3);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(169, 43);
            btnNewAccount.TabIndex = 4;
            btnNewAccount.Text = "New Account";
            btnNewAccount.UseVisualStyleBackColor = true;
            // 
            // lblDepositSummary
            // 
            lblDepositSummary.BorderStyle = BorderStyle.Fixed3D;
            lblDepositSummary.Location = new Point(432, 87);
            lblDepositSummary.Margin = new Padding(4, 0, 4, 0);
            lblDepositSummary.Name = "lblDepositSummary";
            lblDepositSummary.Size = new Size(300, 225);
            lblDepositSummary.TabIndex = 5;
            lblDepositSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(428, 57);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 17);
            label7.TabIndex = 6;
            label7.Text = "Deposit Summary";
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblTotalDisplay.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalDisplay.Location = new Point(62, 327);
            lblTotalDisplay.Margin = new Padding(4, 0, 4, 0);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(670, 35);
            lblTotalDisplay.TabIndex = 7;
            lblTotalDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkRed;
            btnExit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(646, 368);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 43);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 425);
            Controls.Add(btnExit);
            Controls.Add(lblTotalDisplay);
            Controls.Add(label7);
            Controls.Add(lblDepositSummary);
            Controls.Add(btnNewAccount);
            Controls.Add(btnMakeDeposit);
            Controls.Add(grpDepositInfo);
            Controls.Add(txtAccountHolder);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Make a Deposit";
            grpDepositInfo.ResumeLayout(false);
            grpDepositInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccountHolder;
        private GroupBox grpDepositInfo;
        private TextBox txtNumChecks;
        private Label label5;
        private TextBox txtCheckAmt;
        private Label label4;
        private TextBox txtCashAmt;
        private Label label3;
        private TextBox txtAccountNumber;
        private Label label2;
        private Button btnMakeDeposit;
        private Button btnNewAccount;
        private Label lblDepositSummary;
        private Label label7;
        private Label lblTotalDisplay;
        private Button btnExit;
    }
}

