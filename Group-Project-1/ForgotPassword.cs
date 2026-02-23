using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Group_Project_1
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void btnSendReset_Click(object sender, EventArgs e)
        {
            string input = txtRecoverPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter your Email or Username.");
                return;
            }

            var users = UserStorage.LoadUsers();

            if (users == null || users.Count == 0)
            {
                MessageBox.Show("No accounts found. Please create an account first.");
                return;
            }

            var user = users.FirstOrDefault(u =>
                string.Equals(u.Email, input, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(u.Username, input, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                MessageBox.Show("Account not found.");
                return;
            }

            // Generate reset code
            string resetCode = new Random().Next(100000, 999999).ToString();

            // SHOW CODE ON SCREEN (demo version)
            MessageBox.Show(
                "Reset Code: " + resetCode +
                "\n\nEnter this code to reset your password.",
                "Password Reset Code"
            );

            // Ask for code
            string enteredCode = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the reset code:",
                "Reset Code",
                "");

            if (string.IsNullOrWhiteSpace(enteredCode))
                return;

            if (enteredCode.Trim() != resetCode)
            {
                MessageBox.Show("Invalid reset code.");
                return;
            }

            // Ask for new password
            string newPass = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your NEW password:",
                "New Password",
                "");

            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Password cannot be blank.");
                return;
            }

            if (newPass.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                return;
            }

            // Save new password
            user.Password = newPass;
            UserStorage.SaveUsers(users);

            MessageBox.Show("Password updated! You can log in now.");

            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }
    }
}

