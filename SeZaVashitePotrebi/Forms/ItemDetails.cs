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
    public partial class ItemDetails : Form
    {
        Item item;
        public ItemDetails(Item item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void ItemDetails_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = item.Image;
            lbItemName.Text = item.Name;
            rtbDesc.Text = item.Description.ToString();
            lblType.Text = item.Type.ToString();
            lblUserName.Text = item.User.Username.ToString();
            lblPrice.Text = item.Price.ToString();
            lblEmail.Text = item.User.Email.ToString();
            lblCity.Text = item.User.City.ToString();
            lblCountry.Text = item.User.Country.ToString();
            lblPhoneNum.Text = item.User.PhoneNumber.ToString();
            if(Program.LoggedIn == null)
            {
                btnAddToCart.Visible = false;
            } else if(Program.LoggedIn.cartItems.Contains(item) || Program.LoggedIn.usersItems.Contains(item) || Program.LoggedIn.purchasedItems.Contains(item))
            {
                btnAddToCart.Visible = false;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Program.LoggedIn.cartItems.Add(item);
            this.Close();
        }
    }
}
