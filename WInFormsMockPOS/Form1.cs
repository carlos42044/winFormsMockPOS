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
    public partial class Form1 : Form
    {
        Employee[] user = new Employee[5];
        Product[] items = new Product[6];
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        Employee currentUser;
        double runningTotal = 0.00;

        public Form1()
        {
            updateName();
            updateProducts();
            InitializeComponent();
            currentUser = user[new Random().Next(0, 5)];
            username.Text = currentUser.getFirstName();
            timer1.Start();
            createTableHeaders();
        }

        private void createTableHeaders()
        {
            table.Columns.Add(new DataColumn("Description", typeof(String)));
            table.Columns.Add(new DataColumn("Price", typeof(double)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            table.Columns.Add(new DataColumn("Total", typeof(double)));
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = table.DefaultView;

            table2.Columns.Add(new DataColumn("Stamp", typeof(String)));
            table2.Columns.Add(new DataColumn("User", typeof(String)));
            table2.Columns.Add(new DataColumn("Total", typeof(double)));
            table2.Columns.Add(new DataColumn("Tendered", typeof(double)));
            table2.Columns.Add(new DataColumn("Change", typeof(double)));

            dataGridView2.DataSource = table2.DefaultView;

        }

        private void WinFormsMockPOS_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateName()
        {
            String[] users = { "Mike", "Joe", "Samanatha", "Liz", "Evan" };

            for (int i = 0; i < users.Length; i++)
            {
                user[i] = new Employee(users[i], "Unkown");
            }
        }

        private void updateProducts()
        {
            String[] products = { "Asiago", "Chedder", "Parmesan", "Swiss", "American", "PepperJack" };
            double[] prices = { .99, 1.20, .50, 1.25, 1.99, 1.12 };

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Product(products[i], prices[i]);
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            currentUser = user[new Random().Next(0, 5)];
            username.Text = currentUser.getFirstName();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongTimeString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Product newItem = items[rnd.Next(0, items.Length)];
            int quantity = rnd.Next(1, 4);
            double total = (double)quantity * newItem.getPrice();

            table.Rows.Add(new Object[] {newItem.getProductName(), newItem.getPrice(), quantity, total});
            runningTotal += total;

            // attempting to format double in to "money" x.xx
            totalLabel.Text = String.Format("{0:#.00}", runningTotal.ToString());
            updateRequired();
        }

        private void updateRequired()
        {
            required.Text = "required: " + (0.0 - runningTotal).ToString();
            required.ForeColor = System.Drawing.Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add.Enabled = false;
            clear.Enabled = false;
            pay.Enabled = false;
            tendered.Visible = true;
            required.Visible = true;
            process.Visible = true;
            cancel.Visible = true;

            updateRequired();
        }

        private void updateTenderedRequired()
        {
            updateRequired();

            try
            {
                double currentEntered = Convert.ToDouble(tendered.Text);
                if (runningTotal - currentEntered == 0)
                {
                    required.ForeColor = System.Drawing.Color.Black;
                    required.Text = "change: " + 0;
                    process.Enabled = true;
                }
                else if (runningTotal - currentEntered > 0)
                {
                    required.Text = "required: " + (runningTotal - currentEntered);
                    process.Enabled = false;
                }
                else if (runningTotal - currentEntered < 0)
                {
                    required.ForeColor = System.Drawing.Color.Black;
                    required.Text = "change: " + Math.Abs(runningTotal - currentEntered);
                    process.Enabled = true;
                }

            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.ToString());
            }
        }

        private void tendered_TextChanged(object sender, EventArgs e)
        {
            updateTenderedRequired();
        }

        private void process_Click(object sender, EventArgs e)
        {
            String stamp = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            double tenderEntered = Convert.ToDouble(tendered.Text);


            table2.Rows.Add(new Object[] {stamp, currentUser.getFirstName(), runningTotal, tenderEntered, Math.Abs(runningTotal-tenderEntered)});

            runningTotal = 0;
            totalLabel.Text = "0.00";
            tendered.Text = "0.00";
            required.Visible = false;
            process.Visible = false;
            cancel.Visible = false;

            //dataGridView1.DataSource = null;
            table.Rows.Clear();
            //dataGridView1.Refresh();
            //dataGridView1.DataSource = table.DefaultView;

            add.Enabled = true;
            clear.Enabled = true;
            pay.Enabled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            runningTotal = 0;
            totalLabel.Text = "0.00";

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            process.Visible = false;
            cancel.Visible = false;
            tendered.Visible = false;
            required.Visible = false;
            pay.Enabled = false;
            add.Enabled = true;
            clear.Enabled = true;
        }
    }
}
