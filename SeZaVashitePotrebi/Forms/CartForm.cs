using SeZaVashitePotrebi.Classes;

namespace SeZaVashitePotrebi.Forms
{
    public partial class CartForm : Form
    {
        AppUser user;
        public List<ItemDisplayContorl> Boxes { get; set; } = new List<ItemDisplayContorl>();
        public List<Item> items { get; set; }

        public CartForm(AppUser user)
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
                box.Dispose();
            }
            Boxes.Clear();
            for (int i = 0; i < it.Count; i++)
            {
                Boxes.Add(new ItemDisplayContorl(it[i], user, this));
                Boxes[i].btnAddToCart.Visible = false;

                flowLayoutPanel1.Controls.Add(Boxes[i]);
            }

        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            MakeBoxes(items);
            decimal total = 0;
            foreach (Item item in items)
            {
                total += item.Price;
            }
            lblTotal.Text = total.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (var item in user.cartItems)
            {
                user.purchasedItems.Add(item);
                Program.AllItems.Remove(item);
                int idx = Program.RegisteredUsers.IndexOf(item.User);
                Program.RegisteredUsers[idx].usersItems.Remove(item);
            }

            // Clear the cart items and refresh the cart
            user.cartItems.Clear();
            RefreshCart();
        }

        private void RefreshTotal()
        {
            decimal total = 0;
            foreach (Item item in user.cartItems)
            {
                total += item.Price;
            }
            lblTotal.Text = total.ToString();
        }


        public void RefreshCart()
        {
            flowLayoutPanel1.Controls.Clear();
            MakeBoxes(user.cartItems);

            decimal total = user.cartItems.Sum(item => item.Price);
            lblTotal.Text = total.ToString();
        }
    }
}
