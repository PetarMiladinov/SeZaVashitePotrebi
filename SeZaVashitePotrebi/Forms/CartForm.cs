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
    public partial class CartForm : Form
    {
        User user;
        public List<ItemDisplayContorl> Boxes { get; set; } = new List<ItemDisplayContorl>();
        public List<Item> items { get; set; }
        public CartForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.items = user.cartItems;
        }

        private void MakeBoxes(List<Item> it)
        {
            foreach (ItemDisplayContorl box in Boxes)
            {
                flowLayoutPanel1.Controls.Remove(box);
            }
            Boxes.Clear();
            for (int i = 0; i < it.Count; i++)
            {
                Boxes.Add(new ItemDisplayContorl(it[i], user));
                Boxes[i].btnAddToCart.Visible = false;

                flowLayoutPanel1.Controls.Add(Boxes[i]);
            }

        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            MakeBoxes(items);
            decimal total = 0;
            foreach(Item item in items)
            {
                total += item.Price;
            }
            lblTotal.Text = total.ToString();
        }
    }
}
