using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits
{
    public partial class frmDeposit : Form
    {
        const decimal SURG_PERC = 0.99m;
        const decimal CHECK_PROCESS_FEE = 0.45m;
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountHolder.Text;
            int accountNum = Convert.ToInt32(txtAccountNumber.Text);
            decimal cashAmount = Convert.ToDecimal(txtCashAmt.Text);
            decimal checkingAmt = Convert.ToDecimal(txtCheckAmt.Text);
            int numOfChecks = Convert.ToInt32(txtNumChecks.Text);
            decimal cashDptAfterSurg = cashAmount * SURG_PERC;
            decimal transactionProcess = CHECK_PROCESS_FEE * numOfChecks;


            if (numOfChecks >= 5)
            {

                 transactionProcess = 0.35m * numOfChecks;
            }
            else
            {
                transactionProcess = CHECK_PROCESS_FEE * numOfChecks;
            }



            lblDepositSummary.Text = $" Deposit for {accountName:c} \r\n Account #: {accountNum:c} \r\n \r\n" +
                $" Cash Deposit (after Surcharge):{cashDptAfterSurg:c} " +
                $"\r\n Check Deposit:{checkingAmt:c} \r\n" +
                $"Check Processing Fee:{transactionProcess:c} ";



        }
    }
}
