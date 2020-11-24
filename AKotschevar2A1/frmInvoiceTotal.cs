using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar2A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal Subtotal = Convert.ToDecimal(txtSubtotal.Text);
                decimal DiscountPercent = (30.0m);
            txtDiscountpercent.Text = DiscountPercent.ToString("0.00");
                decimal Discountamount = Subtotal * DiscountPercent / 100m;
            txtDiscountamount.Text = Discountamount.ToString("0.00");
            decimal Total = Subtotal - Discountamount;
                
                    txtTotal.Text = Total.ToString("0.00");
              
            
            


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Discountamount.Text =
        //   (Convert.ToDecimal(lblSubtotal.Text) *
        //     Convert.ToDecimal(lblDiscountpercent.Text) / 100).ToString("0.00");




        //Total.Text =
        //     (Convert.ToDecimal(lblSubtotal.Text) *
        //     Convert.ToDecimal(lblDiscountamount.Text)).ToString("0.00");


    }
    }
    
