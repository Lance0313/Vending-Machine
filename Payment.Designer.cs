namespace AlphaPrototype
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.PaymentAmount = new System.Windows.Forms.Label();
            this.PaymentCurrencyLabel = new System.Windows.Forms.Label();
            this.PaymentCounterLabel = new System.Windows.Forms.Label();
            this.PaymentTotalLabel = new System.Windows.Forms.Label();
            this.PaymentCashLabel = new System.Windows.Forms.Label();
            this.PaymentOrLabel = new System.Windows.Forms.Label();
            this.PaymentQRCodeLabel = new System.Windows.Forms.Label();
            this.PaymentQRCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentBackButton = new ePOSOne.btnProduct.RoundButton();
            this.PaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackColor = System.Drawing.Color.White;
            this.PaymentPanel.Controls.Add(this.label1);
            this.PaymentPanel.Controls.Add(this.PaymentAmount);
            this.PaymentPanel.Controls.Add(this.PaymentCurrencyLabel);
            this.PaymentPanel.Controls.Add(this.PaymentCounterLabel);
            this.PaymentPanel.Controls.Add(this.PaymentTotalLabel);
            this.PaymentPanel.Controls.Add(this.PaymentCashLabel);
            this.PaymentPanel.Controls.Add(this.PaymentOrLabel);
            this.PaymentPanel.Controls.Add(this.PaymentQRCodeLabel);
            this.PaymentPanel.Controls.Add(this.PaymentQRCode);
            this.PaymentPanel.Location = new System.Drawing.Point(83, 91);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(859, 456);
            this.PaymentPanel.TabIndex = 6;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.AutoSize = true;
            this.PaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAmount.Location = new System.Drawing.Point(54, 182);
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.Size = new System.Drawing.Size(84, 37);
            this.PaymentAmount.TabIndex = 8;
            this.PaymentAmount.Text = "0.00";
            this.PaymentAmount.Click += new System.EventHandler(this.PaymentAmount_Click);
            // 
            // PaymentCurrencyLabel
            // 
            this.PaymentCurrencyLabel.AutoSize = true;
            this.PaymentCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCurrencyLabel.Location = new System.Drawing.Point(523, 266);
            this.PaymentCurrencyLabel.Name = "PaymentCurrencyLabel";
            this.PaymentCurrencyLabel.Size = new System.Drawing.Size(0, 37);
            this.PaymentCurrencyLabel.TabIndex = 6;
            // 
            // PaymentCounterLabel
            // 
            this.PaymentCounterLabel.AutoSize = true;
            this.PaymentCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCounterLabel.Location = new System.Drawing.Point(54, 312);
            this.PaymentCounterLabel.Name = "PaymentCounterLabel";
            this.PaymentCounterLabel.Size = new System.Drawing.Size(84, 37);
            this.PaymentCounterLabel.TabIndex = 5;
            this.PaymentCounterLabel.Text = "0.00";
            // 
            // PaymentTotalLabel
            // 
            this.PaymentTotalLabel.AutoSize = true;
            this.PaymentTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTotalLabel.Location = new System.Drawing.Point(54, 266);
            this.PaymentTotalLabel.Name = "PaymentTotalLabel";
            this.PaymentTotalLabel.Size = new System.Drawing.Size(149, 37);
            this.PaymentTotalLabel.TabIndex = 4;
            this.PaymentTotalLabel.Text = "Inserted:";
            // 
            // PaymentCashLabel
            // 
            this.PaymentCashLabel.AutoSize = true;
            this.PaymentCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCashLabel.Location = new System.Drawing.Point(55, 128);
            this.PaymentCashLabel.Name = "PaymentCashLabel";
            this.PaymentCashLabel.Size = new System.Drawing.Size(244, 35);
            this.PaymentCashLabel.TabIndex = 3;
            this.PaymentCashLabel.Text = "Pay using Cash";
            // 
            // PaymentOrLabel
            // 
            this.PaymentOrLabel.AutoSize = true;
            this.PaymentOrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentOrLabel.Location = new System.Drawing.Point(369, 232);
            this.PaymentOrLabel.Name = "PaymentOrLabel";
            this.PaymentOrLabel.Size = new System.Drawing.Size(57, 31);
            this.PaymentOrLabel.TabIndex = 2;
            this.PaymentOrLabel.Text = "OR";
            // 
            // PaymentQRCodeLabel
            // 
            this.PaymentQRCodeLabel.AutoSize = true;
            this.PaymentQRCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentQRCodeLabel.ForeColor = System.Drawing.Color.Black;
            this.PaymentQRCodeLabel.Location = new System.Drawing.Point(554, 113);
            this.PaymentQRCodeLabel.Name = "PaymentQRCodeLabel";
            this.PaymentQRCodeLabel.Size = new System.Drawing.Size(192, 35);
            this.PaymentQRCodeLabel.TabIndex = 1;
            this.PaymentQRCodeLabel.Text = "Scan to Pay";
            // 
            // PaymentQRCode
            // 
            this.PaymentQRCode.Image = global::AlphaPrototype.Properties.Resources.ePaymentQR;
            this.PaymentQRCode.Location = new System.Drawing.Point(513, 161);
            this.PaymentQRCode.Name = "PaymentQRCode";
            this.PaymentQRCode.Size = new System.Drawing.Size(282, 255);
            this.PaymentQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentQRCode.TabIndex = 0;
            this.PaymentQRCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "COMPLETE YOUR TRANSCATION";
            // 
            // PaymentBackButton
            // 
            this.PaymentBackButton.BackColor = System.Drawing.Color.Transparent;
            this.PaymentBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PaymentBackButton.BorderColor = System.Drawing.Color.Transparent;
            this.PaymentBackButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.PaymentBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentBackButton.FlatAppearance.BorderSize = 0;
            this.PaymentBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBackButton.ForeColor = System.Drawing.Color.Black;
            this.PaymentBackButton.Location = new System.Drawing.Point(25, 20);
            this.PaymentBackButton.Name = "PaymentBackButton";
            this.PaymentBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PaymentBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PaymentBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PaymentBackButton.Size = new System.Drawing.Size(184, 46);
            this.PaymentBackButton.TabIndex = 5;
            this.PaymentBackButton.Text = "Back";
            this.PaymentBackButton.TextColor = System.Drawing.Color.Black;
            this.PaymentBackButton.UseVisualStyleBackColor = false;
            this.PaymentBackButton.Click += new System.EventHandler(this.PaymentBackButton_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.PaymentPanel);
            this.Controls.Add(this.PaymentBackButton);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1028, 600);
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Label PaymentCurrencyLabel;
        private System.Windows.Forms.Label PaymentCounterLabel;
        private System.Windows.Forms.Label PaymentTotalLabel;
        private System.Windows.Forms.Label PaymentCashLabel;
        private System.Windows.Forms.Label PaymentOrLabel;
        private System.Windows.Forms.Label PaymentQRCodeLabel;
        private System.Windows.Forms.PictureBox PaymentQRCode;
        private ePOSOne.btnProduct.RoundButton PaymentBackButton;
        private System.Windows.Forms.Label PaymentAmount;
        private System.Windows.Forms.Label label1;
    }
}
