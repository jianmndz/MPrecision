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
    public partial class ManageCashBalance : Form
    {
        public ManageCashBalance()
            {
                InitializeComponent();
            }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        ///SEARCH BAR FOR EXPENSES TABLE
        public void SearchExpenses(string search)
            {
                Con.Open();
                string Myquery = "select Date, ExpenseType, ExpenseBy, Cost from ExpensesTbl where Date like '%" + search + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ExpensesGV.DataSource = dt;
                Con.Close();
            }

        ///SEARCH BAR FOR EXPENSES TABLE
        private void SearchExpensesTb_TextChanged(object sender, EventArgs e)
            {
                SearchExpenses(SearchExpensesTb.Text);
            }

        ///SEARCH BAR FOR EXPENSES TABLE
        private void SearchExpenses_Enter(object sender, EventArgs e)
            {
                if (SearchExpensesTb.Text == "Filter Expenses by Date")
                {
                    SearchExpensesTb.Text = "";
                    SearchExpensesTb.ForeColor = Color.Black;
                }
            }

        ///SEARCH BAR FOR INVENTORY TABLE
        public void SearchInventory(string search)
            {
                Con.Open();
                string Myquery = "select Date, Name, PlateNumber, MakeAndBody, Service, Sales, CommissionPercent, CommissionCost, Staff from InventoryTbl where Date like '%" + search + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                InventoryGV.DataSource = dt;
                Con.Close();
            }

        ///SEARCH BAR FOR INVENTORY TABLE
        private void SearchInventory_Enter(object sender, EventArgs e)
            {
                if (SearchInventoryTb.Text == "Filter Inventory by Date")
                {
                    SearchInventoryTb.Text = "";
                    SearchInventoryTb.ForeColor = Color.Black;
                }
            }

        ///SEARCH BAR FOR INVENTORY TABLE
        private void SearchInventoryTb_TextChanged(object sender, EventArgs e)
            {
                SearchInventory(SearchInventoryTb.Text);
            }

        ///FILL EXPENSES TABLE/GRID VIEW
        void populateExpenses()
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

        ///FILL INVENTORY TABLE/GRID VIEW
        void populateInventory()
            {
                try
                {
                    Con.Open();
                    string Myquery = "select Date, Name, PlateNumber, MakeAndBody, Service, Sales, CommissionPercent, CommissionCost, Staff from InventoryTbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    InventoryGV.DataSource = dataSet.Tables[0];
                    Con.Close();
                }
                catch
                {

                }
            }

        ///HOME BUTTON
        private void button4_Click(object sender, EventArgs e)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }

        ///LOAD INTERFACE
        private void ManageCashBalance_Load(object sender, EventArgs e)
            {
                populateExpenses();
                populateInventory();
            }

        ///CALCULATE EXPENSES BUTTON
        private void button1_Click(object sender, EventArgs e)
            {
                if (ExpensesGV.Rows.Count <= 1)
                    CashOutTotalTb.Text = "0";

                if (ExpensesGV.Rows.Count > 1)
                {
                    CashOutTotalTb.Text = "0";
                    for (int i = 0; i < ExpensesGV.Rows.Count - 1; i++)
                        CashOutTotalTb.Text = Convert.ToString(float.Parse(CashOutTotalTb.Text) + float.Parse(ExpensesGV.Rows[i].Cells[3].Value.ToString()));
                }
            }

        ///CALCULATE INCOME BUTTON
        private void button2_Click(object sender, EventArgs e)
            {
                if (InventoryGV.Rows.Count <= 1)
                    CashInTotalTb.Text = "0";

                if (InventoryGV.Rows.Count > 1)
                {
                    CashInTotalTb.Text = "0";
                    for (int i = 0; i < InventoryGV.Rows.Count - 1; i++)
                        CashInTotalTb.Text = Convert.ToString(float.Parse(CashInTotalTb.Text) + float.Parse(InventoryGV.Rows[i].Cells[5].Value.ToString()));
                }
            }

        ///CALCULATE BALANCE BUTTON
        private void button3_Click(object sender, EventArgs e)
            {
                if (String.IsNullOrEmpty(CashOutTotalTb.Text) || String.IsNullOrEmpty(CashInTotalTb.Text))
                {
                    MessageBox.Show("Click 'Calculate Expenses'/'Calculate Income' before clicking 'Calculate Balance'");
                    return;
                }

                float cashOnHandTb;
                if (!float.TryParse(CashOnHandTb.Text, out cashOnHandTb))
                {
                    MessageBox.Show("'Cash On Hand' is a number only field");
                    return;
                }

                CashBalanceTb.Text = "0";
                CashBalanceTb.Text = Convert.ToString(float.Parse(CashOnHandTb.Text) - float.Parse(CashOutTotalTb.Text) + float.Parse(CashInTotalTb.Text));
            }
    }
}
