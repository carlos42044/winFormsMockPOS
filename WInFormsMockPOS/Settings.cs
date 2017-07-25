using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInFormsMockPOS
{
    public partial class Settings : Form
    {
        public Form1 parent;

        public Settings(Form1 form1)
        {
            InitializeComponent();
            parent = form1;
        }

        private void radioLabel_CheckedChanged(object sender, EventArgs e)
        {
            parent.ButtonIsVisible = false;
            parent.LabelIsVisible = true;
            parent.ImageIsVisible = false;

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            parent.ButtonIsVisible = true;
            parent.LabelIsVisible = false;
            parent.ImageIsVisible = false;

        }

        private void radioDropdown_CheckedChanged(object sender, EventArgs e)
        {
            // add dropdowsn is visible
            parent.ButtonIsVisible = false;
            parent.LabelIsVisible = false;
            parent.ImageIsVisible = false;
          
        }

        private void radioImage_CheckedChanged(object sender, EventArgs e)
        {
            parent.ButtonIsVisible = false;
            parent.LabelIsVisible = false;
            parent.ImageIsVisible = true;
            Properties.Settings.Default.Save();
        }
    }
}
