using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar1D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setUSDFinalAmount()
        {
            txtTotalUSD.Text = Convert.ToString((Convert.ToDecimal(txtUSDRomania.Text) + Convert.ToDecimal(txtUSDZimbabwe.Text)))
                + (Convert.ToDecimal(txtUSDAngola.Text) + (Convert.ToDecimal(txtUSDUK.Text)));
        }
        private void romaniaTextChanged(object sender, EventArgs e)
        { 
            txtUSDRomania.Text = (Convert.ToDecimal(txtAmountRomania.Text) * Convert.ToDecimal(txtRateRomania.Text))
                .ToString("0.00");
                setUSDFinalAmount();
        }
    



        
        private void txtRateRomania_TextChanged(object sender, EventArgs e)
        {
            txtUSDRomania.Text = (0.243945m).ToString("0.00");
            setUSDFinalAmount();
        }

        private void zimbabweTextChanged(object sender, EventArgs e)
        {
            txtUSDZimbabwe.Text = (Convert.ToDecimal(txtAmountZimbabwe.Text) * Convert.ToDecimal(txtRateZimbabwe.Text))
                .ToString("0.00");
                setUSDFinalAmount();
        }

        private void txtRateZimbabwe_TextChanged(object sender, EventArgs e)
        {
            txtUSDZimbabwe.Text = (0.00276319m).ToString("0.00");
            setUSDFinalAmount();
        }
 
        private void angolaTextChanged(object sender, EventArgs e)
        {
            txtUSDAngola.Text = ((Convert.ToDecimal(txtAmountAngola.Text) *
                Convert.ToDecimal(txtRateAngola.Text))).ToString("0.00");
                setUSDFinalAmount();
        }

        private void txtRateAngola_TextChanged(object sender, EventArgs e)
        {
                txtUSDAngola.Text = (0.00162984m).ToString("0.00");
                setUSDFinalAmount();
        }

        private void ukTextChanged(object sender, EventArgs e)
        {
            txtUSDUK.Text = (Convert.ToDecimal(txtAmountUK.Text) * Convert.ToDecimal(txtRateUK.Text))
                .ToString("0.00");
                setUSDFinalAmount();
        }
        private void txtRateUK_TextChanged(object sender, EventArgs e)
        {
            txtUSDUK.Text = (1.32781m).ToString("0.00");
            setUSDFinalAmount();
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            setUSDFinalAmount();
     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountRomania.Text = "0.00";
            txtRateRomania.Text = "0.243945";
            txtAmountZimbabwe.Text = "0.00";
            txtRateZimbabwe.Text = "0.00276319";
            txtAmountAngola.Text = "0.00";
            txtRateAngola.Text = "0.00162984";
            txtAmountUK.Text = "0.00";
            txtRateUK.Text = "1.32781";
            

            
        }

        
            
        }
    }
}















  