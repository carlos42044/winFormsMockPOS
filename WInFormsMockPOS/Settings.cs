using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSettingsLib;

namespace WInFormsMockPOS
{
    public partial class Settings : Form
    {
        string filename = @"C:\Users\CarlosF\Documents\Visual Studio 2017\Projects\WInFormsMockPOS\WInFormsMockPOS\settings.config";
        Config config = new Config();

        public Form1 parent;

        public Settings(Form1 form1)
        {
            InitializeComponent();
            parent = form1;
            config.Read(filename);
            setRadioChecks();

        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadio("ButtonIsVisible");
        }

        private void radioDropdown_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadio("DropIsVisible");
        }

        private void radioImage_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadio("ImageIsVisible");
        }

        public void toggleRadio(string str) 
        {
            foreach(KeyValuePair<string, object> item in config.GetDict().ToList())
            {
                if (item.Key.Equals(str))
                {
                    config.Set(item.Key, "true");
                   // MessageBox.Show(str + " is now true");

                }
                else if (!item.Key.Equals("popupPay"))
                {
                    config.Set(item.Key, "false");
                }
            }

            config.Write(filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setRadioChecks()
        {
            if (config.Get("popupPay").Equals("true"))
            {
                popupWindow.Checked = true;
            }


            string radioChecked = "";

            foreach (KeyValuePair<string, object> item in config.GetDict().ToList())
            {
                if (!item.Key.Equals("popupPay") && item.Value.Equals("true"))
                {
                    radioChecked = (string)item.Key;
                }
            }

            switch (radioChecked)
            {
                case "LabelIsVisible":
                    MessageBox.Show("(labelisvis)initial key in config " + radioChecked);

                    radioLabel.Checked = true;
                    break;
                case "ButtonIsVisible":
                    MessageBox.Show("(bttns is vis)initial key in config " + radioChecked);

                    radioButton.Checked = true;
                    break;
                case "DropIsVisible":
                    MessageBox.Show("drops is vis: " + radioChecked);
                    radioDropdown.Checked = true;
                    break;
                case "ImageIsVisible":
                    MessageBox.Show("(imgisvis)initial key in config " + radioChecked);

                    radioImage.Checked = true;
                    break;
                default:
                    break;
            }
            //MessageBox.Show("initial key in config " + radioChecked);

        }

        private void radioWindow_CheckedChanged(object sender, EventArgs e)
        {
            config.Set("popupPay", "false");
            config.Write(filename);
        }

        private void PopupWindow_CheckedChanged(object sender, EventArgs e)
        {
            config.Set("popupPay", "true");
            config.Write(filename);
        }

        private void radioLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("reachedlabelradiocheckchange method");
            toggleRadio("LabelIsVisible");
        }
    }
}
