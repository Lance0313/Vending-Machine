namespace AlphaPrototype
{
    partial class CartSummary
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
            this.PlaceYourOrderButton = new ePOSOne.btnProduct.RoundButton();
            this.PurchaseBackButton = new ePOSOne.btnProduct.RoundButton();
            this.CartSummaryPanel = new System.Windows.Forms.Panel();
            this.SubTotalValue = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.YourCart = new System.Windows.Forms.Label();
            this.PLACEHOLDER1 = new System.Windows.Forms.Label();
            this.CartSummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceYourOrderButton
            // 
            this.PlaceYourOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.PlaceYourOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlaceYourOrderButton.BorderColor = System.Drawing.Color.Transparent;
            this.PlaceYourOrderButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.PlaceYourOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlaceYourOrderButton.FlatAppearance.BorderSize = 0;
            this.PlaceYourOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceYourOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceYourOrderButton.ForeColor = System.Drawing.Color.Black;
            this.PlaceYourOrderButton.Location = new System.Drawing.Point(515, 628);
            this.PlaceYourOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlaceYourOrderButton.Name = "PlaceYourOrderButton";
            this.PlaceYourOrderButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PlaceYourOrderButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PlaceYourOrderButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PlaceYourOrderButton.Size = new System.Drawing.Size(345, 57);
            this.PlaceYourOrderButton.TabIndex = 6;
            this.PlaceYourOrderButton.Text = "Place Your Order";
            this.PlaceYourOrderButton.TextColor = System.Drawing.Color.Black;
            this.PlaceYourOrderButton.UseVisualStyleBackColor = false;
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
            this.PurchaseBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PurchaseBackButton.Name = "PurchaseBackButton";
            this.PurchaseBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PurchaseBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.Size = new System.Drawing.Size(245, 57);
            this.PurchaseBackButton.TabIndex = 7;
            this.PurchaseBackButton.Text = "BACK";
            this.PurchaseBackButton.TextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.UseVisualStyleBackColor = false;
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.PLACEHOLDER1);
            this.CartSummaryPanel.Controls.Add(this.SubTotalValue);
            this.CartSummaryPanel.Controls.Add(this.SubTotal);
            this.CartSummaryPanel.Controls.Add(this.YourCart);
            this.CartSummaryPanel.Location = new System.Drawing.Point(165, 133);
            this.CartSummaryPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(1033, 457);
            this.CartSummaryPanel.TabIndex = 8;
            // 
            // SubTotalValue
            // 
            this.SubTotalValue.AutoSize = true;
            this.SubTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalValue.Location = new System.Drawing.Point(875, 422);
            this.SubTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotalValue.Name = "SubTotalValue";
            this.SubTotalValue.Size = new System.Drawing.Size(40, 17);
            this.SubTotalValue.TabIndex = 2;
            this.SubTotalValue.Text = "0.00";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(763, 422);
            this.SubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(83, 17);
            this.SubTotal.TabIndex = 1;
            this.SubTotal.Text = "SubTotal: ";
            // 
            // YourCart
            // 
            this.YourCart.AutoSize = true;
            this.YourCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCart.Location = new System.Drawing.Point(425, 26);
            this.YourCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YourCart.Name = "YourCart";
            this.YourCart.Size = new System.Drawing.Size(151, 26);
            this.YourCart.TabIndex = 0;
            this.YourCart.Text = "YOUR CART";
            // 
            // PLACEHOLDER1
            // 
            this.PLACEHOLDER1.AutoSize = true;
            this.PLACEHOLDER1.Location = new System.Drawing.Point(474, 66);
            this.PLACEHOLDER1.Name = "PLACEHOLDER1";
            this.PLACEHOLDER1.Size = new System.Drawing.Size(55, 16);
            this.PLACEHOLDER1.TabIndex = 17;
            this.PLACEHOLDER1.Text = "cart png";
            // 
            // CartSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.CartSummaryPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Controls.Add(this.PlaceYourOrderButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CartSummary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1375, 738);
            this.CartSummaryPanel.ResumeLayout(false);
            this.CartSummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton PlaceYourOrderButton;
        private ePOSOne.btnProduct.RoundButton PurchaseBackButton;
        private System.Windows.Forms.Panel CartSummaryPanel;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label YourCart;
        private System.Windows.Forms.Label SubTotalValue;
        private System.Windows.Forms.Label PLACEHOLDER1;
    }
}
