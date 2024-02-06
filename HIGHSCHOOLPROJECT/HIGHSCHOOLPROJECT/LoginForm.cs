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

namespace HIGHSCHOOLPROJECT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UpdateForm up = new UpdateForm();
            up.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             string ConnectionString ="Data Source=(localdb)\\Projects;Initial Catalog=HighSchoolStudents;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string Username = textBox1.Text;
                string Password = textBox2.Text;
                
                string Query = "SELECT * FROM Learners WHERE Username ='"+textBox1.Text+"'and Password='"+textBox2.Text+"'";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("WELCOME");
            }
            catch {
                MessageBox.Show("Check Your username and password");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black ;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;

            }
        }

    }
}
