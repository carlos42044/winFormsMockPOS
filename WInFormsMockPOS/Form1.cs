using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Media;

namespace WInFormsMockPOS
{
    public partial class Form1 : Form
    {
        // Variables for Employee and Product objects
        Employee[] user = new Employee[5];
        Product[] items = new Product[6];
        Employee currentUser;

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

        // Global variable to hold total
        public static double runningTotal = 0.00;

        public Form1()
        {
            updateName();
            updateProducts();
            InitializeComponent();
            currentUser = user[new Random().Next(0, 5)];
            User = currentUser.getFirstName();
            username.Text = currentUser.getFirstName();
            timer1.Start();
            createTableHeaders();
            pay.Enabled = false;
            pictureBox1.Image = CreateImageFromText("hello");
           // pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

   
        private Bitmap CreateImageFromText(string Text)
        {
            // Create the Font object for the image text drawing.
            Font textFont = new Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            Bitmap ImageObject = new Bitmap(51, 16);
            // Add the anti aliasing or color settings.
            Graphics GraphicsObject = Graphics.FromImage(ImageObject);

            // Set Background color
            //GraphicsObject.Clear(System.Drawing.Color.White);
            // to specify no aliasing
            GraphicsObject.SmoothingMode = SmoothingMode.Default;
            GraphicsObject.TextRenderingHint = TextRenderingHint.SystemDefault;
            GraphicsObject.DrawString(Text, textFont, new SolidBrush(System.Drawing.Color.Black), 0, 0);
            GraphicsObject.Flush();

            return (ImageObject);
        }

        //private void ImagePaint(object sender, PaintEventArgs e)
        //{
        //    Image img = TextToImage.DrawText("world", new Font(FontFamily.GenericSansSerif,
        //     12.0F, FontStyle.Bold), Color.FromName("BurlyWood"), Color.FromName("White"));

        //    using (var g = Graphics.FromImage(pictureBox1.Image))
        //    {
        //        g.DrawEllipse(Pens.Blue, 10, 10, 100, 100);
        //        pictureBox1.Refresh();
        //    }
        //    // Draw image to screen.
        //    Point corner = new Point(0, 0);
        //    //e.Graphics.DrawImage(img, corner);
        //   // pictureBox1.Refresh();
        //    MessageBox.Show("the paintevent was triggered");
        //}

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
            // Random cheese products
            String[] products = { "Asiago", "Chedder", "Parmesan", "Swiss", "American", "PepperJack" };
            double[] prices = { .99, 1.20, .50, 1.25, 1.99, 1.12 };

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Product(products[i], prices[i]);
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
            pay.Enabled = true;
            Random rnd = new Random();
            Product newItem = items[rnd.Next(0, items.Length)];
            int quantity = rnd.Next(1, 4);
            double total = (double)quantity * newItem.getPrice();

            table.Rows.Add(new Object[] {newItem.getProductName(), String.Format("{0:#.00}", newItem.getPrice()), quantity, string.Format("{0:#.00}", total)});
            runningTotal += total;

            // attempting to format double in to "money" x.xx
            Total = String.Format("{0:#.00}", runningTotal);
            totalLabel.Text = Total;
            updateRequired();
            this.Refresh();

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

            add.Enabled = false;
            clear.Enabled = false;
            pay.Enabled = false;
            tendered.Visible = true;
            required.Visible = true;
            process.Visible = true;
            cancel.Visible = true;

            updateRequired();
            
        }

        // Updates the amount required AND handles the process button
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

        // updates the tender required when user is entering how much will be paid
        private void tendered_TextChanged(object sender, EventArgs e)
        {
            updateTenderedRequired();
        }

        // adds transaction then resets everything
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

        // Clears the table
        private void clear_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        //clear
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

        // hold ctrl and click pay for a new window
        private void pay_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                //ctrHeld = true;
                //MessageBox.Show("ctrl and leftClick");
                add.Enabled = false;
                clear.Enabled = false;
                pay.Enabled = false;
                tendered.Visible = false;
                required.Visible = false;
                process.Visible = false;
                cancel.Visible = false;
                //MessageBox.Show("before handing control over to another form\nthetotal is: " + Total + "Required = " + Required);
                Popup pop = new Popup();
                pop.ShowDialog();

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
                } else
                {
                    pay.Enabled = true;
                }
                
            }
             
            
        }
    }
}
