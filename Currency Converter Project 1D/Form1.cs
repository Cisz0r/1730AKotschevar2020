using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_Project_1D
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void setUSDFinalAmount()
        {
            string v1 = Convert.ToString(Convert.ToDecimal(txtUSDRomania.Text) + Convert.ToDecimal(txtUSDUK.Text)
                       + (Convert.ToDecimal(txtUSDAngola.Text) + Convert.ToDecimal(txtUSDZimbabwe.Text)));
            string v = v1;
            txtUSDTotal.Text = v;
        }

        private void RomanianTextChanged(object sender, EventArgs e)
        {
            txtUSDRomania.Text = (Convert.ToDecimal(txtAmountRomanian.Text) * Convert.ToDecimal(txtRateRomanian.Text))
                .ToString("0.00");
            setUSDFinalAmount();
        }

        private void UKTextChanged(object sender, EventArgs e)
        {
            txtUSDUK.Text = (Convert.ToDecimal(txtAmountUK.Text) * Convert.ToDecimal(txtRateUK.Text))
                .ToString("0.00");
            setUSDFinalAmount();
        }

        private void AngolaTextChanged(object sender, EventArgs e)
        {
            txtUSDAngola.Text = ((Convert.ToDecimal(txtAmountAngola.Text) *
               Convert.ToDecimal(txtRateAngola.Text))).ToString("0.00");
            setUSDFinalAmount();
        }

        private void ZimbabweTextChanged(object sender, EventArgs e)
        {
            txtUSDZimbabwe.Text = ((Convert.ToDecimal(txtAmountZimbabwe.Text) * Convert.ToDecimal(txtRateZimbabwe.Text)))
           .ToString("0.00");
            setUSDFinalAmount();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountRomanian.Text = "0.00";
            txtRateRomanian.Text = ".243945";
            txtAmountZimbabwe.Text = "0.00";
            txtRateZimbabwe.Text = ".00276319";
            txtAmountAngola.Text = "0.00";
            txtRateAngola.Text = ".00162984";
            txtAmountUK.Text = "0.00";
            txtRateUK.Text = "1.32781";

        }

        private void txtTotalUSD(object sender, EventArgs e)
        {
            string v1 = Convert.ToString(Convert.ToDecimal(txtUSDRomania.Text) + Convert.ToDecimal(txtUSDUK.Text)
                       + (Convert.ToDecimal(txtUSDAngola.Text) + Convert.ToDecimal(txtUSDZimbabwe.Text)));
            string v = v1;
            txtUSDTotal.Text = v;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCurrencyConverter_Load(object sender, EventArgs e)
        {

        }
    }
    }

           
    
    
   




