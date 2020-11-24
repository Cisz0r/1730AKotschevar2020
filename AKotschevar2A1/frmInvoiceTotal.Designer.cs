namespace AKotschevar2A1
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountpercent = new System.Windows.Forms.Label();
            this.lblDiscountamount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountpercent = new System.Windows.Forms.TextBox();
            this.txtDiscountamount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(88, 45);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "&Subtotal:";
            // 
            // lblDiscountpercent
            // 
            this.lblDiscountpercent.AutoSize = true;
            this.lblDiscountpercent.Location = new System.Drawing.Point(88, 85);
            this.lblDiscountpercent.Name = "lblDiscountpercent";
            this.lblDiscountpercent.Size = new System.Drawing.Size(119, 17);
            this.lblDiscountpercent.TabIndex = 1;
            this.lblDiscountpercent.Text = "Discount percent:";
            // 
            // lblDiscountamount
            // 
            this.lblDiscountamount.AutoSize = true;
            this.lblDiscountamount.Location = new System.Drawing.Point(88, 129);
            this.lblDiscountamount.Name = "lblDiscountamount";
            this.lblDiscountamount.Size = new System.Drawing.Size(118, 17);
            this.lblDiscountamount.TabIndex = 2;
            this.lblDiscountamount.Text = "Discount amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(88, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(222, 45);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(139, 22);
            this.txtSubtotal.TabIndex = 4;
            // 
            // txtDiscountpercent
            // 
            this.txtDiscountpercent.Location = new System.Drawing.Point(222, 85);
            this.txtDiscountpercent.Name = "txtDiscountpercent";
            this.txtDiscountpercent.ReadOnly = true;
            this.txtDiscountpercent.Size = new System.Drawing.Size(139, 22);
            this.txtDiscountpercent.TabIndex = 5;
            this.txtDiscountpercent.TabStop = false;
            // 
            // txtDiscountamount
            // 
            this.txtDiscountamount.Location = new System.Drawing.Point(222, 124);
            this.txtDiscountamount.Name = "txtDiscountamount";
            this.txtDiscountamount.ReadOnly = true;
            this.txtDiscountamount.Size = new System.Drawing.Size(139, 22);
            this.txtDiscountamount.TabIndex = 6;
            this.txtDiscountamount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(222, 162);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 22);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(109, 217);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 33);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountamount);
            this.Controls.Add(this.txtDiscountpercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountamount);
            this.Controls.Add(this.lblDiscountpercent);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "Form1";
            this.Text = "AKotschevar Variables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountpercent;
        private System.Windows.Forms.Label lblDiscountamount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountpercent;
        private System.Windows.Forms.TextBox txtDiscountamount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

