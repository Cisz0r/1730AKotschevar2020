using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar2B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void setUSDFinalAmount()
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

            private void calculate(object sender, EventArgs e)
        {
            decimal amountRomania = Convert.ToDecimal(txtAmountRomania.Text);
            decimal rateRomania = 0.243149m;
            decimal usdRomania = amountRomania * rateRomania;
            txtUSDRomania.Text = usdRomania.ToString("0.00");

            decimal amountUK = Convert.ToDecimal(txtAmountUK.Text);
            decimal rateUK = 1.29904m;
            decimal usdUK = amountUK * rateUK;
            txtUSDUK.Text = usdUK.ToString("0.00");

            decimal amountAngola = Convert.ToDecimal(txtAmountAngola.Text);
            decimal rateAngola = 0.00159843m;
            decimal usdAngola = amountAngola * rateAngola;
            txtUSDAngola.Text = usdAngola.ToString("0.00");

            decimal amountZimbabwe = Convert.ToDecimal(txtAmountZimbabwe.Text);
            decimal rateZimbabwe = 0.00276319m;
            decimal usdZimbabwe = amountZimbabwe * rateZimbabwe;
            txtUSDZimbabwe.Text = usdZimbabwe.ToString("0.00");

            
            
            decimal totalUSD = usdRomania + usdUK + usdAngola + usdZimbabwe;

                 txtUSDTotal.Text = totalUSD.ToString("0.00");





        }

        private void btnReset_Click(object sender, EventArgs e)

      {     txtAmountRomania.Text ="0.00";
            txtRateRomania.Text = ".243149";
            txtAmountZimbabwe.Text = "0.00";
            txtRateZimbabwe.Text = "0.00276319";
            txtAmountAngola.Text = "0.00";
            txtRateAngola.Text = "0.00159843";
            txtAmountUK.Text = "0.00";
            txtRateUK.Text = "1.29904";
        }

        private void txtUSDTotal_TextChanged(object sender, EventArgs e)
        {
        

        
        }
    }
}
