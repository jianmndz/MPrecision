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
    public partial class ManageStaff : Form
    {
        public ManageStaff()
            {
                InitializeComponent();
            }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        ///LOAD INTERFACE
        private void ManageStaff_Load(object sender, EventArgs e)
            {
                populate();
            }


        ///FILL STAFF TABLE/GRID VIEW
        void populate()
            {
                try
                {
                    Con.Open();
                    string Myquery = "select * from StaffTbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    StaffGV.DataSource = dataSet.Tables[0];
                    Con.Close();
                }
                catch
                {

                }
            }

        ///ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StaffTbl values('" + FnameTb.Text + "', '" + PnumTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff has been succesfully added!");
                    Con.Close();
                    populate();
                }
                catch
                {

                }
            }

        ///EDIT BUTTON
        private void button2_Click(object sender, EventArgs e)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StaffTbl SET PhoneNumber='" + PnumTb.Text + "' where Name='" + FnameTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff has been succesfully updated!");
                    Con.Close();
                    populate();
                }
                catch
                {

                }
            }

        ///DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
            {
                if (PnumTb.Text == "")
                {
                    MessageBox.Show("Enter Phone Number!");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from StaffTbl where PhoneNumber='" + PnumTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff has been succesfully removed!");
                    Con.Close();
                    populate();
                }
            }

        ///AUTO-FILL TEXT BOX WHEN STAFF TABLE IS CLICKED
        private void StaffGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                FnameTb.Text = StaffGV.SelectedRows[0].Cells[0].Value.ToString();
                PnumTb.Text = StaffGV.SelectedRows[0].Cells[1].Value.ToString();
            }

        ///HOME BUTTON
        private void button4_Click(object sender, EventArgs e)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }

        private void button5_Click(object sender, EventArgs e)
            {
                FnameTb.Text = "";
                PnumTb.Text = "";
            }
    }
}
