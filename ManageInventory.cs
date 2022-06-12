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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        ///SEARCH BAR FOR INVENTORY
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

        ///SEARCH BAR FOR INVENTORY
        private void SearchTb_TextChanged_1(object sender, EventArgs e)
            {
                Search(SearchTb.Text);
            }

        ///SEARCH BAR FOR INVENTORY
        private void Search_Enter(object sender, EventArgs e)
            {
                if (SearchTb.Text == "Search name")
                {
                    SearchTb.Text = "";
                    SearchTb.ForeColor = Color.Black;
                }
            }

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
                    InventoryGV.DataSource = dataSet.Tables[0];
                    Con.Close();
                }
                catch
                {

                }
            }

        ///FILL CHECKEDLIST BUTTONS
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

        ///LOAD INTERFACE
        private void ManageInventory_Load(object sender, EventArgs e)
            {
                populate();
                fillChecklist();
                generateID();
            }

        ///ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (NameTb.Text == "" || PlateTb.Text == "" || MakeBodyTb.Text == "" || ServiceTb.Text == "" || SalesTb.Text == "" || CommissionTb.Text == "" || LoyaltyTb.Text == "")
                    {
                        MessageBox.Show("Incomplete data!");
                    }

                    float salesTb;
                    if (!float.TryParse(SalesTb.Text, out salesTb))
                    {
                        MessageBox.Show("Sales is a number only field");
                        return;
                    }

                    float commissionTb;
                    if (!float.TryParse(CommissionTb.Text, out commissionTb))
                    {
                        MessageBox.Show("Commission is a number only field");
                        return;
                    }

                    else
                    {
                        Con.Open();
                        String str = "";
                        foreach (string s in StaffList.CheckedItems)
                            str += s + "\r\n";
                        float sales = float.Parse(SalesTb.Text);
                        float commission = float.Parse(CommissionTb.Text);
                        double commissionCost = sales * (commission*0.01);
                        SqlCommand cmd = new SqlCommand("insert into InventoryTbl values('" + IdTb.Text + "' , '" + DatePicker.Text + "', '" + NameTb.Text + "', '" + PlateTb.Text + "', '" + MakeBodyTb.Text + "', '" + ServiceTb.Text + "', '" + SalesTb.Text + "', '" + CommissionTb.Text + "', '" + commissionCost + "', '" + str + "', '" + LoyaltyTb.Text + "')", Con);
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

        ///EDIT BUTTON
        private void button3_Click(object sender, EventArgs e)
            {
                try
                {
                    if (NameTb.Text == "" || PlateTb.Text == "" || MakeBodyTb.Text == "" || ServiceTb.Text == "" || SalesTb.Text == "" || CommissionTb.Text == "" || LoyaltyTb.Text == "")
                    {
                        MessageBox.Show("Choose a data!");
                    }

                    float salesTb;
                    if (!float.TryParse(SalesTb.Text, out salesTb))
                    {
                        MessageBox.Show("Sales is a number only field");
                        return;
                    }

                    float commissionTb;
                    if (!float.TryParse(CommissionTb.Text, out commissionTb))
                    {
                        MessageBox.Show("Commission is a number only field");
                        return;
                    }

                    else
                    {
                        Con.Open();
                        String str = "";
                        foreach (string s in StaffList.CheckedItems)
                            str += s + "\r\n";
                        float sales = float.Parse(SalesTb.Text);
                        float commission = float.Parse(CommissionTb.Text);
                        double commissionCost = sales * (commission * 0.01);
                        SqlCommand cmd = new SqlCommand("UPDATE InventoryTbl SET Name='" + NameTb.Text + "', Date='" + DatePicker.Text + "', PlateNumber='" + PlateTb.Text + "', MakeAndBody='" + MakeBodyTb.Text + "', Service='" + ServiceTb.Text + "', Sales='" + SalesTb.Text + "', CommissionPercent='" + CommissionTb.Text + "', CommissionCost='" + commissionCost + "', Staff='" + str + "', Streak='" + LoyaltyTb.Text + "' where ID='" + IdTb.Text + "'", Con);
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

        ///DELETE BUTTON
        private void button2_Click(object sender, EventArgs e)
            {
                if(NameTb.Text == "" || PlateTb.Text == "" || MakeBodyTb.Text == "" || ServiceTb.Text == "" || SalesTb.Text == "" || CommissionTb.Text == "" || LoyaltyTb.Text == "")
                {
                    MessageBox.Show("Choose a data!");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from InventoryTbl where ID='" + IdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been succesfully removed!");
                    Con.Close();
                    populate();
                }
            }

        ///CLEAR BUTTON
        private void button5_Click(object sender, EventArgs e)
            {
                NameTb.Text = "";
                PlateTb.Text = "";
                MakeBodyTb.Text = "";
                ServiceTb.Text = "";
                SalesTb.Text = "";
                CommissionTb.Text = "";
                LoyaltyTb.Text = "";
                for (int i = 0; i < StaffList.Items.Count; i++)
                {
                    StaffList.SetItemChecked(i, false);
                }
                generateID();

            }

        ///HOME BUTTON
        private void button4_Click(object sender, EventArgs e)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }

        ///AUTO-GENERATE ID BUTTON
        private void button6_Click(object sender, EventArgs e)
            {
                generateID();
            }

        ///AUTO-FILL TEXT BOXES
        private void InventoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                IdTb.Text = InventoryGV.SelectedRows[0].Cells[0].Value.ToString();
                DatePicker.Text = InventoryGV.SelectedRows[0].Cells[1].Value.ToString();
                NameTb.Text = InventoryGV.SelectedRows[0].Cells[2].Value.ToString();
                PlateTb.Text = InventoryGV.SelectedRows[0].Cells[3].Value.ToString();
                MakeBodyTb.Text = InventoryGV.SelectedRows[0].Cells[4].Value.ToString();
                ServiceTb.Text = InventoryGV.SelectedRows[0].Cells[5].Value.ToString();
                SalesTb.Text = InventoryGV.SelectedRows[0].Cells[6].Value.ToString();
                CommissionTb.Text = InventoryGV.SelectedRows[0].Cells[7].Value.ToString();
                LoyaltyTb.Text = InventoryGV.SelectedRows[0].Cells[10].Value.ToString();
            }
    }
}
