namespace AlphaPrototype
{
    partial class LoperamideDesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoperamideDesc));
            this.MedPanel = new System.Windows.Forms.Panel();
            this.LoperamidePicture = new System.Windows.Forms.PictureBox();
            this.AddToCart = new ePOSOne.btnProduct.RoundButton();
            this.LoperaDesc = new System.Windows.Forms.Label();
            this.Loperamide = new System.Windows.Forms.Label();
            this.LoperamidePrice = new System.Windows.Forms.Label();
            this.PurchaseBackButton = new ePOSOne.btnProduct.RoundButton();
            this.PLACEHOLDER1 = new System.Windows.Forms.Label();
            this.MedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoperamidePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MedPanel
            // 
            this.MedPanel.BackColor = System.Drawing.Color.White;
            this.MedPanel.Controls.Add(this.PLACEHOLDER1);
            this.MedPanel.Controls.Add(this.LoperamidePicture);
            this.MedPanel.Controls.Add(this.AddToCart);
            this.MedPanel.Controls.Add(this.LoperaDesc);
            this.MedPanel.Controls.Add(this.Loperamide);
            this.MedPanel.Controls.Add(this.LoperamidePrice);
            this.MedPanel.Location = new System.Drawing.Point(82, 108);
            this.MedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MedPanel.Name = "MedPanel";
            this.MedPanel.Size = new System.Drawing.Size(1197, 577);
            this.MedPanel.TabIndex = 20;
            // 
            // LoperamidePicture
            // 
            this.LoperamidePicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LoperamidePicture.ErrorImage")));
            this.LoperamidePicture.Image = ((System.Drawing.Image)(resources.GetObject("LoperamidePicture.Image")));
            this.LoperamidePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("LoperamidePicture.InitialImage")));
            this.LoperamidePicture.Location = new System.Drawing.Point(28, 43);
            this.LoperamidePicture.Name = "LoperamidePicture";
            this.LoperamidePicture.Size = new System.Drawing.Size(546, 509);
            this.LoperamidePicture.TabIndex = 9;
            this.LoperamidePicture.TabStop = false;
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
            // LoperaDesc
            // 
            this.LoperaDesc.AutoSize = true;
            this.LoperaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoperaDesc.Location = new System.Drawing.Point(589, 198);
            this.LoperaDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoperaDesc.Name = "LoperaDesc";
            this.LoperaDesc.Size = new System.Drawing.Size(594, 250);
            this.LoperaDesc.TabIndex = 7;
            this.LoperaDesc.Text = resources.GetString("LoperaDesc.Text");
            // 
            // Loperamide
            // 
            this.Loperamide.AutoSize = true;
            this.Loperamide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loperamide.Location = new System.Drawing.Point(581, 92);
            this.Loperamide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loperamide.Name = "Loperamide";
            this.Loperamide.Size = new System.Drawing.Size(188, 48);
            this.Loperamide.TabIndex = 5;
            this.Loperamide.Text = "Imodium";
            this.Loperamide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Loperamide.Click += new System.EventHandler(this.Lagundi_Click);
            // 
            // LoperamidePrice
            // 
            this.LoperamidePrice.AutoSize = true;
            this.LoperamidePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoperamidePrice.Location = new System.Drawing.Point(587, 140);
            this.LoperamidePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoperamidePrice.Name = "LoperamidePrice";
            this.LoperamidePrice.Size = new System.Drawing.Size(40, 39);
            this.LoperamidePrice.TabIndex = 6;
            this.LoperamidePrice.Text = "₱";
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
            this.PurchaseBackButton.Location = new System.Drawing.Point(27, 27);
            this.PurchaseBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseBackButton.Name = "PurchaseBackButton";
            this.PurchaseBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PurchaseBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.Size = new System.Drawing.Size(245, 57);
            this.PurchaseBackButton.TabIndex = 19;
            this.PurchaseBackButton.Text = "BACK";
            this.PurchaseBackButton.TextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.UseVisualStyleBackColor = false;
            // 
            // PLACEHOLDER1
            // 
            this.PLACEHOLDER1.AutoSize = true;
            this.PLACEHOLDER1.Location = new System.Drawing.Point(805, 475);
            this.PLACEHOLDER1.Name = "PLACEHOLDER1";
            this.PLACEHOLDER1.Size = new System.Drawing.Size(110, 16);
            this.PLACEHOLDER1.TabIndex = 21;
            this.PLACEHOLDER1.Text = "yung quantity box";
            // 
            // LoperamideDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.MedPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Name = "LoperamideDesc";
            this.Size = new System.Drawing.Size(1375, 738);
            this.MedPanel.ResumeLayout(false);
            this.MedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoperamidePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MedPanel;
        private System.Windows.Forms.PictureBox LoperamidePicture;
        private ePOSOne.btnProduct.RoundButton AddToCart;
        private System.Windows.Forms.Label LoperaDesc;
        private System.Windows.Forms.Label Loperamide;
        private System.Windows.Forms.Label LoperamidePrice;
        private ePOSOne.btnProduct.RoundButton PurchaseBackButton;
        private System.Windows.Forms.Label PLACEHOLDER1;
    }
}
