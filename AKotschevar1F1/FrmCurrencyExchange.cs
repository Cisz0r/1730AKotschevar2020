using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar1F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRomania.BackgroundImage = picRomania.Image;
            txtRate.Text = "0.243840";
            lblCurrency.Text = "Romania Currency:";     
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
           

            btnUK.BackgroundImage = picUKDIM.Image;
            txtRate.Text = "1.28847";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            

            btnAngola.BackgroundImage = picAngolaDIM.Image;
            txtRate.Text = "0.00159533";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
           


            btnZimbabwe.BackgroundImage = picZimbabweDIM.Image;
            txtRate.Text = "0.00276319";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
           

        }

        private void btnRomania_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Romania Currency:";
            btnRomania.BackgroundImage = picRomania.Image;
            btnUK.BackgroundImage = picUKDIM.Image;
            btnAngola.BackgroundImage = picAngolaDIM.Image;
            btnZimbabwe.BackgroundImage = picZimbabweDIM.Image;
            txtRate.Text = "0.243840";
        }

        private void btnUK_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "UK Currency:";
            btnUK.BackgroundImage = picUK.Image;
            btnRomania.BackgroundImage = picRomaniaDIM.Image;
            btnAngola.BackgroundImage = picAngolaDIM.Image;
            btnZimbabwe.BackgroundImage = picZimbabweDIM.Image;
            txtRate.Text = "1.28847";
            
        }

        private void btnAngola_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Angola Currency:";
            btnAngola.BackgroundImage = picAngola.Image;
            btnRomania.BackgroundImage = picRomaniaDIM.Image;
            btnZimbabwe.BackgroundImage = picZimbabweDIM.Image;
            btnUK.BackgroundImage = picUKDIM.Image;
            txtRate.Text = "0.00159520";

        }

        private void btnZimbabwe_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Zimbabwe Currency:";
            btnZimbabwe.BackgroundImage = picZimbabwe.Image;
            btnAngola.BackgroundImage = picAngolaDIM.Image;
            btnRomania.BackgroundImage = picRomaniaDIM.Image;
            btnUK.BackgroundImage = picUKDIM.Image;
            txtRate.Text = "0.00276319";


        }

        private void calcUSD(object sender, EventArgs e)
        {
            //Convert
            txtUSDollars.Text = Convert.ToString(Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text));
            
        }

        

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            
            txtTotalUSD.Text = Convert.ToString (Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text));
        }

        private void txtUSDollars_TextChanged(object sender, EventArgs e)
        {
            //txtTotalUSD.Text = (0.00m).ToString("0.00");
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            Convert.ToString(Convert.ToDecimal(txtTotalUSD.Text));
        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {
            btnZimbabwe.BackgroundImage = picZimbabwe.Image;
            btnAngola.BackgroundImage = picAngolaDIM.Image;
            btnRomania.BackgroundImage = picRomaniaDIM.Image;
            btnUK.BackgroundImage = picUKDIM.Image;

           

        }

        private void labelEquation_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



