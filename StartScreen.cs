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

    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            ShowUserControl(new HomeScreen(this)); // Show the initial user control
        }

        public void ShowUserControl(UserControl userControl)
        {
            Controls.Clear(); // Remove all existing controls
            Controls.Add(userControl); // Add the new user control
            userControl.Dock = DockStyle.Fill; // Dock the user control to fill the form
        }
    }
}


