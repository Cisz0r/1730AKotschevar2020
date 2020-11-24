using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AKotschevar2H1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationsButton_Click1(object sender, EventArgs e)
        {
            TextBox1AResult.Text = DateTime.Now.ToShortDateString();
            TextBox1BResult.Text = DateTime.Now.ToShortTimeString();
            TextBox2AResult.Text = DateTime.Today.ToShortDateString();
            TextBox2BResult.Text = DateTime.Today.ToShortTimeString();
            TextBox3AResult.Text = DateTime.Today.Year.ToString();
            TextBox3BResult.Text = DateTime.Today.Month.ToString();
            TextBox3CResult.Text = DateTime.Today.Day.ToString();
            TextBox4Result.Text = DateTime.Today.AddDays(90).ToString();
            TextBox5Result.Text = DateTime.Today.AddMonths(3).ToString();
            TextBox6Result.Text = Ex2hCalculations.DateCalc06(TextBox6A.Text, TextBox6B.Text, TextBox6C.Text);
            TextBox7Result.Text = Ex2hCalculations.DateCalc07(TextBox7.Text);
            TextBox8Result.Text = Ex2hCalculations.DateCalc08(TextBox8.Text);
            //TextBox9Result.Text = Ex2hCalculations.DateCalc09(TextBox9A.Text, TextBox9B.Text);
            //TextBox10Result.Text = Ex2hCalculations.DateCalc10(TextBox10A.Text, TextBox10B.Text);


        }
    }
}