namespace AlphaPrototype
{
    partial class LagundiDesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LagundiDesc));
            this.MedPanel = new System.Windows.Forms.Panel();
            this.LagundiPicture = new System.Windows.Forms.PictureBox();
            this.AddToCart = new ePOSOne.btnProduct.RoundButton();
            this.LagundDesc = new System.Windows.Forms.Label();
            this.Lagundi = new System.Windows.Forms.Label();
            this.LagundiPrice = new System.Windows.Forms.Label();
            this.PurchaseBackButton = new ePOSOne.btnProduct.RoundButton();
            this.PLACEHOLDER1 = new System.Windows.Forms.Label();
            this.MedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LagundiPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MedPanel
            // 
            this.MedPanel.BackColor = System.Drawing.Color.White;
            this.MedPanel.Controls.Add(this.PLACEHOLDER1);
            this.MedPanel.Controls.Add(this.LagundiPicture);
            this.MedPanel.Controls.Add(this.AddToCart);
            this.MedPanel.Controls.Add(this.LagundDesc);
            this.MedPanel.Controls.Add(this.Lagundi);
            this.MedPanel.Controls.Add(this.LagundiPrice);
            this.MedPanel.Location = new System.Drawing.Point(82, 108);
            this.MedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MedPanel.Name = "MedPanel";
            this.MedPanel.Size = new System.Drawing.Size(1197, 577);
            this.MedPanel.TabIndex = 18;
            // 
            // LagundiPicture
            // 
            this.LagundiPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LagundiPicture.ErrorImage")));
            this.LagundiPicture.Image = ((System.Drawing.Image)(resources.GetObject("LagundiPicture.Image")));
            this.LagundiPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("LagundiPicture.InitialImage")));
            this.LagundiPicture.Location = new System.Drawing.Point(28, 43);
            this.LagundiPicture.Name = "LagundiPicture";
            this.LagundiPicture.Size = new System.Drawing.Size(546, 509);
            this.LagundiPicture.TabIndex = 9;
            this.LagundiPicture.TabStop = false;
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
            // LagundDesc
            // 
            this.LagundDesc.AutoSize = true;
            this.LagundDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagundDesc.Location = new System.Drawing.Point(589, 198);
            this.LagundDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LagundDesc.Name = "LagundDesc";
            this.LagundDesc.Size = new System.Drawing.Size(551, 200);
            this.LagundDesc.TabIndex = 7;
            this.LagundDesc.Text = resources.GetString("LagundDesc.Text");
            // 
            // Lagundi
            // 
            this.Lagundi.AutoSize = true;
            this.Lagundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lagundi.Location = new System.Drawing.Point(581, 92);
            this.Lagundi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lagundi.Name = "Lagundi";
            this.Lagundi.Size = new System.Drawing.Size(285, 48);
            this.Lagundi.TabIndex = 5;
            this.Lagundi.Text = "ASCOF Forte";
            this.Lagundi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LagundiPrice
            // 
            this.LagundiPrice.AutoSize = true;
            this.LagundiPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagundiPrice.Location = new System.Drawing.Point(587, 140);
            this.LagundiPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LagundiPrice.Name = "LagundiPrice";
            this.LagundiPrice.Size = new System.Drawing.Size(40, 39);
            this.LagundiPrice.TabIndex = 6;
            this.LagundiPrice.Text = "₱";
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
            this.PurchaseBackButton.TabIndex = 17;
            this.PurchaseBackButton.Text = "BACK";
            this.PurchaseBackButton.TextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.UseVisualStyleBackColor = false;
            // 
            // PLACEHOLDER1
            // 
            this.PLACEHOLDER1.AutoSize = true;
            this.PLACEHOLDER1.Location = new System.Drawing.Point(810, 475);
            this.PLACEHOLDER1.Name = "PLACEHOLDER1";
            this.PLACEHOLDER1.Size = new System.Drawing.Size(110, 16);
            this.PLACEHOLDER1.TabIndex = 20;
            this.PLACEHOLDER1.Text = "yung quantity box";
            // 
            // LagundiDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.MedPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Name = "LagundiDesc";
            this.Size = new System.Drawing.Size(1375, 738);
            this.MedPanel.ResumeLayout(false);
            this.MedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LagundiPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MedPanel;
        private System.Windows.Forms.PictureBox LagundiPicture;
        private ePOSOne.btnProduct.RoundButton AddToCart;
        private System.Windows.Forms.Label LagundDesc;
        private System.Windows.Forms.Label Lagundi;
        private System.Windows.Forms.Label LagundiPrice;
        private ePOSOne.btnProduct.RoundButton PurchaseBackButton;
        private System.Windows.Forms.Label PLACEHOLDER1;
    }
}
