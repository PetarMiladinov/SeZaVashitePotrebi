using Microsoft.VisualBasic.ApplicationServices;
using SeZaVashitePotrebi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeZaVashitePotrebi.Forms
{
    public partial class MyAccountForm : Form
    {
        private AppUser user;
        public MyAccountForm(Classes.AppUser? loggedIn)
        {
            InitializeComponent();

            this.user = loggedIn;

            // Populate basic user information
            lblName.Text = user.Username;
            lblEmail.Text = user.Email;
            lblLocation.Text = user.City + ", " + user.Country;

            // Display posted products if the user is a seller
            if (user.IsSeller)
            {
                dataGridView.DataSource = user.usersItems;
            }
            // Display purchased products if the user is a buyer
            else
            {
                // dataGridView.DataSource = user.purchasedItems;
            }
        }
    }
}
