namespace AKotschevar2B1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSARate = new System.Windows.Forms.Label();
            this.txtUSDTotal = new System.Windows.Forms.TextBox();
            this.txtUSDZimbabwe = new System.Windows.Forms.TextBox();
            this.txtUSDAngola = new System.Windows.Forms.TextBox();
            this.txtUSDUK = new System.Windows.Forms.TextBox();
            this.txtUSDRomania = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.Label();
            this.txtRateZimbabwe = new System.Windows.Forms.TextBox();
            this.txtRateAngola = new System.Windows.Forms.TextBox();
            this.txtRateUK = new System.Windows.Forms.TextBox();
            this.txtRateRomania = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountZimbabwe = new System.Windows.Forms.TextBox();
            this.txtAmountAngola = new System.Windows.Forms.TextBox();
            this.txtAmountUK = new System.Windows.Forms.TextBox();
            this.txtAmountRomania = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngola = new System.Windows.Forms.Label();
            this.txtUKCurrency = new System.Windows.Forms.Label();
            this.txtRomanianCurrency = new System.Windows.Forms.Label();
            this.txtUSA = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtZimbabwe = new System.Windows.Forms.PictureBox();
            this.txtUK = new System.Windows.Forms.PictureBox();
            this.txtRomanian = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimbabwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRomanian)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(426, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 27);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(264, 332);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 27);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUSARate
            // 
            this.txtUSARate.AutoSize = true;
            this.txtUSARate.Location = new System.Drawing.Point(49, 293);
            this.txtUSARate.Name = "txtUSARate";
            this.txtUSARate.Size = new System.Drawing.Size(48, 17);
            this.txtUSARate.TabIndex = 46;
            this.txtUSARate.Text = "$USA:";
            // 
            // txtUSDTotal
            // 
            this.txtUSDTotal.Location = new System.Drawing.Point(785, 293);
            this.txtUSDTotal.Name = "txtUSDTotal";
            this.txtUSDTotal.ReadOnly = true;
            this.txtUSDTotal.Size = new System.Drawing.Size(165, 22);
            this.txtUSDTotal.TabIndex = 52;
            this.txtUSDTotal.TabStop = false;
            // 
            // txtUSDZimbabwe
            // 
            this.txtUSDZimbabwe.Location = new System.Drawing.Point(599, 293);
            this.txtUSDZimbabwe.Name = "txtUSDZimbabwe";
            this.txtUSDZimbabwe.ReadOnly = true;
            this.txtUSDZimbabwe.Size = new System.Drawing.Size(140, 22);
            this.txtUSDZimbabwe.TabIndex = 50;
            this.txtUSDZimbabwe.TabStop = false;
            this.txtUSDZimbabwe.Text = "0.00";
            this.txtUSDZimbabwe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDAngola
            // 
            this.txtUSDAngola.Location = new System.Drawing.Point(425, 293);
            this.txtUSDAngola.Name = "txtUSDAngola";
            this.txtUSDAngola.ReadOnly = true;
            this.txtUSDAngola.Size = new System.Drawing.Size(140, 22);
            this.txtUSDAngola.TabIndex = 49;
            this.txtUSDAngola.TabStop = false;
            this.txtUSDAngola.Text = "0.00";
            this.txtUSDAngola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDUK
            // 
            this.txtUSDUK.Location = new System.Drawing.Point(263, 293);
            this.txtUSDUK.Name = "txtUSDUK";
            this.txtUSDUK.ReadOnly = true;
            this.txtUSDUK.Size = new System.Drawing.Size(140, 22);
            this.txtUSDUK.TabIndex = 48;
            this.txtUSDUK.TabStop = false;
            this.txtUSDUK.Text = "0.00";
            this.txtUSDUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDRomania
            // 
            this.txtUSDRomania.Location = new System.Drawing.Point(103, 293);
            this.txtUSDRomania.Name = "txtUSDRomania";
            this.txtUSDRomania.ReadOnly = true;
            this.txtUSDRomania.Size = new System.Drawing.Size(140, 22);
            this.txtUSDRomania.TabIndex = 47;
            this.txtUSDRomania.TabStop = false;
            this.txtUSDRomania.Text = "0.00";
            this.txtUSDRomania.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.AutoSize = true;
            this.txtRate.Location = new System.Drawing.Point(55, 265);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(42, 17);
            this.txtRate.TabIndex = 45;
            this.txtRate.Text = "Rate:";
            // 
            // txtRateZimbabwe
            // 
            this.txtRateZimbabwe.Location = new System.Drawing.Point(599, 265);
            this.txtRateZimbabwe.Name = "txtRateZimbabwe";
            this.txtRateZimbabwe.Size = new System.Drawing.Size(140, 22);
            this.txtRateZimbabwe.TabIndex = 38;
            this.txtRateZimbabwe.Text = "0.00276319";
            this.txtRateZimbabwe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateZimbabwe.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateAngola
            // 
            this.txtRateAngola.Location = new System.Drawing.Point(425, 265);
            this.txtRateAngola.Name = "txtRateAngola";
            this.txtRateAngola.Size = new System.Drawing.Size(140, 22);
            this.txtRateAngola.TabIndex = 37;
            this.txtRateAngola.Text = "0.00159843";
            this.txtRateAngola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAngola.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateUK
            // 
            this.txtRateUK.Location = new System.Drawing.Point(263, 265);
            this.txtRateUK.Name = "txtRateUK";
            this.txtRateUK.Size = new System.Drawing.Size(140, 22);
            this.txtRateUK.TabIndex = 36;
            this.txtRateUK.Text = "1.29904";
            this.txtRateUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateUK.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateRomania
            // 
            this.txtRateRomania.Location = new System.Drawing.Point(103, 265);
            this.txtRateRomania.Name = "txtRateRomania";
            this.txtRateRomania.Size = new System.Drawing.Size(140, 22);
            this.txtRateRomania.TabIndex = 35;
            this.txtRateRomania.Text = "0.243149";
            this.txtRateRomania.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateRomania.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Amount:";
            // 
            // txtAmountZimbabwe
            // 
            this.txtAmountZimbabwe.Location = new System.Drawing.Point(599, 237);
            this.txtAmountZimbabwe.Name = "txtAmountZimbabwe";
            this.txtAmountZimbabwe.Size = new System.Drawing.Size(140, 22);
            this.txtAmountZimbabwe.TabIndex = 31;
            this.txtAmountZimbabwe.Text = "0.00";
            this.txtAmountZimbabwe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountZimbabwe.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountAngola
            // 
            this.txtAmountAngola.Location = new System.Drawing.Point(425, 237);
            this.txtAmountAngola.Name = "txtAmountAngola";
            this.txtAmountAngola.Size = new System.Drawing.Size(140, 22);
            this.txtAmountAngola.TabIndex = 29;
            this.txtAmountAngola.Text = "0.00";
            this.txtAmountAngola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAngola.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountUK
            // 
            this.txtAmountUK.Location = new System.Drawing.Point(263, 237);
            this.txtAmountUK.Name = "txtAmountUK";
            this.txtAmountUK.Size = new System.Drawing.Size(140, 22);
            this.txtAmountUK.TabIndex = 26;
            this.txtAmountUK.Text = "0.00";
            this.txtAmountUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountUK.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountRomania
            // 
            this.txtAmountRomania.Location = new System.Drawing.Point(103, 237);
            this.txtAmountRomania.Name = "txtAmountRomania";
            this.txtAmountRomania.Size = new System.Drawing.Size(140, 22);
            this.txtAmountRomania.TabIndex = 25;
            this.txtAmountRomania.Text = "0.00";
            this.txtAmountRomania.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountRomania.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "USA Dollar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Zimbabwe Currency";
            // 
            // txtAngola
            // 
            this.txtAngola.AutoSize = true;
            this.txtAngola.Location = new System.Drawing.Point(436, 207);
            this.txtAngola.Name = "txtAngola";
            this.txtAngola.Size = new System.Drawing.Size(113, 17);
            this.txtAngola.TabIndex = 41;
            this.txtAngola.Text = "Angola Currency";
            // 
            // txtUKCurrency
            // 
            this.txtUKCurrency.AutoSize = true;
            this.txtUKCurrency.Location = new System.Drawing.Point(284, 207);
            this.txtUKCurrency.Name = "txtUKCurrency";
            this.txtUKCurrency.Size = new System.Drawing.Size(88, 17);
            this.txtUKCurrency.TabIndex = 40;
            this.txtUKCurrency.Text = "UK Currency";
            // 
            // txtRomanianCurrency
            // 
            this.txtRomanianCurrency.AutoSize = true;
            this.txtRomanianCurrency.Location = new System.Drawing.Point(107, 207);
            this.txtRomanianCurrency.Name = "txtRomanianCurrency";
            this.txtRomanianCurrency.Size = new System.Drawing.Size(133, 17);
            this.txtRomanianCurrency.TabIndex = 39;
            this.txtRomanianCurrency.Text = "Romanian Currency";
            // 
            // txtUSA
            // 
            this.txtUSA.Image = global::AKotschevar2B1.Properties.Resources.Usa;
            this.txtUSA.Location = new System.Drawing.Point(785, 60);
            this.txtUSA.Name = "txtUSA";
            this.txtUSA.Size = new System.Drawing.Size(165, 164);
            this.txtUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtUSA.TabIndex = 33;
            this.txtUSA.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AKotschevar2B1.Properties.Resources.Angola_Flag_icon;
            this.pictureBox4.Location = new System.Drawing.Point(422, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(144, 151);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // txtZimbabwe
            // 
            this.txtZimbabwe.Image = global::AKotschevar2B1.Properties.Resources.depositphotos_54643351_stock_photo_zimbabwe_flag_icon;
            this.txtZimbabwe.Location = new System.Drawing.Point(585, 53);
            this.txtZimbabwe.Name = "txtZimbabwe";
            this.txtZimbabwe.Size = new System.Drawing.Size(154, 145);
            this.txtZimbabwe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtZimbabwe.TabIndex = 28;
            this.txtZimbabwe.TabStop = false;
            // 
            // txtUK
            // 
            this.txtUK.Image = global::AKotschevar2B1.Properties.Resources.UK;
            this.txtUK.Location = new System.Drawing.Point(260, 53);
            this.txtUK.Name = "txtUK";
            this.txtUK.Size = new System.Drawing.Size(144, 151);
            this.txtUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtUK.TabIndex = 27;
            this.txtUK.TabStop = false;
            // 
            // txtRomanian
            // 
            this.txtRomanian.Image = global::AKotschevar2B1.Properties.Resources.Romanian_Flag;
            this.txtRomanian.Location = new System.Drawing.Point(99, 53);
            this.txtRomanian.Name = "txtRomanian";
            this.txtRomanian.Size = new System.Drawing.Size(144, 151);
            this.txtRomanian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtRomanian.TabIndex = 24;
            this.txtRomanian.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 499);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUSARate);
            this.Controls.Add(this.txtUSDTotal);
            this.Controls.Add(this.txtUSDZimbabwe);
            this.Controls.Add(this.txtUSDAngola);
            this.Controls.Add(this.txtUSDUK);
            this.Controls.Add(this.txtUSDRomania);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtRateZimbabwe);
            this.Controls.Add(this.txtRateAngola);
            this.Controls.Add(this.txtRateUK);
            this.Controls.Add(this.txtRateRomania);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountZimbabwe);
            this.Controls.Add(this.txtAmountAngola);
            this.Controls.Add(this.txtAmountUK);
            this.Controls.Add(this.txtAmountRomania);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAngola);
            this.Controls.Add(this.txtUKCurrency);
            this.Controls.Add(this.txtRomanianCurrency);
            this.Controls.Add(this.txtUSA);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtZimbabwe);
            this.Controls.Add(this.txtUK);
            this.Controls.Add(this.txtRomanian);
            this.Name = "Form1";
            this.Text = "Trout Dressed Like a Jester The Movie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimbabwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRomanian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtUSARate;
        private System.Windows.Forms.TextBox txtUSDTotal;
        private System.Windows.Forms.TextBox txtUSDZimbabwe;
        private System.Windows.Forms.TextBox txtUSDAngola;
        private System.Windows.Forms.TextBox txtUSDUK;
        private System.Windows.Forms.TextBox txtUSDRomania;
        private System.Windows.Forms.Label txtRate;
        private System.Windows.Forms.TextBox txtRateZimbabwe;
        private System.Windows.Forms.TextBox txtRateAngola;
        private System.Windows.Forms.TextBox txtRateUK;
        private System.Windows.Forms.TextBox txtRateRomania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountZimbabwe;
        private System.Windows.Forms.TextBox txtAmountAngola;
        private System.Windows.Forms.TextBox txtAmountUK;
        private System.Windows.Forms.TextBox txtAmountRomania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtAngola;
        private System.Windows.Forms.Label txtUKCurrency;
        private System.Windows.Forms.Label txtRomanianCurrency;
        private System.Windows.Forms.PictureBox txtUSA;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox txtZimbabwe;
        private System.Windows.Forms.PictureBox txtUK;
        private System.Windows.Forms.PictureBox txtRomanian;
    }
}

