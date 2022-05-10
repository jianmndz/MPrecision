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

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from InventoryTbl";
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
                String str = "";
                foreach (string s in StaffList.CheckedItems)
                    str += s + "\r\n";
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into InventoryTbl values('" + DatePicker.Text + "', '" + NameTb.Text + "', '" + PlateTb.Text + "', '" + MakeBodyTb.Text + "', '" + ServiceTb.Text + "', '" + SalesTb.Text + "', '" + str + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been succesfully added!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
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
                String str = "";
                foreach (string s in StaffList.CheckedItems)
                    str += s + "\r\n";
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE InventoryTbl SET Date='" + DatePicker.Text + "', PlateNumber='" + PlateTb.Text + "', MakeAndBody='" + MakeBodyTb.Text + "', Service='" + ServiceTb.Text + "', Sales='" + SalesTb.Text + "', Staff='" + str + "' where Name='" + NameTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been succesfully updated!");
                Con.Close();
                populate();
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
            StaffList.Text = InventoryGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
