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

namespace MPrecision
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jianc\Documents\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        private void Search(string search)
        {
            Con.Open();
            string Myquery = "select * from InventoryTbl where Name like '%" + search + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CustomersGV.DataSource = dt;
            Con.Close();

        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select Date, Name, PlateNumber, MakeAndBody from InventoryTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                CustomersGV.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            Search(SearchTb.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var counter = CustomersGV.Rows.Count-1;
            Counter.Text = counter.ToString();
        }
    }
}
