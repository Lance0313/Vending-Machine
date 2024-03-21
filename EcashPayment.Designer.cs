namespace AlphaPrototype
{
    partial class EcashPayment
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
            this.CartSummaryPanel = new System.Windows.Forms.Panel();
            this.EPay = new System.Windows.Forms.Label();
            this.PaymentQRCode = new System.Windows.Forms.PictureBox();
            this.EPayTotalDesc = new System.Windows.Forms.Label();
            this.EPayTotal = new System.Windows.Forms.Label();
            this.DoneButton = new ePOSOne.btnProduct.RoundButton();
            this.PurchaseBackButton = new ePOSOne.btnProduct.RoundButton();
            this.CartSummaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.EPay);
            this.CartSummaryPanel.Controls.Add(this.PaymentQRCode);
            this.CartSummaryPanel.Controls.Add(this.EPayTotalDesc);
            this.CartSummaryPanel.Controls.Add(this.EPayTotal);
            this.CartSummaryPanel.Location = new System.Drawing.Point(408, 156);
            this.CartSummaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(584, 457);
            this.CartSummaryPanel.TabIndex = 12;
            // 
            // EPay
            // 
            this.EPay.AutoSize = true;
            this.EPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPay.Location = new System.Drawing.Point(187, 31);
            this.EPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EPay.Name = "EPay";
            this.EPay.Size = new System.Drawing.Size(223, 26);
            this.EPay.TabIndex = 17;
            this.EPay.Text = "E-CASH PAYMENT";
            // 
            // PaymentQRCode
            // 
            this.PaymentQRCode.Image = global::AlphaPrototype.Properties.Resources.ePaymentQR;
            this.PaymentQRCode.Location = new System.Drawing.Point(132, 156);
            this.PaymentQRCode.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentQRCode.Name = "PaymentQRCode";
            this.PaymentQRCode.Size = new System.Drawing.Size(344, 267);
            this.PaymentQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentQRCode.TabIndex = 13;
            this.PaymentQRCode.TabStop = false;
            // 
            // EPayTotalDesc
            // 
            this.EPayTotalDesc.AutoSize = true;
            this.EPayTotalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPayTotalDesc.Location = new System.Drawing.Point(188, 115);
            this.EPayTotalDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EPayTotalDesc.Name = "EPayTotalDesc";
            this.EPayTotalDesc.Size = new System.Drawing.Size(223, 20);
            this.EPayTotalDesc.TabIndex = 13;
            this.EPayTotalDesc.Text = "Please scan the QR code";
            // 
            // EPayTotal
            // 
            this.EPayTotal.AutoSize = true;
            this.EPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPayTotal.Location = new System.Drawing.Point(255, 89);
            this.EPayTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EPayTotal.Name = "EPayTotal";
            this.EPayTotal.Size = new System.Drawing.Size(85, 26);
            this.EPayTotal.TabIndex = 0;
            this.EPayTotal.Text = "TOTAL";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DoneButton.BorderColor = System.Drawing.Color.Transparent;
            this.DoneButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.DoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.Black;
            this.DoneButton.Location = new System.Drawing.Point(540, 638);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(4);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.DoneButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.DoneButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.DoneButton.Size = new System.Drawing.Size(322, 57);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Text = "DONE";
            this.DoneButton.TextColor = System.Drawing.Color.Black;
            this.DoneButton.UseVisualStyleBackColor = false;
            // 
            // PurchaseBackButton
            // 
            this.PurchaseBackButton.BackColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PurchaseBackButton.BorderColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.PurchaseBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseBackButton.FlatAppearance.BorderSize = 0;
            this.PurchaseBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseBackButton.ForeColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.Location = new System.Drawing.Point(27, 36);
            this.PurchaseBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseBackButton.Name = "PurchaseBackButton";
            this.PurchaseBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PurchaseBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.Size = new System.Drawing.Size(245, 57);
            this.PurchaseBackButton.TabIndex = 11;
            this.PurchaseBackButton.Text = "BACK";
            this.PurchaseBackButton.TextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.UseVisualStyleBackColor = false;
            // 
            // EcashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.CartSummaryPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Controls.Add(this.DoneButton);
            this.Name = "EcashPayment";
            this.Size = new System.Drawing.Size(1375, 738);
            this.CartSummaryPanel.ResumeLayout(false);
            this.CartSummaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CartSummaryPanel;
        private System.Windows.Forms.Label EPayTotalDesc;
        private ePOSOne.btnProduct.RoundButton DoneButton;
        private System.Windows.Forms.Label EPayTotal;
        private ePOSOne.btnProduct.RoundButton PurchaseBackButton;
        private System.Windows.Forms.PictureBox PaymentQRCode;
        private System.Windows.Forms.Label EPay;
    }
}
