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
    public partial class ManageInventory : Form
    {
        public ManageInventory()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jianc\Documents\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DLSU TERM 5\LBYCPD2\MPrecision\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");
        
        public void Search(string search)
        {
            Con.Open();
            string Myquery = "select * from InventoryTbl where Name like '%" + search + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            InventoryGV.DataSource = dt;
            Con.Close();
        }

        private void SearchTb_TextChanged_1(object sender, EventArgs e)
        {
            Search(SearchTb.Text);
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select Date, Name, PlateNumber, MakeAndBody, Service, Sales, Staff, Streak from InventoryTbl";
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

        void fillChecklist()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "select * from StaffTbl";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    StaffList.Items.Add(dr["Name"]);
                Con.Close();
            }
            catch
            {

            }
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            populate();
            fillChecklist();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTb.Text == "" || PlateTb.Text == "" || MakeBodyTb.Text == "" || ServiceTb.Text == "" || SalesTb.Text == "" || LoyaltyTb.Text == "")
                {
                    MessageBox.Show("Incomplete data!");
                }
                else
                {
                    Con.Open();
                    String str = "";
                    foreach (string s in StaffList.CheckedItems)
                        str += s + "\r\n";
                    SqlCommand cmd = new SqlCommand("insert into InventoryTbl values('" + DatePicker.Text + "', '" + NameTb.Text + "', '" + PlateTb.Text + "', '" + MakeBodyTb.Text + "', '" + ServiceTb.Text + "', '" + SalesTb.Text + "', '" + str + "', '" + LoyaltyTb.Text + "')", Con);
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
            if (NameTb.Text == "" || PlateTb.Text == "" || MakeBodyTb.Text == "" || ServiceTb.Text == "" || SalesTb.Text == "" || LoyaltyTb.Text == "")
            {
                MessageBox.Show("Choose a data!");
            }
            else
            {
                Con.Open();
                string myquery = "delete from InventoryTbl where PlateNumber='" + PlateTb.Text + "';";
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
                if (NameTb.Text == "" || PlateTb.Text == "" || MakeBodyTb.Text == "" || ServiceTb.Text == "" || SalesTb.Text == "" || LoyaltyTb.Text == "")
                {
                    MessageBox.Show("Choose a data!");
                }
                else
                {
                    String str = "";
                    foreach (string s in StaffList.CheckedItems)
                        str += s + "\r\n";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE InventoryTbl SET Date='" + DatePicker.Text + "', PlateNumber='" + PlateTb.Text + "', MakeAndBody='" + MakeBodyTb.Text + "', Service='" + ServiceTb.Text + "', Sales='" + SalesTb.Text + "', Streak='" + LoyaltyTb.Text + "', Staff='" + str + "' where Name='" + NameTb.Text + "'", Con);
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

        private void InventoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatePicker.Text = InventoryGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = InventoryGV.SelectedRows[0].Cells[1].Value.ToString();
            PlateTb.Text = InventoryGV.SelectedRows[0].Cells[2].Value.ToString();
            MakeBodyTb.Text = InventoryGV.SelectedRows[0].Cells[3].Value.ToString();
            ServiceTb.Text = InventoryGV.SelectedRows[0].Cells[4].Value.ToString();
            SalesTb.Text = InventoryGV.SelectedRows[0].Cells[5].Value.ToString();
            LoyaltyTb.Text = InventoryGV.SelectedRows[0].Cells[6].Value.ToString();
            StaffList.Text = InventoryGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PlateTb.Text = "";
            MakeBodyTb.Text = "";
            ServiceTb.Text = "";
            SalesTb.Text = "";
            LoyaltyTb.Text = "";
            StaffList.ClearSelected();

        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (SearchTb.Text == "Search name")
            {
                SearchTb.Text = "";
                SearchTb.ForeColor = Color.Black;
            }
        }
    }
}
