using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeZaVashitePotrebi
{
    public partial class RegisterForm : Form
    {
        public User? user;
        public List<User> users;

        public RegisterForm(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string city = tbCity.Text;
            string country = tbCountry.Text;
            string number = tbPhoneNum.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country) || string.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.Any(u => u.Email == email))
            {
                MessageBox.Show("E-mail already exists. Please choose a different E-mail.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSeller = rbSeller.Checked;

            user = new User(username, password, email, country, city, number, isSeller);

            MessageBox.Show("Registration successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }
    }
}
