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
    public partial class HomeScreen : UserControl
    {
        private readonly StartScreen _StartScreen;
        public HomeScreen()
        {
            InitializeComponent();
            
        }
        public HomeScreen(StartScreen StartScreen) : this()
        {
            _StartScreen = StartScreen;
        }

        private void StartScreenPurchaseButton_Click(object sender, EventArgs e)
        {
                _StartScreen.ShowUserControl(new Purchase(_StartScreen));
        }

        private void StartScreenConsultButton_Click(object sender, EventArgs e)
        {
            _StartScreen.ShowUserControl(new Purchase(_StartScreen));
        }

        private void StartScreenFooter_Click(object sender, EventArgs e)
        {

        }

        private void StartScreenBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
