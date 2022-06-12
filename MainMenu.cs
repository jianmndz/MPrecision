using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPrecision
{
    public partial class MainMenu : Form
    {
        public MainMenu()
            {
                InitializeComponent();
            }

        ///ADD INVENTORY BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            ManageInventory inventory = new ManageInventory();
            inventory.Show();
            this.Close();
        }

        ///VIEW INVENTORY TALLY BUTTON
        private void button2_Click(object sender, EventArgs e)
            {
                ManageTally tally = new ManageTally();
                tally.Show();
                this.Close();
            }

        ///MANAGE EXPENSES
        private void button3_Click(object sender, EventArgs e)
        {
            ManageExpenses expenses = new ManageExpenses();
            expenses.Show();
            this.Close();
        }

        ///CASH BALANCE BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            ManageCashBalance balance = new ManageCashBalance();
            balance.Show();
            this.Close();
        }

        ///MANAGE USERS BUTTON
        private void button5_Click(object sender, EventArgs e)
            {
                ManageUsers users = new ManageUsers();
                users.Show();
                this.Close();
            }

        ///MANAGE STAFF BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            ManageStaff staff = new ManageStaff();
            staff.Show();
            this.Close();
        }

        ///LOGOUT BUTTON
        private void button7_Click(object sender, EventArgs e)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
    }
}
