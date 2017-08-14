using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using AppSettingsLib;
using System.IO;


namespace WInFormsMockPOS
{
    public partial class Form1 : Form
    {

        // Path to the settings.config file
        public static string filename = @System.IO.Path.ChangeExtension(System.Reflection.Assembly.GetExecutingAssembly().Location, ".config");// + "\\settings.config";

        Config config = new Config();

        // Variables for Employee and Product objects
        Employee[] user = new Employee[5];
        List<Product> items = new List<Product>();
        Employee currentUser;

        // Variables for the productData set
        public static string productData;
        public static string productFilename = @Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\proudcts-" + productData + ".xml";

        // Table variables
        public static DataTable  table = new DataTable();
        public static DataTable table2 = new DataTable();

        // Variables to store transaction information (global variables for the 2 forms)
        public static string Stamp { get; set; }
        public static string User { get; set; }
        public static string Total { get; set; }
        public static string TenderEntered { get; set; }
        public static string Change { get; set; }
        public static string Required { get; set; }
        public static bool processClicked = false;

        public bool ButtonIsVisible
        {
            get { return nameBtn.Visible; }
            set { nameBtn.Visible = value; }
        }

        public bool LabelIsVisible
        {
            get { return username.Visible; }
            set { username.Visible = value; }
        }

        public bool ImageIsVisible
        {
            get { return pictureBox1.Visible; }
            set { pictureBox1.Visible = value; }
        }

        public bool DropIsVisble
        {
            get { return comboBox1.Visible; }
            set { comboBox1.Visible = value; }
        }

        // Global variable to hold total
        public static double runningTotal = 0.00;

        public Form1()
        {
            updateName();
            InitializeComponent();
            currentUser = user[new Random().Next(0, 5)];
            User = currentUser.getFirstName();
            username.Text = currentUser.getFirstName();
            timer1.Start();

            if (!System.IO.File.Exists(filename))
            {
                config.Set("LabelIsVisible", "true");
                config.Set("ButtonIsVisible", "false");
                config.Set("ImageIsVisible", "false");
                config.Set("DropIsVisible", "false");
                config.Set("popupPay", "false");
                config.Set("ProductNuts", "Nuts");
                config.Set("ProductFruit", "Fruits");
                config.Set("ProductVegetables", "Vegetables");
                config.Set("ProductCheese", "Cheeses");
                config.Set("selectedProduct", "Nuts");
                config.Write(filename);
                config.Read(filename);
            }

            try
            {
                createTableHeaders();
            } catch (Exception e)
            {

            }
            pay.Enabled = false;

            // setting usernames for image, button, dropdown
            pictureBox1.Image = TextToImage.CreateImageFromText(User);
            pictureBox1.Enabled = true;
            nameBtn.Text = User;
            comboBox1.Items.Add(User);
            comboBox1.SelectedIndex = 0;

            string initUser = User;
            foreach(Employee employee in user)
            {
                if(!(employee.Equals(initUser)))
                {
                    comboBox1.Items.Add(employee.getFirstName());
                }
            }

            config.Read(filename);

            productData = (string)config.Get("selectedProduct");
            productFilename = @Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\proudcts-" + productData + ".xml";
            updateProducts();

            ButtonIsVisible = stringToBool((string)config.Get("ButtonIsVisible"));  
            LabelIsVisible = stringToBool((string)config.Get("LabelIsVisible"));
            ImageIsVisible = stringToBool((string)config.Get("ImageIsVisible"));
            DropIsVisble = stringToBool((string)config.Get("DropIsVisible"));
        }

        public bool stringToBool(string str)
        {
            return str.Equals("true") ? true : false;
        }

      

