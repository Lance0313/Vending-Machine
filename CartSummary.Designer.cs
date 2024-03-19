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
            this.YourCart = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.SubTotalValue = new System.Windows.Forms.Label();
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
            this.PlaceYourOrderButton.Location = new System.Drawing.Point(386, 510);
            this.PlaceYourOrderButton.Name = "PlaceYourOrderButton";
            this.PlaceYourOrderButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PlaceYourOrderButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PlaceYourOrderButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PlaceYourOrderButton.Size = new System.Drawing.Size(259, 46);
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
            this.PurchaseBackButton.Location = new System.Drawing.Point(20, 29);
            this.PurchaseBackButton.Name = "PurchaseBackButton";
            this.PurchaseBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PurchaseBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.Size = new System.Drawing.Size(184, 46);
            this.PurchaseBackButton.TabIndex = 7;
            this.PurchaseBackButton.Text = "BACK";
            this.PurchaseBackButton.TextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.UseVisualStyleBackColor = false;
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.SubTotalValue);
            this.CartSummaryPanel.Controls.Add(this.SubTotal);
            this.CartSummaryPanel.Controls.Add(this.YourCart);
            this.CartSummaryPanel.Location = new System.Drawing.Point(124, 108);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(775, 371);
            this.CartSummaryPanel.TabIndex = 8;
            // 
            // YourCart
            // 
            this.YourCart.AutoSize = true;
            this.YourCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCart.Location = new System.Drawing.Point(319, 21);
            this.YourCart.Name = "YourCart";
            this.YourCart.Size = new System.Drawing.Size(126, 22);
            this.YourCart.TabIndex = 0;
            this.YourCart.Text = "YOUR CART";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(572, 343);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(66, 13);
            this.SubTotal.TabIndex = 1;
            this.SubTotal.Text = "SubTotal: ";
            // 
            // SubTotalValue
            // 
            this.SubTotalValue.AutoSize = true;
            this.SubTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalValue.Location = new System.Drawing.Point(656, 343);
            this.SubTotalValue.Name = "SubTotalValue";
            this.SubTotalValue.Size = new System.Drawing.Size(32, 13);
            this.SubTotalValue.TabIndex = 2;
            this.SubTotalValue.Text = "0.00";
            // 
            // CartSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.CartSummaryPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Controls.Add(this.PlaceYourOrderButton);
            this.Name = "CartSummary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1031, 600);
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
    }
}
