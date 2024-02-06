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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Create Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = " Create Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Create Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Create Password";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gender")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Gender";
                comboBox1.ForeColor = Color.Silver;
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            
                string ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=HighSchoolStudents;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string Username = textBox1.Text;
                string Password = textBox2.Text;
                string Gender = comboBox1.Text;
                string Query = "INSERT INTO Learners(Username,Password,Gender)VALUES('" + Username + "','" + Password + "','"+Gender+"',)";

                SqlCommand cmd = new SqlCommand(Query, con);
       
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Registerd");
            }
            catch
            {
                MessageBox.Show("Check Errors");
            }
            MenuBoard mn = new MenuBoard();
            mn.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !char.IsDigit(ch) && !char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 12 && textBox1.Text.StartsWith("WW"))
            {

            }
            else
            {
                MessageBox.Show("starts your password with WW");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == " ")
            {
                textBox4.Text = "Name";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Name")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Surname")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            if (textBox3.Text == " ")
            {
                textBox3.Text = "Surname";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {

            if (textBox5.Text == "Email Address")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == " ")
            {
                textBox5.Text = "Email Address";
                textBox5.ForeColor = Color.Black;
            }

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {

            if (textBox6.Text == "Id Number")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == " ")
            {
                textBox6.Text = "Id Number";
                textBox6.ForeColor = Color.Black;
            }
        }
    }
}
