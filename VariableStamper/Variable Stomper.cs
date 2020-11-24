using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableStamper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // txtSteakSubTotal.Text = (
            // 1m * Convert.ToInt32(txtSteak.Text);
            // ).ToString("0.00");

            //Variable Steak
            int Steak = Convert.ToInt32(txtSteak.Text);
            decimal SteakPrice = 1.00m;
            decimal SteakSubtotal = Steak * SteakPrice;
            txtSteakSubTotal.Text = SteakSubtotal.ToString("0.00");


            // txtButterSubTotal.Text = (
            // 300m * Convert.ToDecimal(txtButter.Text)
            //).ToString("0.00");

            //Variable Butter
            int Butter = Convert.ToInt32(txtSteak.Text);
            decimal ButterPrice = 300.00m;
            decimal ButterSubtotal = Butter * ButterPrice;
            txtButterSubTotal.Text = ButterSubtotal.ToString("0.00");

            //txtPretaxTotal.Text = (
            //      Convert.ToDecimal(txtSteakSubTotal.Text) + Convert.ToDecimal(txtButterSubTotal.Text)
            //    ).ToString("0.00");
            decimal PreTaxTotal = SteakSubtotal + ButterSubtotal;
            txtPretaxTotal.Text = PreTaxTotal.ToString("0.00");

            //txtTax.Text = (6.875m * Convert.ToDecimal(txtPretaxTotal.Text) / 100m)
            //    .ToString("0.00");
            decimal tax = 6.875m * PreTaxTotal / 100;
            txtTax.Text = tax.ToString("0.00");

            //txtTotal.Text = Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //    .ToString("0.00");
            decimal total = PreTaxTotal + tax;
            txtTotal.Text = total.ToString("0.00");


             btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSteak.Text = "0";
            txtButter.Text = "0";
            txtSteakSubTotal.Text = "";
            txtButterSubTotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
