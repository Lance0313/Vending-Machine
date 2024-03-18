using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaPrototype
{
    public partial class Purchase : UserControl
    {
        private readonly StartScreen _StartScreen;
        private int PurchaseBiogesicQuantity = 0;
        private int PurchaseNeozepQuantity = 0;
        private int PurchaseMefenamicQuantity = 0;
        private int PurchaseDiatabsQuantity = 0;
        private int PurchaseAdvilQuantity = 0;
        private int PurchaseCetirizineQuantity = 0;
        private const int BiogesicPrice = 8;
        private const int NeozepPrice = 10;
        private const int MefenamicPrice = 11;
        private const int DiatabsPrice = 12;
        private const int AdvilPrice = 10;
        private const int CetirizinePrice = 5;
        private int GetQuantity(string productName)
        {
            switch (productName)
            {
                case "Biogesic":
                    return Math.Max(0, PurchaseBiogesicQuantity);
                case "Neozep":
                    return Math.Max(0, PurchaseNeozepQuantity);
                case "Mefenamic Acid":
                    return Math.Max(0, PurchaseMefenamicQuantity);
                case "Diatabs":
                    return Math.Max(0, PurchaseDiatabsQuantity);
                case "Advil":
                    return Math.Max(0, PurchaseAdvilQuantity);
                case "Cetirizine":
                    return Math.Max(0, PurchaseCetirizineQuantity);
                default:
                    return 0;
            }
        }
        private int CalculateTotalPrice()
        {
            int total = PurchaseBiogesicQuantity * BiogesicPrice +
                        PurchaseNeozepQuantity * NeozepPrice +
                        PurchaseMefenamicQuantity * MefenamicPrice +
                        PurchaseDiatabsQuantity * DiatabsPrice +
                        PurchaseAdvilQuantity * AdvilPrice +
                        PurchaseCetirizineQuantity * CetirizinePrice;
            return total;
        }

        private void UpdateLabel(string productName, int totalPrice)
        {
            //Ensures non-negative
            totalPrice = Math.Max(0, totalPrice);
            // Check if a label for the product already exists
            int quantity = GetQuantity(productName);

            if (quantity == 0)
            {
                // Remove the label if it exists
                Label existingLabel = PurchaseCartText.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == productName + "Label");
                if (existingLabel != null)
                {
                    PurchaseCartText.Controls.Remove(existingLabel);
                }
            }
            else
            {
                // Check if a label for the product already exists
                Label existingLabel = PurchaseCartText.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == productName + "Label");

                if (existingLabel != null)
                {
                    // Update the existing label with new information
                    existingLabel.Text = $"{productName}: {quantity} - \u20B1{totalPrice}";
                }
                else
                {
                    // Create and configure the label
                    Label newLabel = new Label();
                    newLabel.Name = productName + "Label";
                    newLabel.Text = $"{productName}: {quantity} - \u20B1{totalPrice}";
                    newLabel.AutoSize = true;

                    // Calculate Y-position for the label
                    int newY = PurchaseCartText.Controls.Count * newLabel.Height;

                    // Set the location of the label
                    newLabel.Location = new System.Drawing.Point(0, newY);

                    // Add the label to the panel
                    PurchaseCartText.Controls.Add(newLabel);
                }
            }
        }


        public Purchase()
        {
            InitializeComponent();
        }
        public Purchase(StartScreen StartScreen) : this()
        {
            _StartScreen = StartScreen;
        }

        private void PurchaseResetButton_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseCheckoutButton_Click(object sender, EventArgs e)
        {
            if (PurchaseCartText.Controls.Count == 0)
            {
                MessageBox.Show("Please add items to the order before checking out.");
                return;
            }
            int totalPrice = CalculateTotalPrice();
            _StartScreen.ShowUserControl(new Payment(_StartScreen, totalPrice));
        }

        private void PurchaseAddBiogesic_Click(object sender, EventArgs e)
        {
            PurchaseBiogesicQuantity++;
            UpdateLabel("Biogesic", PurchaseBiogesicQuantity * BiogesicPrice);
            PurchaseMinusBiogesic.Enabled = true;
        }
        private void PurchaseMinusBiogesic_Click(object sender, EventArgs e)
        {
            PurchaseBiogesicQuantity--;
            UpdateLabel("Biogesic", PurchaseBiogesicQuantity * BiogesicPrice);
            PurchaseMinusBiogesic.Enabled = PurchaseBiogesicQuantity > 0;
        }

        private void PurchaseAddMefenamic_Click(object sender, EventArgs e)
        {
            PurchaseMefenamicQuantity++;
            UpdateLabel("Mefenamic Acid", PurchaseMefenamicQuantity * MefenamicPrice);
            PurchaseMinusMefenamic.Enabled = true;
        }

        private void PurchaseMinusMefenamic_Click(object sender, EventArgs e)
        {
            PurchaseMefenamicQuantity--;
            UpdateLabel("Mefenamic Acid", PurchaseMefenamicQuantity * MefenamicPrice);
            PurchaseMinusMefenamic.Enabled = PurchaseMefenamicQuantity > 0;
        }

        private void PurchaseAddAdvil_Click(object sender, EventArgs e)
        {
            PurchaseAdvilQuantity++;
            UpdateLabel("Advil", PurchaseAdvilQuantity * AdvilPrice);
            PurchaseMinusAdvil.Enabled = true;
        }

        private void PurchaseMinusAdvil_Click(object sender, EventArgs e)
        {
            PurchaseAdvilQuantity--;
            UpdateLabel("Advil", PurchaseAdvilQuantity * AdvilPrice);
            PurchaseMinusAdvil.Enabled = PurchaseAdvilQuantity > 0;
        }

        private void PurchaseMinusCetirizine_Click(object sender, EventArgs e)
        {
            PurchaseCetirizineQuantity--;
            UpdateLabel("Cetirizine", PurchaseCetirizineQuantity * CetirizinePrice);
            PurchaseMinusCetirizine.Enabled = PurchaseCetirizineQuantity > 0;

        }

        private void PurchaseAddCetirizine_Click(object sender, EventArgs e)
        {
            PurchaseCetirizineQuantity++;
            UpdateLabel("Cetirizine", PurchaseCetirizineQuantity * CetirizinePrice);
            PurchaseMinusCetirizine.Enabled = true;
        }

        private void PurchaseMinusDiatabs_Click(object sender, EventArgs e)
        {
            PurchaseDiatabsQuantity--;
            UpdateLabel("Diatabs", PurchaseDiatabsQuantity * DiatabsPrice);
            PurchaseMinusDiatabs.Enabled = PurchaseDiatabsQuantity > 0;
        }

        private void PurchaseAddDiatabs_Click(object sender, EventArgs e)
        {
            PurchaseDiatabsQuantity++;
            UpdateLabel("Diatabs", PurchaseDiatabsQuantity * DiatabsPrice);
            PurchaseMinusDiatabs.Enabled = true;
        }

        private void PurchaseAddNeozep_Click(object sender, EventArgs e)
        {
            PurchaseNeozepQuantity++;
            UpdateLabel("Neozep", PurchaseNeozepQuantity * NeozepPrice);
            PurchaseMinusNeozep.Enabled = true;
        }

        private void PurchaseMinusNeozep_Click(object sender, EventArgs e)
        {
            PurchaseNeozepQuantity--;
            UpdateLabel("Neozep", PurchaseNeozepQuantity * NeozepPrice);
            PurchaseMinusNeozep.Enabled = PurchaseNeozepQuantity > 0;
        }

        private void PurchaseBackButton_Click(object sender, EventArgs e)
        {
            _StartScreen.ShowUserControl(new HomeScreen(_StartScreen));
        }
    }
}
