using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MPrecision
{
    public partial class ManageExpenses : Form
    {
        public ManageExpenses()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jianc\Documents\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DLSU TERM 5\LBYCPD2\MPrecision\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select Date, ExpenseType, ExpenseBy, Cost from ExpensesTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                ExpensesGV.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void InventoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatePicker.Text = ExpensesGV.SelectedRows[0].Cells[0].Value.ToString();
            ExpenseTypeTb.Text = ExpensesGV.SelectedRows[0].Cells[1].Value.ToString();
            ExpenseByTb.Text = ExpensesGV.SelectedRows[0].Cells[2].Value.ToString();
            CostTb.Text = ExpensesGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExpenseTypeTb.Text = "";
            ExpenseByTb.Text = "";
            CostTb.Text = "";
        }

        private void ManageExpenses_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpenseTypeTb.Text == "" || ExpenseByTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Incomplete data!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpensesTbl values('" + DatePicker.Text + "', '" + ExpenseTypeTb.Text + "', '" + ExpenseByTb.Text + "', '" + CostTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been succesfully added!");
                    Con.Close();
                    populate();
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ExpenseTypeTb.Text == "" || ExpenseByTb.Text == "" || CostTb.Text == "")
            {
                MessageBox.Show("Choose a data!");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ExpensesTbl where ExpenseType='" + ExpenseTypeTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been succesfully removed!");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpenseTypeTb.Text == "" || ExpenseByTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Choose a data!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExpensesTbl SET Date='" + DatePicker.Text + "', ExpenseType='" + ExpenseTypeTb.Text + "', ExpenseBy='" + ExpenseByTb.Text + "', Cost='" + CostTb.Text + "' where ExpenseType='" + ExpenseTypeTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been succesfully updated!");
                    Con.Close();
                    populate();
                }
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
