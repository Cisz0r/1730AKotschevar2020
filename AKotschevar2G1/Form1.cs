using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKotschevar2G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1A) 'Switch' with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1ATextBox.Text);

            // 1B)  Seperate 'If' Statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1ATextBox.Text);

            // 1C) If else If
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1ATextBox.Text);

            // 1D) Nested If-Else
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1ATextBox.Text);

            // 1E) 'Switch' with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1ATextBox.Text);

            // 1F) Seperate If statements with a Default Value 
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(input1ATextBox.Text);

            // 1G) If Else-If with Default
            resultElseIfDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1ATextBox.Text);

            // 1H) Nested If-Else Default
            resultNestedIfElseDefaultTextBox.Text = Ex2gCalculations.NestedIfDefault01(input1ATextBox.Text);

            // 2A) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input2ATextBox.Text);

            // 2B) Seperate 'If' Statements
            resultIf02TextBox.Text = Ex2gCalculations.If02(input2ATextBox.Text);

            // 2C) If Else-If
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(input2ATextBox.Text);

            // 2D) Nested If-Else
            resultNestedIfElse02TextBox.Text = Ex2gCalculations.NestedIfElse02(input2ATextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
