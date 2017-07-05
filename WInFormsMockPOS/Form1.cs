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

        public Form1()
        {
            updateName();
            InitializeComponent();
            username.Text = user[new Random().Next(0,5)].getFirstName();
            timer1.Start();

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
            double[] prices = { 4.99, 3.20, 8.56, 5.25, 4.32, 7.99 };
        }

        private void username_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            username.Text = user[rnd.Next(0, 5)].getFirstName(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
