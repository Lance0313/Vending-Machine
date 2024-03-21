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
    public partial class AscorbicDesc : UserControl
    {
        private readonly StartScreen _StartScreen;
        public AscorbicDesc()
        {
            InitializeComponent();
        }
        public AscorbicDesc(StartScreen StartScreen) : this()
        {
            _StartScreen = StartScreen;
        }
        private void AscorbicDesc_Load(object sender, EventArgs e)
        {

        }

        private void PurchaseBackButton_Click(object sender, EventArgs e)
        {
            _StartScreen.ShowUserControl(new Purchase(_StartScreen));
        }
    }
}
