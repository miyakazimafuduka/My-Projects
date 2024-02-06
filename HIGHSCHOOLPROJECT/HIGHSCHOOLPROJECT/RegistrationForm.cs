using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace HIGHSCHOOLPROJECT
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String AllowedSymbol;
            AllowedSymbol = "@";

            if (Regex.IsMatch(textBox7.Text, AllowedSymbol))
            {
                MessageBox.Show("Valid Email Address");
            }
            else
            {
                MessageBox.Show("please check your Email Address");
            }
            if (textBox1.Text == "")
            {
               errorProvider1.SetError(textBox1,"ID number Required");
            }
            else if (textBox2.Text == "|")
            {
                errorProvider1.SetError(textBox2, "Student name Required");
            }

            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Student name Required");
            }
            else if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Contact number  Required");
            }
            else if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Contact number  Required");
            }
            else if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Gardian name Required");
            }
            
            else if (textBox7.Text == "")
            {
                errorProvider1.SetError(textBox7, "Physical address Required");
            }
            else
            {
                MessageBox.Show("Successfuly Registered");
            }
            //Validating lenght for ID and Contact no
            if (textBox1.Text.Length == 13)
            {

            }
            else 
            {

                errorProvider1.SetError(textBox1, "only 13 digits allowed");
            }
            if (textBox3.Text.Length != 10 && textBox6.Text.Length!=10)
            {

            }
            else
            {
                errorProvider1.SetError(textBox1, "onl 10 digits allowe");
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }


    }
}
