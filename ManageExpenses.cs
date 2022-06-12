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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");
        ///AUTO-GENERATE ID
        private void generateID()
            {
                string num = "1234567890";
                int len = num.Length;
                string otp = string.Empty;
                int otpdigit = 5;
                string finaldigit;
                int getIndex;
                for (int i = 0; i < otpdigit; i++)
                {
                    do
                    {
                        getIndex = new Random().Next(0, len);
                        finaldigit = num.ToCharArray()[getIndex].ToString();
                    }
                    while (otp.IndexOf(finaldigit) != -1);
                    otp += finaldigit;
                }
                IdTb.Text = (otp);
            }

        ///FILL EXPENSES TABLE/GRID VIEW
        void populateExpenses()
            {
                try
                {
                    Con.Open();
                    string Myquery = "select ID, Date, ExpenseType, ExpenseBy, Cost from ExpensesTbl";
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

        ///FILL INVENTORY TABLE/GRIDVIEW
        void populateSalary()
            {
                try
                {
                    Con.Open();
                    string Myquery = "select ID, Date, Name, PlateNumber, MakeAndBody, Service, Sales, CommissionPercent, CommissionCost, Staff from InventoryTbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    SalaryGV.DataSource = dataSet.Tables[0];
                    Con.Close();
                }
                catch
                {

                }
            }

        ///AUTO-FILL TEXT BOX WHEN EXPENSES TABLE IS CLICKED
        private void ExpensesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                IdTb.Text = ExpensesGV.SelectedRows[0].Cells[0].Value.ToString();
                DatePicker.Text = ExpensesGV.SelectedRows[0].Cells[1].Value.ToString();
                ExpenseTypeTb.Text = ExpensesGV.SelectedRows[0].Cells[2].Value.ToString();
                ExpenseByTb.Text = ExpensesGV.SelectedRows[0].Cells[3].Value.ToString();
                CostTb.Text = ExpensesGV.SelectedRows[0].Cells[4].Value.ToString();
            }

        ///AUTO-FILL TEXT BOX WHEN INVENTORY TABLE IS CLICKED
        private void SalaryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                IdTb.Text = SalaryGV.SelectedRows[0].Cells[0].Value.ToString();
                DatePicker.Text = SalaryGV.SelectedRows[0].Cells[1].Value.ToString();
                ExpenseTypeTb.Text = "Salary";
                ExpenseByTb.Text = "Owner";
                CostTb.Text = SalaryGV.SelectedRows[0].Cells[8].Value.ToString();
            }

        ///CLEAR BUTTON
        private void button5_Click(object sender, EventArgs e)
            {
                ExpenseTypeTb.Text = "";
                ExpenseByTb.Text = "";
                CostTb.Text = "";
                generateID();
            }

        ///LOAD INTERFACE
        private void ManageExpenses_Load(object sender, EventArgs e)
            {
                populateExpenses();
                populateSalary();
            }

        ///ADD BUTTON
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
                        SqlCommand cmd = new SqlCommand("insert into ExpensesTbl values('" + IdTb.Text + "', '" + DatePicker.Text + "', '" + ExpenseTypeTb.Text + "', '" + ExpenseByTb.Text + "', '" + CostTb.Text + "')", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been succesfully added!");
                        Con.Close();
                        populateExpenses();
                    }
                }
                catch
                {

                }
            }

        ///DELETE BUTTON
        private void button2_Click(object sender, EventArgs e)
            {
                if (ExpenseTypeTb.Text == "" || ExpenseByTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Choose a data!");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from ExpensesTbl where ID='" + IdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been succesfully removed!");
                    Con.Close();
                    populateExpenses();
                }
            }

        ///EDIT BUTTON
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
                        SqlCommand cmd = new SqlCommand("UPDATE ExpensesTbl SET Date='" + DatePicker.Text + "', ExpenseType='" + ExpenseTypeTb.Text + "', ExpenseBy='" + ExpenseByTb.Text + "', Cost='" + CostTb.Text + "' where ID='" + IdTb.Text + "'", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been succesfully updated!");
                        Con.Close();
                        populateExpenses();
                    }
                }
                catch
                {

                }
            }

        ///AUT0-GENERATE ID BUTTON
        private void button6_Click(object sender, EventArgs e)
            {
                generateID();
            }

        ///HOME BUTTON
        private void button4_Click(object sender, EventArgs e)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }
    }
}
