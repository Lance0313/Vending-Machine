namespace AlphaPrototype
{
    partial class BonamineDesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonamineDesc));
            this.MedPanel = new System.Windows.Forms.Panel();
            this.BonaminePicture = new System.Windows.Forms.PictureBox();
            this.AddToCart = new ePOSOne.btnProduct.RoundButton();
            this.BonaDesc = new System.Windows.Forms.Label();
            this.Bonamine = new System.Windows.Forms.Label();
            this.BonaminePrice = new System.Windows.Forms.Label();
            this.PurchaseBackButton = new ePOSOne.btnProduct.RoundButton();
            this.PLACEHOLDER1 = new System.Windows.Forms.Label();
            this.MedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BonaminePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MedPanel
            // 
            this.MedPanel.BackColor = System.Drawing.Color.White;
            this.MedPanel.Controls.Add(this.PLACEHOLDER1);
            this.MedPanel.Controls.Add(this.BonaminePicture);
            this.MedPanel.Controls.Add(this.AddToCart);
            this.MedPanel.Controls.Add(this.BonaDesc);
            this.MedPanel.Controls.Add(this.Bonamine);
            this.MedPanel.Controls.Add(this.BonaminePrice);
            this.MedPanel.Location = new System.Drawing.Point(83, 108);
            this.MedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MedPanel.Name = "MedPanel";
            this.MedPanel.Size = new System.Drawing.Size(1197, 577);
            this.MedPanel.TabIndex = 12;
            // 
            // BonaminePicture
            // 
            this.BonaminePicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BonaminePicture.ErrorImage")));
            this.BonaminePicture.Image = ((System.Drawing.Image)(resources.GetObject("BonaminePicture.Image")));
            this.BonaminePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("BonaminePicture.InitialImage")));
            this.BonaminePicture.Location = new System.Drawing.Point(28, 43);
            this.BonaminePicture.Name = "BonaminePicture";
            this.BonaminePicture.Size = new System.Drawing.Size(546, 509);
            this.BonaminePicture.TabIndex = 9;
            this.BonaminePicture.TabStop = false;
            // 
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.Color.Transparent;
            this.AddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddToCart.BorderColor = System.Drawing.Color.Transparent;
            this.AddToCart.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.AddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToCart.FlatAppearance.BorderSize = 0;
            this.AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCart.ForeColor = System.Drawing.Color.Black;
            this.AddToCart.Location = new System.Drawing.Point(686, 495);
            this.AddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AddToCart.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.AddToCart.OnHoverTextColor = System.Drawing.Color.Black;
            this.AddToCart.Size = new System.Drawing.Size(345, 57);
            this.AddToCart.TabIndex = 8;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.TextColor = System.Drawing.Color.Black;
            this.AddToCart.UseVisualStyleBackColor = false;
            // 
            // BonaDesc
            // 
            this.BonaDesc.AutoSize = true;
            this.BonaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonaDesc.Location = new System.Drawing.Point(589, 198);
            this.BonaDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BonaDesc.Name = "BonaDesc";
            this.BonaDesc.Size = new System.Drawing.Size(554, 250);
            this.BonaDesc.TabIndex = 7;
            this.BonaDesc.Text = resources.GetString("BonaDesc.Text");
            // 
            // Bonamine
            // 
            this.Bonamine.AutoSize = true;
            this.Bonamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonamine.Location = new System.Drawing.Point(581, 92);
            this.Bonamine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bonamine.Name = "Bonamine";
            this.Bonamine.Size = new System.Drawing.Size(216, 48);
            this.Bonamine.TabIndex = 5;
            this.Bonamine.Text = "Bonamine";
            // 
            // BonaminePrice
            // 
            this.BonaminePrice.AutoSize = true;
            this.BonaminePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonaminePrice.Location = new System.Drawing.Point(587, 140);
            this.BonaminePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BonaminePrice.Name = "BonaminePrice";
            this.BonaminePrice.Size = new System.Drawing.Size(40, 39);
            this.BonaminePrice.TabIndex = 6;
            this.BonaminePrice.Text = "₱";
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
            this.PurchaseBackButton.Location = new System.Drawing.Point(28, 27);
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
            // PLACEHOLDER1
            // 
            this.PLACEHOLDER1.AutoSize = true;
            this.PLACEHOLDER1.Location = new System.Drawing.Point(798, 475);
            this.PLACEHOLDER1.Name = "PLACEHOLDER1";
            this.PLACEHOLDER1.Size = new System.Drawing.Size(110, 16);
            this.PLACEHOLDER1.TabIndex = 19;
            this.PLACEHOLDER1.Text = "yung quantity box";
            // 
            // BonamineDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.MedPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Name = "BonamineDesc";
            this.Size = new System.Drawing.Size(1375, 738);
            this.MedPanel.ResumeLayout(false);
            this.MedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BonaminePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MedPanel;
        private System.Windows.Forms.PictureBox BonaminePicture;
        private ePOSOne.btnProduct.RoundButton AddToCart;
        private System.Windows.Forms.Label BonaDesc;
        private System.Windows.Forms.Label Bonamine;
        private System.Windows.Forms.Label BonaminePrice;
        private ePOSOne.btnProduct.RoundButton PurchaseBackButton;
        private System.Windows.Forms.Label PLACEHOLDER1;
    }
}
