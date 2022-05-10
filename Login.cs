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


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jianc\Documents\InventoryMPrecision.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                PwordTb.PasswordChar = '\0';
            else
                PwordTb.PasswordChar = '*';
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
