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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DLSU TERM 5\LBYCPD2\MPrecision\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                UsersGV.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + FnameTb.Text + "', '" + UnameTb.Text + "', '" + PwordTb.Text + "', '" + PnumTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has been succesfully added!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET Username='" + UnameTb.Text + "', Password='" + PwordTb.Text + "', Phone='" + PnumTb.Text + "' where Name='" + FnameTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has been succesfully updated!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PnumTb.Text == "")
            {
                MessageBox.Show("Enter Phone Number!");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where Phone='" + PnumTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has been succesfully removed!");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void UsersGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            UnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PwordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PnumTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
