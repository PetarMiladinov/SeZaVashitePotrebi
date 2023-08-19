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
        private Item item;
        private User LoggedIn;
        public ItemDisplayContorl(Item item, User user)
        {
            InitializeComponent();

            this.item = item;
            this.LoggedIn = user;

            lblCategory.Text = item.Category.ToString();
            lblName.Text = item.Name.ToString();
            lblPrice.Text = item.Price.ToString();
            lblType.Text = item.Type.ToString();
            pictureBox1.ImageLocation = item.Image;
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
    }
}
