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
    public partial class Popup : Form
    {
        double runningTotal = Form1.runningTotal;
        string user = Form1.User;
        string total = Form1.Total;
        string req = Form1.Required;
        string tenderEntered = Form1.TenderEntered;
        

        public Popup()
        {  
            InitializeComponent();
            
            totalLabel.Text = total;
            
          //  MessageBox.Show(total + " required: " + req + "\nStamp: " + stamp + "\nuser: " + user + "\ntotal: " + total + "\nchange: " + change);
            required.Visible = true;
            required.Text = req;
        }

        private void process_Click(object sender, EventArgs e)
        {
            string stamp = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            string change = String.Format("{0:#.00}", Math.Abs(runningTotal - Convert.ToDouble(tenderTextBox.Text)).ToString());
            string total = String.Format("{0:#.00}", runningTotal.ToString());

            Form1.table2.Rows.Add(new Object[] { stamp, user, total, String.Format("{0:#.00}", String.Format("{0:#.00}",tenderTextBox.Text)), change });        
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tenderTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double currentEntered = Convert.ToDouble(tenderTextBox.Text);
                string currentRequired = String.Format("{0:#.00}", (runningTotal - currentEntered));

                if (runningTotal - currentEntered == 0 || currentRequired.Equals(".00"))
                {
                    required.ForeColor = System.Drawing.Color.Black;
                    
                    required.Text =  "change: " + 0;
                    process.Enabled = true;
                }
                else if (runningTotal - currentEntered > 0)
                {
                    required.Text = "required: " + String.Format("{0:#.00}", (runningTotal - currentEntered));             
                    process.Enabled = false;
                }
                else if (runningTotal - currentEntered < 0)
                {
                    required.ForeColor = System.Drawing.Color.Black;
                    required.Text = "change: " + String.Format("{0:#.00}", (Math.Abs(runningTotal - currentEntered)));
                 
                    process.Enabled = true;
                }

            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.ToString());
            }
        }
    }
}
