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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "";

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string Username = textBox1.Text;
                string Password = textBox2.Text;

                string Query = "UPDATE Learners.SET Username='" + Username + "', Password ='" + Password + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("WELCOME");
            }
            catch
            {
                MessageBox.Show("Check Your username and password");
            }
        }
    }
}
