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
    public partial class Payment : UserControl
    {
        private readonly StartScreen _StartScreen;

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(StartScreen StartScreen, int totalPrice) : this()
        {
            _StartScreen = StartScreen;
            PaymentAmount.Text = $"Total Amount: \u20B1{totalPrice}";
        }

        private void PaymentBackButton_Click(object sender, EventArgs e)
        {
            _StartScreen.ShowUserControl(new Purchase(_StartScreen));
        }

        private void PaymentAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
