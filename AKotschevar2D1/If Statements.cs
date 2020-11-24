using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar2D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Alex";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";

        }

        private void setFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Korryn";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";


            if (textBox1Input.Text == "Alex")
                textBox1ResultA.Text = "Success";
            if (textBox1Input.Text != "Alex")
                textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";
            if (val4 == true)
                textBox4ResultB.Text = "Fail";

            //This Seems Wrong (>_<)
            decimal val5 = Convert.ToDecimal(textBox5InputA.Text);
            if (val5 == 2m)
                textBox5ResultA.Text = "Fail";
            if (val5 != 2m)
                textBox5ResultB.Text = "Fail";
            decimal val6 = Convert.ToDecimal(textBox5InputB.Text);
            if (val6 == 2m)
                textBox5ResultA.Text = "Success";
            if (val6 != 2m)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text == "xyz")
                textBox6ResultA.Text = "Success";
            if (textBox6Input.Text != "xyz")
                textBox6ResultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 == 1m)
                textBox7ResultA.Text = "Success";
            if (val7 != 1m)
                textBox7ResultB.Text = "Fail";

            decimal val8 = Convert.ToDecimal(textBox8InputA.Text);
            if (val8 == 1m)
                textBox8ResultA.Text = "Success";
            if (val8 != 2m)
                textBox8ResultB.Text = "Fail";
            decimal val9 = Convert.ToDecimal(textBox8InputB.Text);
            if (val9 == 1m)
                textBox8ResultA.Text = "Fail";
            if (val9 != 1m)
                textBox8ResultB.Text = "Success";

            decimal val10 = Convert.ToDecimal(textBox9Input.Text);
            if (val10 == 500m)
                textBox9ResultA.Text = "Success";
            if (val10 != 500m)
                textBox9ResultB.Text = "Fail";

            decimal val11 = Convert.ToDecimal(textBox10InputA.Text);
            if (val11 == 2m)
                textBox10ResultA.Text = "Success";
            if (val11 != 2m)
                textBox10ResultB.Text = "Fail";
            decimal val12 = Convert.ToDecimal(textBox10InputB.Text);
            if (val12 == 4m)
                textBox10ResultA.Text = "Fail";
            if (val12 != 3m)
                textBox10ResultB.Text = "Success";








        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
