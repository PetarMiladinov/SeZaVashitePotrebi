using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeZaVashitePotrebi.Classes;

namespace SeZaVashitePotrebi
{
    public partial class RegisterForm : Form
    {
        public AppUser? user;
        public List<AppUser> users;

        public RegisterForm(List<AppUser> users)
        {
            InitializeComponent();
            this.users = users;
            tbPassword.UseSystemPasswordChar = true;
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


            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (users.Any(u => u.Email == email))
            {
                MessageBox.Show("E-mail already exists. Please choose a different E-mail.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number using regular expression
            string phoneNumberPattern = @"^\d{3}/\d{3}-\d{3}$"; // Customize this pattern to match your desired format
            if (!Regex.IsMatch(number, phoneNumberPattern))
            {
                MessageBox.Show("Please enter a valid phone number in the format xxx/xxx-xxx.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSeller = rbSeller.Checked;

            user = new AppUser(username, password, email, country, city, number, isSeller);

            MessageBox.Show("Registration successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }
    }
}
