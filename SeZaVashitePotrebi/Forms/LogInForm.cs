using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeZaVashitePotrebi.Classes;

namespace SeZaVashitePotrebi
{
    public partial class LogInForm : Form
    {
        public AppUser? user;
        public List<AppUser> users;
        public LogInForm(List<AppUser> users)
        {
            InitializeComponent();
            this.users = users;
            tbPassword.UseSystemPasswordChar = true;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user exists
            user = users.FirstOrDefault(u => u.Username == username);

            if (user == null || user.Password != password)
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }
    }
}