        private void createTableHeaders()
        {
            // Headers for the cart table
            table.Columns.Add(new DataColumn("Description", typeof(String)));
            table.Columns.Add(new DataColumn("Price", typeof(String)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            table.Columns.Add(new DataColumn("Total", typeof(String)));
            dataGridView1.DataSource = table.DefaultView;

            // Headers for the transaction table
            table2.Columns.Add(new DataColumn("Stamp", typeof(String)));
            table2.Columns.Add(new DataColumn("User", typeof(String)));
            table2.Columns.Add(new DataColumn("Total", typeof(String)));
            table2.Columns.Add(new DataColumn("Tendered", typeof(String)));
            table2.Columns.Add(new DataColumn("Change", typeof(String)));

            dataGridView2.DataSource = table2.DefaultView;

        }

        private void WinFormsMockPOS_Load(object sender, EventArgs e)
        {

        }

        private void updateName()
        {
            // Random employees
            String[] users = { "Mike", "Joe", "Samanatha", "Liz", "Evan" };

            for (int i = 0; i < users.Length; i++)
            {
                user[i] = new Employee(users[i], "Unkown");
            }
        }

        private void updateProducts()
        {
            //// Random cheese products
            //String[] products = { "Asiago", "Chedder", "Parmesan", "Swiss", "American", "PepperJack" };
            //double[] prices = { .99, 1.20, .50, 1.25, 1.99, 1.12 };

            //for (int i = 0; i < items.Length; i++)
            //{
            //    items[i] = new Product(products[i], prices[i]);
            //}
            items.Clear();
            productFilename = @Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\proudcts-" + productData + ".xml";
            DataTable table = config.load(productFilename);
            foreach (DataRow row in table.Rows)
            {
                items.Add(new Product((string)row["description"], (double)row["price"]));
            }
        }

        // Changes to random user on click
        private void username_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            currentUser = user[new Random().Next(0, 5)];
            User = currentUser.getFirstName();
            username.Text = User;
        }

        // Updates "clock"
        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongTimeString();
        }

        // "add" item button
        private void button2_Click(object sender, EventArgs e)
        {
            //LabelIsVisible = false;

            pay.Enabled = true;
            Random rnd = new Random();
            Product newItem = items[rnd.Next(0, items.Count)];
            int quantity = rnd.Next(1, 4);
            double total = (double)quantity * newItem.getPrice();

            table.Rows.Add(new Object[] {newItem.getProductName(), String.Format("{0:#.00}", newItem.getPrice()), quantity, string.Format("{0:#.00}", total)});
            runningTotal += total;

            // attempting to format double in to "money" x.xx
            Total = String.Format("{0:#.00}", runningTotal);
            totalLabel.Text = Total;
            updateRequired();
        }

        // Updates the "required: xx.xx" text box
        public void updateRequired()
        {
            Required = "required: " + String.Format("{0:#.00}", (0.0 - runningTotal));
            required.Text = Required;
            required.ForeColor = System.Drawing.Color.Red;

        }

        // "Pay" button, mainly changes Enabled property of buttons and visibility of pay fields etc..
        private void button1_Click(object sender, EventArgs e)
        {
            if( config.Get("popupPay").Equals("true")) {
                popupWindow();
            } else
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
           
            
        }

        // Updates the amount required AND handles the process button enabled
        private void updateTenderedRequired()
        {
            updateRequired();

            try
            {
                double currentEntered = Convert.ToDouble(tendered.Text);
                string currentRequired = String.Format("{0:#.00}", (runningTotal - currentEntered));

                if (runningTotal - currentEntered == 0 || currentRequired.Equals(".00"))
                {
                    required.ForeColor = System.Drawing.Color.Black;
                    Required = "change: " + 0;
                    required.Text = Required;
                    process.Enabled = true;
                }
                else if (runningTotal - currentEntered > 0)
                {
                    Required = "required: " +  String.Format("{0:#.00}", (runningTotal - currentEntered));
                    required.Text = Required;
                    process.Enabled = false;
                }
                else if (runningTotal - currentEntered < 0)
                {
                    required.ForeColor = System.Drawing.Color.Black;
                    Required = "change: " + String.Format("{0:#.00}", (Math.Abs(runningTotal - currentEntered)));
                    required.Text = Required;
                    process.Enabled = true;
                }

            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.ToString());
            }
        }

