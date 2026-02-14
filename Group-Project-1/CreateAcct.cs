using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_1
{
    public partial class CreateAcct : Form
    {
        public CreateAcct()
        {
            InitializeComponent();
        }

        private void btnReturnToLoginCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
