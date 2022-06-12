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
    public partial class ManageTally : Form
    {
        public ManageTally()
            {
                InitializeComponent();
            }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        ///SEARCH BUTTON FOR INVENTORY TABLE/GRID VIEW
        public void Search(string search)
            {
                Con.Open();
                string Myquery = "select * from InventoryTbl where Date like '%" + search + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TallyGV.DataSource = dt;
                Con.Close();
            }

        ///SEARCH BUTTON FOR INVENTORY TABLE/GRID VIEW
        private void SearchTb_TextChanged_1(object sender, EventArgs e)
            {
                Search(SearchTb.Text);
            }

        ///SEARCH BUTTON FOR INVENTORY TABLE/GRID VIEW
        private void Search_Enter(object sender, EventArgs e)
            {
                if (SearchTb.Text == "Search date")
                {
                    SearchTb.Text = "";
                    SearchTb.ForeColor = Color.Black;
                }
            }

        ///FILL INVENTORY TABLE/GRID VIEW
        void populate()
            {
                try
                {
                    Con.Open();
                    string Myquery = "select ID, Date, Name, PlateNumber, MakeAndBody, Service, Sales, CommissionPercent, CommissionCost, Staff, Streak from InventoryTbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    TallyGV.DataSource = dataSet.Tables[0];
                    Con.Close();
                }
                catch
                {

                }
            }

        ///LOAD INTERFACE
        private void ManageTally_Load(object sender, EventArgs e)
            {
                populate();
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
