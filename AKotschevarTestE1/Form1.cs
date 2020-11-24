using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevarTestE1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTextBox1.Text = ("");
            txtTextBox2.Text = ("");
            txtTextBox3.Text = ("");
            txtAverageBox.Text = ("");




        }

        private void txtTextBox1_TextChanged(object sender, EventArgs e)
        {
            txtTextBox1.Text.ToString();
        }

        private void txtTextBox2_TextChanged(object sender, EventArgs e)
        {
            txtTextBox2.Text.ToString();
        }

        private void txtTextBox3_TextChanged(object sender, EventArgs e)
        {
            txtTextBox3.Text.ToString();
        }
        
        private void txtAverageBox_TextChanged(object sender, EventArgs e)
        {
            //txtAverageBox.Text = Convert.ToString((Convert.ToDecimal(txtTextBox1.Text) 
            //+ Convert.ToDecimal(txtTextBox2.Text) + Convert.ToDecimal(txtTextBox3.Text)) / 3);??
        }

        private void btnCalculate_Click(object sender, EventArgs e)
            //to here
        {
            decimal sumValue;
            decimal averageValue;
            sumValue = Convert.ToDecimal(txtTextBox1.Text) + Convert.ToDecimal(txtTextBox2.Text) 
                + Convert.ToDecimal(txtTextBox3.Text);
            
            
            averageValue = sumValue / 3;
            txtAverageBox.Text = averageValue.ToString(); 

            
            txtAverageBox.Text = Convert.ToString((Convert.ToDecimal(txtTextBox1.Text) + Convert.ToDecimal(txtTextBox2.Text)
                + Convert.ToDecimal(txtTextBox3.Text)) / 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
    

