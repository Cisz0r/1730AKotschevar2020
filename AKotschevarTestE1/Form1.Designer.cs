namespace AKotschevarTestE1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTextBox1 = new System.Windows.Forms.TextBox();
            this.txtTextBox2 = new System.Windows.Forms.TextBox();
            this.txtTextBox3 = new System.Windows.Forms.TextBox();
            this.txtTest1 = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.Label();
            this.txtTest3 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.Label();
            this.txtAverageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(230, 46);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 26);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTextBox1
            // 
            this.txtTextBox1.Location = new System.Drawing.Point(136, 46);
            this.txtTextBox1.Name = "txtTextBox1";
            this.txtTextBox1.Size = new System.Drawing.Size(61, 22);
            this.txtTextBox1.TabIndex = 3;
            this.txtTextBox1.Text = "0";
            this.txtTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTextBox1.TextChanged += new System.EventHandler(this.txtTextBox1_TextChanged);
            // 
            // txtTextBox2
            // 
            this.txtTextBox2.Location = new System.Drawing.Point(136, 83);
            this.txtTextBox2.Name = "txtTextBox2";
            this.txtTextBox2.Size = new System.Drawing.Size(61, 22);
            this.txtTextBox2.TabIndex = 4;
            this.txtTextBox2.Text = "0";
            this.txtTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTextBox2.TextChanged += new System.EventHandler(this.txtTextBox2_TextChanged);
            // 
            // txtTextBox3
            // 
            this.txtTextBox3.Location = new System.Drawing.Point(136, 122);
            this.txtTextBox3.Name = "txtTextBox3";
            this.txtTextBox3.Size = new System.Drawing.Size(61, 22);
            this.txtTextBox3.TabIndex = 5;
            this.txtTextBox3.Text = "0";
            this.txtTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTextBox3.TextChanged += new System.EventHandler(this.txtTextBox3_TextChanged);
            // 
            // txtTest1
            // 
            this.txtTest1.AutoSize = true;
            this.txtTest1.Location = new System.Drawing.Point(72, 46);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(52, 17);
            this.txtTest1.TabIndex = 6;
            this.txtTest1.Text = "Test 1:";
            // 
            // txtTest2
            // 
            this.txtTest2.AutoSize = true;
            this.txtTest2.Location = new System.Drawing.Point(72, 88);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(52, 17);
            this.txtTest2.TabIndex = 7;
            this.txtTest2.Text = "Test 2:";
            // 
            // txtTest3
            // 
            this.txtTest3.AutoSize = true;
            this.txtTest3.Location = new System.Drawing.Point(72, 127);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(52, 17);
            this.txtTest3.TabIndex = 8;
            this.txtTest3.Text = "Test 3:";
            // 
            // txtAverage
            // 
            this.txtAverage.AutoSize = true;
            this.txtAverage.Location = new System.Drawing.Point(59, 183);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(65, 17);
            this.txtAverage.TabIndex = 9;
            this.txtAverage.Text = "Average:";
            // 
            // txtAverageBox
            // 
            this.txtAverageBox.Location = new System.Drawing.Point(136, 183);
            this.txtAverageBox.Name = "txtAverageBox";
            this.txtAverageBox.ReadOnly = true;
            this.txtAverageBox.Size = new System.Drawing.Size(61, 22);
            this.txtAverageBox.TabIndex = 10;
            this.txtAverageBox.TabStop = false;
            this.txtAverageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAverageBox.TextChanged += new System.EventHandler(this.txtAverageBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 239);
            this.Controls.Add(this.txtAverageBox);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.txtTextBox3);
            this.Controls.Add(this.txtTextBox2);
            this.Controls.Add(this.txtTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "AkotschevarE1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTextBox1;
        private System.Windows.Forms.TextBox txtTextBox2;
        private System.Windows.Forms.TextBox txtTextBox3;
        private System.Windows.Forms.Label txtTest1;
        private System.Windows.Forms.Label txtTest2;
        private System.Windows.Forms.Label txtTest3;
        private System.Windows.Forms.Label txtAverage;
        private System.Windows.Forms.TextBox txtAverageBox;
    }
}

