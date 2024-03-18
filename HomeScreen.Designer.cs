namespace AlphaPrototype
{
    partial class HomeScreen
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
            this.StartScreenBackground = new System.Windows.Forms.PictureBox();
            this.StartScreenPanel = new System.Windows.Forms.Panel();
            this.StartScreenConsultButton = new ePOSOne.btnProduct.RoundButton();
            this.StartScreenFooter = new System.Windows.Forms.Label();
            this.StartScreenTitle = new System.Windows.Forms.Label();
            this.StartScreenPurchaseButton = new ePOSOne.btnProduct.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).BeginInit();
            this.StartScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartScreenBackground
            // 
            this.StartScreenBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartScreenBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartScreenBackground.Enabled = false;
            this.StartScreenBackground.Image = global::AlphaPrototype.Properties.Resources.Home;
            this.StartScreenBackground.Location = new System.Drawing.Point(0, 0);
            this.StartScreenBackground.Name = "StartScreenBackground";
            this.StartScreenBackground.Size = new System.Drawing.Size(1028, 600);
            this.StartScreenBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartScreenBackground.TabIndex = 6;
            this.StartScreenBackground.TabStop = false;
            // 
            // StartScreenPanel
            // 
            this.StartScreenPanel.Controls.Add(this.StartScreenConsultButton);
            this.StartScreenPanel.Controls.Add(this.StartScreenFooter);
            this.StartScreenPanel.Controls.Add(this.StartScreenTitle);
            this.StartScreenPanel.Controls.Add(this.StartScreenPurchaseButton);
            this.StartScreenPanel.Controls.Add(this.StartScreenBackground);
            this.StartScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.StartScreenPanel.Name = "StartScreenPanel";
            this.StartScreenPanel.Size = new System.Drawing.Size(1028, 600);
            this.StartScreenPanel.TabIndex = 1;
            // 
            // StartScreenConsultButton
            // 
            this.StartScreenConsultButton.BackColor = System.Drawing.Color.Transparent;
            this.StartScreenConsultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartScreenConsultButton.BorderColor = System.Drawing.Color.Transparent;
            this.StartScreenConsultButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.StartScreenConsultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartScreenConsultButton.FlatAppearance.BorderSize = 0;
            this.StartScreenConsultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartScreenConsultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenConsultButton.ForeColor = System.Drawing.Color.Black;
            this.StartScreenConsultButton.Location = new System.Drawing.Point(571, 345);
            this.StartScreenConsultButton.Name = "StartScreenConsultButton";
            this.StartScreenConsultButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.StartScreenConsultButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.StartScreenConsultButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenConsultButton.Size = new System.Drawing.Size(200, 46);
            this.StartScreenConsultButton.TabIndex = 10;
            this.StartScreenConsultButton.Text = "Consult first";
            this.StartScreenConsultButton.TextColor = System.Drawing.Color.Black;
            this.StartScreenConsultButton.UseVisualStyleBackColor = false;
            // 
            // StartScreenFooter
            // 
            this.StartScreenFooter.AutoSize = true;
            this.StartScreenFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(66)))));
            this.StartScreenFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenFooter.ForeColor = System.Drawing.Color.White;
            this.StartScreenFooter.Location = new System.Drawing.Point(377, 533);
            this.StartScreenFooter.Name = "StartScreenFooter";
            this.StartScreenFooter.Size = new System.Drawing.Size(310, 20);
            this.StartScreenFooter.TabIndex = 9;
            this.StartScreenFooter.Text = "© 2024 LMMN, Inc. All rights reserved";
            this.StartScreenFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartScreenTitle
            // 
            this.StartScreenTitle.AutoSize = true;
            this.StartScreenTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.StartScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenTitle.ForeColor = System.Drawing.Color.White;
            this.StartScreenTitle.Location = new System.Drawing.Point(282, 20);
            this.StartScreenTitle.Name = "StartScreenTitle";
            this.StartScreenTitle.Size = new System.Drawing.Size(489, 219);
            this.StartScreenTitle.TabIndex = 8;
            this.StartScreenTitle.Text = "SMART\r\nPharmaceutical\r\nKiosk";
            this.StartScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartScreenPurchaseButton
            // 
            this.StartScreenPurchaseButton.BackColor = System.Drawing.Color.Transparent;
            this.StartScreenPurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartScreenPurchaseButton.BorderColor = System.Drawing.Color.Transparent;
            this.StartScreenPurchaseButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.StartScreenPurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartScreenPurchaseButton.FlatAppearance.BorderSize = 0;
            this.StartScreenPurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartScreenPurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenPurchaseButton.ForeColor = System.Drawing.Color.Black;
            this.StartScreenPurchaseButton.Location = new System.Drawing.Point(295, 345);
            this.StartScreenPurchaseButton.Name = "StartScreenPurchaseButton";
            this.StartScreenPurchaseButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.StartScreenPurchaseButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.StartScreenPurchaseButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenPurchaseButton.Size = new System.Drawing.Size(200, 46);
            this.StartScreenPurchaseButton.TabIndex = 7;
            this.StartScreenPurchaseButton.Text = "Purchase medicine";
            this.StartScreenPurchaseButton.TextColor = System.Drawing.Color.Black;
            this.StartScreenPurchaseButton.UseVisualStyleBackColor = false;
            this.StartScreenPurchaseButton.Click += new System.EventHandler(this.StartScreenPurchaseButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartScreenPanel);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1028, 600);
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).EndInit();
            this.StartScreenPanel.ResumeLayout(false);
            this.StartScreenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartScreenBackground;
        private System.Windows.Forms.Panel StartScreenPanel;
        private ePOSOne.btnProduct.RoundButton StartScreenConsultButton;
        private System.Windows.Forms.Label StartScreenFooter;
        private System.Windows.Forms.Label StartScreenTitle;
        private ePOSOne.btnProduct.RoundButton StartScreenPurchaseButton;
    }
}
