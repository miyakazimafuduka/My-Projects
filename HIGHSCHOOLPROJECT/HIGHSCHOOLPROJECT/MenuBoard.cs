using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIGHSCHOOLPROJECT
{
    public partial class MenuBoard : Form
    {
        public MenuBoard()
        {
            InitializeComponent();
        }

        private void timeTableToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rg = new RegistrationForm();
            rg.Show();
            this.Hide();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolRules sr = new SchoolRules();
            sr.Show();
            this.Hide();

        }
    }
}
