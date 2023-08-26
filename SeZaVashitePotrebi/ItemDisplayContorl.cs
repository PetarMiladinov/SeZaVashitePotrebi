using SeZaVashitePotrebi.Classes;
using SeZaVashitePotrebi.Forms;
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
    public partial class ItemDisplayContorl : UserControl
    {
        public Item item;
        private AppUser LoggedIn;
        private Form parentForm;
        public bool SelectedForPurchase;
        public CartForm CartFormInstance { get; set; }


        public ItemDisplayContorl(Item item, AppUser user, Form parentForm)
        {
            InitializeComponent();

            this.item = item;
            this.LoggedIn = user;
            this.parentForm = parentForm;

            lblCategory.Text = item.Category.ToString();
            lblName.Text = item.Name.ToString();
            lblPrice.Text = item.Price.ToString();
            lblType.Text = item.Type.ToString();
            pictureBox1.ImageLocation = item.Image;

            btnRemoveFromCart.Visible = false;

            if (parentForm.Text.Contains("Cart"))
            {
                btnRemoveFromCart.Visible = true;
            }

        }

        private void ItemDisplayContorl_Click(object sender, EventArgs e)
        {
            ItemDetails itemDetailsForm = new ItemDetails(item);
            itemDetailsForm.ShowDialog();

        }

        private void ItemDisplayContorl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            LoggedIn.cartItems.Add(item);
            btnAddToCart.Enabled = false;
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            LoggedIn.cartItems.Remove(item);
            parentForm.Controls.Remove(this);

            //good way to check in which form we are working
            if (parentForm is CartForm cartForm)
            {
                cartForm.RefreshCart();
            }
        }
    }
}
