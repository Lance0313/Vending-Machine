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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.StartScreenBackground = new System.Windows.Forms.PictureBox();
            this.StartScreenPanel = new System.Windows.Forms.Panel();
            this.StartScreenConsultButton = new ePOSOne.btnProduct.RoundButton();
            this.StartScreenFooter = new System.Windows.Forms.Label();
            this.StartScreenTitle = new System.Windows.Forms.Label();
            this.StartScreenPurchaseButton = new ePOSOne.btnProduct.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).BeginInit();
            this.StartScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartScreenBackground
            // 
            this.StartScreenBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartScreenBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartScreenBackground.Enabled = false;
            this.StartScreenBackground.Image = ((System.Drawing.Image)(resources.GetObject("StartScreenBackground.Image")));
            this.StartScreenBackground.Location = new System.Drawing.Point(0, -27);
            this.StartScreenBackground.Name = "StartScreenBackground";
            this.StartScreenBackground.Size = new System.Drawing.Size(1031, 670);
            this.StartScreenBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartScreenBackground.TabIndex = 6;
            this.StartScreenBackground.TabStop = false;
            // 
            // StartScreenPanel
            // 
            this.StartScreenPanel.Controls.Add(this.label2);
            this.StartScreenPanel.Controls.Add(this.label1);
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
            this.StartScreenConsultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenConsultButton.ForeColor = System.Drawing.Color.Black;
            this.StartScreenConsultButton.Location = new System.Drawing.Point(565, 386);
            this.StartScreenConsultButton.Name = "StartScreenConsultButton";
            this.StartScreenConsultButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.StartScreenConsultButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.StartScreenConsultButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenConsultButton.Size = new System.Drawing.Size(280, 76);
            this.StartScreenConsultButton.TabIndex = 10;
            this.StartScreenConsultButton.Text = "Get Suggestions";
            this.StartScreenConsultButton.TextColor = System.Drawing.Color.Black;
            this.StartScreenConsultButton.UseVisualStyleBackColor = false;
            this.StartScreenConsultButton.Click += new System.EventHandler(this.StartScreenConsultButton_Click);
            // 
            // StartScreenFooter
            // 
            this.StartScreenFooter.AutoSize = true;
            this.StartScreenFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(66)))));
            this.StartScreenFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenFooter.ForeColor = System.Drawing.Color.White;
            this.StartScreenFooter.Location = new System.Drawing.Point(369, 551);
            this.StartScreenFooter.Name = "StartScreenFooter";
            this.StartScreenFooter.Size = new System.Drawing.Size(310, 20);
            this.StartScreenFooter.TabIndex = 9;
            this.StartScreenFooter.Text = "© 2024 LMMN, Inc. All rights reserved";
            this.StartScreenFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartScreenFooter.Click += new System.EventHandler(this.StartScreenFooter_Click);
            // 
            // StartScreenTitle
            // 
            this.StartScreenTitle.AutoSize = true;
            this.StartScreenTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.StartScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenTitle.ForeColor = System.Drawing.Color.White;
            this.StartScreenTitle.Location = new System.Drawing.Point(100, 66);
            this.StartScreenTitle.Name = "StartScreenTitle";
            this.StartScreenTitle.Size = new System.Drawing.Size(821, 182);
            this.StartScreenTitle.TabIndex = 8;
            this.StartScreenTitle.Text = "SMART\r\nPharmaceutical Kiosk";
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
            this.StartScreenPurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenPurchaseButton.ForeColor = System.Drawing.Color.Black;
            this.StartScreenPurchaseButton.Location = new System.Drawing.Point(186, 386);
            this.StartScreenPurchaseButton.Name = "StartScreenPurchaseButton";
            this.StartScreenPurchaseButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.StartScreenPurchaseButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.StartScreenPurchaseButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenPurchaseButton.Size = new System.Drawing.Size(275, 67);
            this.StartScreenPurchaseButton.TabIndex = 7;
            this.StartScreenPurchaseButton.Text = "Purchase medicine";
            this.StartScreenPurchaseButton.TextColor = System.Drawing.Color.Black;
            this.StartScreenPurchaseButton.UseVisualStyleBackColor = false;
            this.StartScreenPurchaseButton.Click += new System.EventHandler(this.StartScreenPurchaseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Streamlined Over-the-Counter Medicine Dispensing Innovation";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
