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
    public partial class Login : Form
    {
        public Login()
            {
                InitializeComponent();
            }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        ///SHOW PASSWORD TOGGLE
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox1.Checked == true)
                    PwordTb.PasswordChar = '\0';
                else
                    PwordTb.PasswordChar = '*';
            }

        ///LOGIN BUTTON
        private void button1_Click(object sender, EventArgs e)
            {
                Con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) from UserTbl where Username = '" + UnameTb.Text + "' and Password = '" + PwordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
                Con.Close();
            }
    }
}
