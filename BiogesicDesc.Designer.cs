namespace AlphaPrototype
{
    partial class BiogesicDesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiogesicDesc));
            this.Biogesic = new System.Windows.Forms.Label();
            this.BiogesicPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToCart = new ePOSOne.btnProduct.RoundButton();
            this.PurchaseBackButton = new ePOSOne.btnProduct.RoundButton();
            this.PurchaseBiogesic = new System.Windows.Forms.PictureBox();
            this.CartSummaryPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBiogesic)).BeginInit();
            this.CartSummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Biogesic
            // 
            this.Biogesic.AutoSize = true;
            this.Biogesic.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biogesic.Location = new System.Drawing.Point(436, 75);
            this.Biogesic.Name = "Biogesic";
            this.Biogesic.Size = new System.Drawing.Size(155, 39);
            this.Biogesic.TabIndex = 5;
            this.Biogesic.Text = "Biogesic";
            // 
            // BiogesicPrice
            // 
            this.BiogesicPrice.AutoSize = true;
            this.BiogesicPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiogesicPrice.Location = new System.Drawing.Point(440, 114);
            this.BiogesicPrice.Name = "BiogesicPrice";
            this.BiogesicPrice.Size = new System.Drawing.Size(85, 31);
            this.BiogesicPrice.TabIndex = 6;
            this.BiogesicPrice.Text = "₱8.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 180);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
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
            this.AddToCart.Location = new System.Drawing.Point(513, 380);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AddToCart.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.AddToCart.OnHoverTextColor = System.Drawing.Color.Black;
            this.AddToCart.Size = new System.Drawing.Size(259, 46);
            this.AddToCart.TabIndex = 8;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.TextColor = System.Drawing.Color.Black;
            this.AddToCart.UseVisualStyleBackColor = false;
            this.AddToCart.Click += new System.EventHandler(this.PlaceYourOrderButton_Click);
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
            this.PurchaseBackButton.Location = new System.Drawing.Point(21, 22);
            this.PurchaseBackButton.Name = "PurchaseBackButton";
            this.PurchaseBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PurchaseBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PurchaseBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.Size = new System.Drawing.Size(184, 46);
            this.PurchaseBackButton.TabIndex = 9;
            this.PurchaseBackButton.Text = "BACK";
            this.PurchaseBackButton.TextColor = System.Drawing.Color.Black;
            this.PurchaseBackButton.UseVisualStyleBackColor = false;
            // 
            // PurchaseBiogesic
            // 
            this.PurchaseBiogesic.Image = global::AlphaPrototype.Properties.Resources.Biogesic;
            this.PurchaseBiogesic.Location = new System.Drawing.Point(15, 15);
            this.PurchaseBiogesic.Name = "PurchaseBiogesic";
            this.PurchaseBiogesic.Size = new System.Drawing.Size(406, 431);
            this.PurchaseBiogesic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PurchaseBiogesic.TabIndex = 4;
            this.PurchaseBiogesic.TabStop = false;
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.AddToCart);
            this.CartSummaryPanel.Controls.Add(this.PurchaseBiogesic);
            this.CartSummaryPanel.Controls.Add(this.label3);
            this.CartSummaryPanel.Controls.Add(this.Biogesic);
            this.CartSummaryPanel.Controls.Add(this.BiogesicPrice);
            this.CartSummaryPanel.Location = new System.Drawing.Point(62, 88);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(898, 469);
            this.CartSummaryPanel.TabIndex = 10;
            this.CartSummaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CartSummaryPanel_Paint);
            // 
            // BiogesicDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.CartSummaryPanel);
            this.Controls.Add(this.PurchaseBackButton);
            this.Name = "BiogesicDesc";
            this.Size = new System.Drawing.Size(1031, 600);
            this.Load += new System.EventHandler(this.BiogesicDesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBiogesic)).EndInit();
            this.CartSummaryPanel.ResumeLayout(false);
            this.CartSummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Biogesic;
        private System.Windows.Forms.Label BiogesicPrice;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.RoundButton AddToCart;
        private ePOSOne.btnProduct.RoundButton PurchaseBackButton;
        private System.Windows.Forms.PictureBox PurchaseBiogesic;
        private System.Windows.Forms.Panel CartSummaryPanel;
    }
}
