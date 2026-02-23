//Stephanie Hamilton
//Michael McDonough
//Seth Vassey
//Robert Zheng


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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkCreateAcct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAcct AcctForm = new CreateAcct();
            AcctForm.ShowDialog();

        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword ForgotForm = new ForgotPassword();
            ForgotForm.ShowDialog();

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userInput = txtUserEmail.Text.Trim();   // username OR email
            string password = txtPassword.Text;            // password

            if (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your Username/Email and Password.",
                                "Missing Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var users = UserStorage.LoadUsers();

            // If no users exist yet
            if (users == null || users.Count == 0)
            {
                MessageBox.Show("No accounts found. Please create an account first.",
                                "No Accounts",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // find by username OR email (case-insensitive)
            var user = users.FirstOrDefault(u =>
                string.Equals(u.Username, userInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(u.Email, userInput, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                MessageBox.Show("Username/Email not found.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtUserEmail.Focus();
                txtUserEmail.SelectAll();
                return;
            }

            // compare password (plain text)
            if (user.Password != password)
            {
                MessageBox.Show("Incorrect password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.SelectAll();
                return;
            }

            this.Hide();
            DataForm sportsData = new DataForm(user);

            sportsData.ShowDialog();
            this.Show(); // show login again when DataForm closes (optional)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //List<Form> formstoClose = new List<Form>();
            //foreach (Form forms in Application.OpenForms)
            //{
            //    if (forms.Name != "Form1")
            //    {
            //        formstoClose.Add(forms);
            //    }
            //}

            //foreach (Form forms in formstoClose)
            //{ 
            //    forms.Close();
            //}

            this.Close();

        }
    }
}
