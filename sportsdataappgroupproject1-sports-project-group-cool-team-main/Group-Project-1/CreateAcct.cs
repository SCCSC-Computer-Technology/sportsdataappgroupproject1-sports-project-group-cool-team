using System;
using System.Linq;
using System.Windows.Forms;

namespace Group_Project_1
{
    public partial class CreateAcct : Form
    {
        public CreateAcct()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string first = txtFirstName.Text.Trim();
            string last = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(first) ||
                string.IsNullOrWhiteSpace(last) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            var users = UserStorage.LoadUsers();

            if (users.Any(u => u.Email.ToLower() == email.ToLower()))
            {
                MessageBox.Show("Email already registered.");
                return;
            }

            if (users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                MessageBox.Show("Username already taken.");
                return;
            }

            users.Add(new User
            {
                FirstName = first,
                LastName = last,
                Email = email,
                Username = username,
                Password = password
            });

            UserStorage.SaveUsers(users);

            MessageBox.Show("Account created!");

            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void btnReturnToLoginCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }
    }
}