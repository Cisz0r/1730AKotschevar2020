using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANKotschevar2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03BTextBox.Text = "";
            result04TextBox.Text = "";
            result04BTextBox.Text = "";
            result05TextBox.Text = "";
            result05BTextBox.Text = "";
            result06BTextBox.Text = "";
            result06BTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09ATextBox.Text = "";
            result09BTextBox.Text = "";
            result10TextBox.Text = "";
            result11TextBox.Text = "";
            result12TextBox.Text = "";
            result13TextBox.Text = "";

            //01
            decimal subtotal = Convert.ToDecimal(input01ATextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();


            //02
            int timeInService = Convert.ToInt32(input02ATextBox.Text);
            result02TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            //NUMBERS 03 - 06 intitialization
            bool isValid = Convert.ToBoolean(input03ATextBox.Text);
            int years = Convert.ToInt32(input03CTextBox.Text);

            //03
            int counter = Convert.ToInt32(input03BTextBox.Text);
            result03TextBox.Text = (LogicalOperations.q03(isValid, years, counter)).ToString();
            result03BTextBox.Text = counter.ToString();

            //04
            counter = Convert.ToInt32(input03BTextBox.Text);
            result04TextBox.Text = (LogicalOperations.q04(isValid, counter, years)).ToString();
            result04BTextBox.Text = counter.ToString();

            //05
            counter = Convert.ToInt32(input03BTextBox.Text);
            result05TextBox.Text = (LogicalOperations.q05(isValid, years, counter)).ToString();
            result05BTextBox.Text = counter.ToString();

            //06
            counter = Convert.ToInt32(input03BTextBox.Text);
            result06TextBox.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            result06BTextBox.Text = counter.ToString();

            //07
            DateTime startDate = Convert.ToDateTime(input07ATextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07BTextBox.Text);
            DateTime date = Convert.ToDateTime(input07CTextBox.Text);
            isValid = Convert.ToBoolean(input07DTextBox.Text);
            result07TextBox.Text = (date > startDate && date < expirationDate || isValid == true).ToString();

            //08
            decimal thisYTD = Convert.ToDecimal(input08ATextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08BTextBox.Text);
            string empType = input08CTextBox.Text;
            int startYear = Convert.ToInt32(input08DTextBox.Text);
            int currentYear = Convert.ToInt32(input08ETextBox.Text);
            result08TextBox.Text =
                ((thisYTD > lastYTD || empType == "Part time") && startYear < currentYear).ToString();

            //09
            counter = Convert.ToInt32(input09ATextBox.Text);
            years = Convert.ToInt32(input09BTextBox.Text);
            result09ATextBox.Text = (
                LogicalOperations.q09(counter, years)).ToString();
            result09BTextBox.Text = counter.ToString();

            //10                                        /PEMDAS\
            int a = Convert.ToInt32(input10ATextBox.Text);
            int b = Convert.ToInt32(input10BTextBox.Text);
            int c = Convert.ToInt32(input10CTextBox.Text);
            int d = Convert.ToInt32(input10DTextBox.Text);
            result10TextBox.Text = (
                LogicalOperations.q10(a, b, c, d)).ToString();

            //11 :first textbox true if member :True if price is at least 25, if the weight is less or equal to 
            bool member = Convert.ToBoolean(input11ATextBox.Text);
            decimal price = Convert.ToDecimal(input11BTextBox.Text);
            float weight = Convert.ToSingle(input11CTextBox.Text);
            result11TextBox.Text = LogicalOperations.q11(member, price, weight).ToString();

            //12 :first textbox true for member :False if price is at least 25, if weight is less than an ounce
            member = Convert.ToBoolean(input12ATextBox.Text);
            price = Convert.ToDecimal(input12BTextBox.Text);
            weight = Convert.ToSingle(input12CTextBox.Text);
            result12TextBox.Text = LogicalOperations.q12(member, price, weight).ToString();

            //13 : anywhere outside of MN should be false, itemType isn't clothing nor food
            string shipState = input13ATextBox.Text;
            string itemType = input13BTextBox.Text;
            result13TextBox.Text = LogicalOperations.q13(shipState, itemType).ToString();

        }
    }
}
