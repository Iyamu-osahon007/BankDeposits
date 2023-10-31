using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits
{
    public partial class frmDeposit : Form
    {
        const decimal SURG_PERC = 0.99m;
        const decimal CHECK_PROCESS_FEE = 0.45m;
        decimal totalDeposit;
        int deposit_count;

        public frmDeposit()
        {
            InitializeComponent();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e)

        {
            try
            {
                string accountName = txtAccountHolder.Text;
                string accountNum = Convert.ToString(txtAccountNumber.Text);
                decimal cashAmount = Convert.ToDecimal(txtCashAmt.Text);
                decimal checkingAmt = Convert.ToDecimal(txtCheckAmt.Text);
                int numOfChecks = Convert.ToInt32(txtNumChecks.Text);
                decimal TRANACTION_FEE = 2.50m;
                decimal cashDptAfterSurg = cashAmount * SURG_PERC;
                decimal checkProcessFee = CHECK_PROCESS_FEE * numOfChecks;
               

                
                deposit_count++;



                if (numOfChecks >= 5)
                {

                    checkProcessFee = 0.35m * numOfChecks;
                }
                else
                {
                    checkProcessFee = CHECK_PROCESS_FEE * numOfChecks;
                }

             


                if (deposit_count > 2)
                {
                    TRANACTION_FEE = 0.00m;
                }
                else
                {
                    TRANACTION_FEE = 2.50m;
                }
               

                decimal netTotal = cashDptAfterSurg + checkingAmt - checkProcessFee - TRANACTION_FEE;
                   totalDeposit += netTotal;

                lblDepositSummary.Text = $"Deposit for {accountName} \r\nAccount #: {accountNum} \r\n \r\n" +
                    $"Cash Deposit (after Surcharge): {cashDptAfterSurg:c} " +
                    $"\r\nCheck Deposit: {checkingAmt:c} \r\n" +
                    $"Check Processing Fee:{checkProcessFee:c}\r\nTransaction Fee: {TRANACTION_FEE:c} \r\n \r\nNet Deposit: {netTotal:c} ";



                lblTotalDisplay.Text = $"Total Deposits for all accounts belonging {accountName} is {totalDeposit:c}";


                txtAccountHolder.Enabled = false;
                btnMakeDeposit.Enabled = false;
                btnNewAccount.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), default, MessageBoxIcon.Error );
            }

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = "";
            txtCashAmt.Text = "";
            txtCheckAmt.Text = "";
            txtNumChecks.Text = "";
            lblDepositSummary.Text = "";
            btnMakeDeposit.Enabled = true;
            txtAccountNumber.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)

        {
            string message = $"Thank you for completing {deposit_count} deposits with us\r\n" +
                $"Net Deposits were: {totalDeposit:c}.";

            string title = "Come back again soon!";

            MessageBox.Show(message, title);

            this.Close();

        }
    }
}
