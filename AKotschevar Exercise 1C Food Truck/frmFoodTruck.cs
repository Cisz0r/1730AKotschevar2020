using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar_Exercise_1C_Food_Truck
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtSteakSubTotal.Text = (
                    1m * Convert.ToDecimal(txtSteak.Text)
                 ).ToString("0.00");
            txtButterSubTotal.Text = (
                    300m * Convert.ToDecimal(txtButter.Text)
                ).ToString("0.00");

            txtPretaxTotal.Text = (
                  Convert.ToDecimal(txtSteakSubTotal.Text) + Convert.ToDecimal(txtButterSubTotal.Text)
                ).ToString("0.00");

            txtTaxTotal.Text = (6.875m * Convert.ToDecimal(txtPretaxTotal.Text) / 100m)
                .ToString("0.00");
            txtTotal.Text = (Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTaxTotal.Text)
                .ToString("0.00"));


            btnClear.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSteak.Text = "0";
            txtButter.Text = "0";
            txtSteakSubTotal.Text = "";
            txtButterSubTotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTaxTotal.Text = "";
            txtTotal.Text = "";

        }
    }
}


                    
                    
                    
                
            
        
    
    
    