        // Updates the tender required when user is entering how much will be paid
        private void tendered_TextChanged(object sender, EventArgs e)
        {
            updateTenderedRequired();
        }

        // Adds transaction then resets everything
        private void process_Click(object sender, EventArgs e)
        {
            updateProcess();
            table2.Rows.Add(new Object[] {Stamp, User, Total, TenderEntered, Change});

            runningTotal = 0;
            totalLabel.Text = "0.00";
            tendered.Text = "0.00";
            required.Visible = false;
            process.Visible = false;
            cancel.Visible = false;
            tendered.Visible = false;
            table.Rows.Clear();
           

            add.Enabled = true;
            clear.Enabled = true;
            pay.Enabled = false;
        }

        // updates variables for the process button
        public void updateProcess()
        {
            Stamp = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            TenderEntered = tendered.Text;
            Total = String.Format("{0:#.00}", runningTotal.ToString());
            Change = String.Format("{0:#.00}", Math.Abs(runningTotal - Convert.ToDouble(TenderEntered)).ToString());
           
        }

        // Clears the table on click
        private void clear_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        // Clears the table and the total
        public void clearAll()
        {
            table.Rows.Clear();
            runningTotal = 0;
            totalLabel.Text = "0.00";
        }

        // Cancels the pay button
        private void cancel_Click(object sender, EventArgs e)
        {
            process.Visible = false;
            cancel.Visible = false;
            tendered.Visible = false;
            required.Visible = false;
            add.Enabled = true;
            clear.Enabled = true;
            pay.Enabled = true;
        }

        //// Hold ctrl and click pay for a new window
        //private void pay_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
        //    {
        //        //ctrHeld = true;
        //        //MessageBox.Show("ctrl and leftClick"); 
        //    }
        //}

        private void popupWindow()
        {
            add.Enabled = false;
            clear.Enabled = false;
            pay.Enabled = false;
            tendered.Visible = false;
            required.Visible = false;
            process.Visible = false;
            cancel.Visible = false;

            // popup pay window
            Popup pop = new Popup();
            pop.ShowDialog();
            config.Read(filename);

            if (processClicked)
            {
                clearAll();
                runningTotal = 0;
                totalLabel.Text = "0.00";
                tendered.Text = "0.00";
                required.Visible = false;
                process.Visible = false;
                cancel.Visible = false;
                tendered.Visible = false;
                table.Rows.Clear();


                add.Enabled = true;
                clear.Enabled = true;
                pay.Enabled = false;
            }
            else
            {
                pay.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        // Right click 'settings' window
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingForm = new Settings(this);
            settingForm.ShowDialog();
            config.Read(filename);
            productData = (string)config.Get("selectedProduct");
            updateProducts();

            // Have to update image, comboBox, and Button containers with correct user
            pictureBox1.Image = TextToImage.CreateImageFromText(User);
            comboBox1.SelectedIndex = comboBox1.FindString(User);
            nameBtn.Text = User;
            username.Text = User;

            // Gets the correct settings from the settings.config file
            ButtonIsVisible = stringToBool((string)config.Get("ButtonIsVisible"));
            LabelIsVisible = stringToBool((string)config.Get("LabelIsVisible"));
            ImageIsVisible = stringToBool((string)config.Get("ImageIsVisible"));
            DropIsVisble = stringToBool((string)config.Get("DropIsVisible"));
            
        }

        // Changes user on click (for picture/image labels)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            currentUser = user[new Random().Next(0, 5)];
            User = currentUser.getFirstName();
            pictureBox1.Image = TextToImage.CreateImageFromText(User);

        }

        // Changes user on click (for button)
        private void nameBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            currentUser = user[new Random().Next(0, 5)];
            User = currentUser.getFirstName();
            nameBtn.Text = User;
        }

        // Updates User when a new 'user' is picked using the comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           User = comboBox1.SelectedItem.ToString();
        }
    }
}
