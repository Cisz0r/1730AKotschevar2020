namespace VariableStamper
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
            this.btnTotal = new System.Windows.Forms.Label();
            this.btnTax = new System.Windows.Forms.Label();
            this.PretaxTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtButterSubTotal = new System.Windows.Forms.TextBox();
            this.txtSteakSubTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnButter = new System.Windows.Forms.Label();
            this.btnSteak = new System.Windows.Forms.Label();
            this.txtButter = new System.Windows.Forms.TextBox();
            this.txtSteak = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.Location = new System.Drawing.Point(268, 160);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(44, 17);
            this.btnTotal.TabIndex = 36;
            this.btnTotal.Text = "Total:";
            // 
            // btnTax
            // 
            this.btnTax.AutoSize = true;
            this.btnTax.Location = new System.Drawing.Point(277, 134);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(35, 17);
            this.btnTax.TabIndex = 35;
            this.btnTax.Text = "Tax:";
            // 
            // PretaxTotal
            // 
            this.PretaxTotal.AutoSize = true;
            this.PretaxTotal.Location = new System.Drawing.Point(229, 106);
            this.PretaxTotal.Name = "PretaxTotal";
            this.PretaxTotal.Size = new System.Drawing.Size(84, 17);
            this.PretaxTotal.TabIndex = 34;
            this.PretaxTotal.Text = "PretaxTotal:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(318, 129);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 33;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(318, 101);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtPretaxTotal.TabIndex = 32;
            this.txtPretaxTotal.TabStop = false;
            this.txtPretaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(318, 157);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 31;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtButterSubTotal
            // 
            this.txtButterSubTotal.Location = new System.Drawing.Point(318, 73);
            this.txtButterSubTotal.Name = "txtButterSubTotal";
            this.txtButterSubTotal.ReadOnly = true;
            this.txtButterSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtButterSubTotal.TabIndex = 30;
            this.txtButterSubTotal.TabStop = false;
            this.txtButterSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSteakSubTotal
            // 
            this.txtSteakSubTotal.Location = new System.Drawing.Point(319, 44);
            this.txtSteakSubTotal.Name = "txtSteakSubTotal";
            this.txtSteakSubTotal.ReadOnly = true;
            this.txtSteakSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSteakSubTotal.TabIndex = 29;
            this.txtSteakSubTotal.TabStop = false;
            this.txtSteakSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "x $300.00 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "x $1.00 =";
            // 
            // btnButter
            // 
            this.btnButter.AutoSize = true;
            this.btnButter.Location = new System.Drawing.Point(104, 78);
            this.btnButter.Name = "btnButter";
            this.btnButter.Size = new System.Drawing.Size(50, 17);
            this.btnButter.TabIndex = 26;
            this.btnButter.Text = "Butter:";
            // 
            // btnSteak
            // 
            this.btnSteak.AutoSize = true;
            this.btnSteak.Location = new System.Drawing.Point(105, 44);
            this.btnSteak.Name = "btnSteak";
            this.btnSteak.Size = new System.Drawing.Size(48, 17);
            this.btnSteak.TabIndex = 25;
            this.btnSteak.Text = "Steak:";
            // 
            // txtButter
            // 
            this.txtButter.Location = new System.Drawing.Point(158, 76);
            this.txtButter.Name = "txtButter";
            this.txtButter.Size = new System.Drawing.Size(66, 22);
            this.txtButter.TabIndex = 24;
            this.txtButter.Text = "0";
            this.txtButter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSteak
            // 
            this.txtSteak.Location = new System.Drawing.Point(159, 44);
            this.txtSteak.Name = "txtSteak";
            this.txtSteak.Size = new System.Drawing.Size(66, 22);
            this.txtSteak.TabIndex = 23;
            this.txtSteak.Text = "0";
            this.txtSteak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 28);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(78, 218);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 28);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 335);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.PretaxTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtButterSubTotal);
            this.Controls.Add(this.txtSteakSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnButter);
            this.Controls.Add(this.btnSteak);
            this.Controls.Add(this.txtButter);
            this.Controls.Add(this.txtSteak);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Variable Stomper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnTotal;
        private System.Windows.Forms.Label btnTax;
        private System.Windows.Forms.Label PretaxTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtButterSubTotal;
        private System.Windows.Forms.TextBox txtSteakSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnButter;
        private System.Windows.Forms.Label btnSteak;
        private System.Windows.Forms.TextBox txtButter;
        private System.Windows.Forms.TextBox txtSteak;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}

