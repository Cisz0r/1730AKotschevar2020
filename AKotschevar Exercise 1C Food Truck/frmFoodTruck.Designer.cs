namespace AKotschevar_Exercise_1C_Food_Truck
{
    partial class frmFoodTruck
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
            this.txtSteak = new System.Windows.Forms.TextBox();
            this.txtButter = new System.Windows.Forms.TextBox();
            this.btnSteak = new System.Windows.Forms.Label();
            this.btnButter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSteakSubTotal = new System.Windows.Forms.TextBox();
            this.txtButterSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.txtTaxTotal = new System.Windows.Forms.TextBox();
            this.PretaxTotal = new System.Windows.Forms.Label();
            this.btnTax = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(77, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 28);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 28);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSteak
            // 
            this.txtSteak.Location = new System.Drawing.Point(158, 53);
            this.txtSteak.Name = "txtSteak";
            this.txtSteak.Size = new System.Drawing.Size(66, 22);
            this.txtSteak.TabIndex = 3;
            this.txtSteak.Text = "0";
            this.txtSteak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtButter
            // 
            this.txtButter.Location = new System.Drawing.Point(157, 85);
            this.txtButter.Name = "txtButter";
            this.txtButter.Size = new System.Drawing.Size(66, 22);
            this.txtButter.TabIndex = 4;
            this.txtButter.Text = "0";
            this.txtButter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSteak
            // 
            this.btnSteak.AutoSize = true;
            this.btnSteak.Location = new System.Drawing.Point(104, 53);
            this.btnSteak.Name = "btnSteak";
            this.btnSteak.Size = new System.Drawing.Size(48, 17);
            this.btnSteak.TabIndex = 5;
            this.btnSteak.Text = "Steak:";
            // 
            // btnButter
            // 
            this.btnButter.AutoSize = true;
            this.btnButter.Location = new System.Drawing.Point(103, 87);
            this.btnButter.Name = "btnButter";
            this.btnButter.Size = new System.Drawing.Size(50, 17);
            this.btnButter.TabIndex = 6;
            this.btnButter.Text = "Butter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "x $1.00 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "x $300.00 =";
            // 
            // txtSteakSubTotal
            // 
            this.txtSteakSubTotal.Location = new System.Drawing.Point(318, 53);
            this.txtSteakSubTotal.Name = "txtSteakSubTotal";
            this.txtSteakSubTotal.ReadOnly = true;
            this.txtSteakSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSteakSubTotal.TabIndex = 12;
            this.txtSteakSubTotal.TabStop = false;
            this.txtSteakSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtButterSubTotal
            // 
            this.txtButterSubTotal.Location = new System.Drawing.Point(317, 82);
            this.txtButterSubTotal.Name = "txtButterSubTotal";
            this.txtButterSubTotal.ReadOnly = true;
            this.txtButterSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtButterSubTotal.TabIndex = 13;
            this.txtButterSubTotal.TabStop = false;
            this.txtButterSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(317, 166);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(317, 110);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtPretaxTotal.TabIndex = 15;
            this.txtPretaxTotal.TabStop = false;
            this.txtPretaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTaxTotal
            // 
            this.txtTaxTotal.Location = new System.Drawing.Point(317, 138);
            this.txtTaxTotal.Name = "txtTaxTotal";
            this.txtTaxTotal.ReadOnly = true;
            this.txtTaxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTaxTotal.TabIndex = 16;
            this.txtTaxTotal.TabStop = false;
            this.txtTaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PretaxTotal
            // 
            this.PretaxTotal.AutoSize = true;
            this.PretaxTotal.Location = new System.Drawing.Point(228, 115);
            this.PretaxTotal.Name = "PretaxTotal";
            this.PretaxTotal.Size = new System.Drawing.Size(84, 17);
            this.PretaxTotal.TabIndex = 17;
            this.PretaxTotal.Text = "PretaxTotal:";
            // 
            // btnTax
            // 
            this.btnTax.AutoSize = true;
            this.btnTax.Location = new System.Drawing.Point(276, 143);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(35, 17);
            this.btnTax.TabIndex = 18;
            this.btnTax.Text = "Tax:";
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.Location = new System.Drawing.Point(267, 169);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(44, 17);
            this.btnTotal.TabIndex = 19;
            this.btnTotal.Text = "Total:";
            // 
            // frmFoodTruck
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 322);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.PretaxTotal);
            this.Controls.Add(this.txtTaxTotal);
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
            this.Name = "frmFoodTruck";
            this.Text = "1C Food Truck Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSteak;
        private System.Windows.Forms.TextBox txtButter;
        private System.Windows.Forms.Label btnSteak;
        private System.Windows.Forms.Label btnButter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSteakSubTotal;
        private System.Windows.Forms.TextBox txtButterSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.TextBox txtTaxTotal;
        private System.Windows.Forms.Label PretaxTotal;
        private System.Windows.Forms.Label btnTax;
        private System.Windows.Forms.Label btnTotal;
    }
}

