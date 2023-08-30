using System.ComponentModel;
using System.Drawing.Text;
using System.Windows.Forms;
using SeZaVashitePotrebi.Classes;
using SeZaVashitePotrebi.Forms;

//TODO: Post Button to be placed where its neeeded.

namespace SeZaVashitePotrebi
{
    public partial class Form1 : Form
    {
        public List<ItemDisplayContorl> Boxes { get; set; }

        

        public Form1()
        {
            InitializeComponent();

            //Controls.Add(flowLayoutPanel1);
            Boxes = new List<ItemDisplayContorl>();
            Program.RegisteredUsers = new List<AppUser>();
            comboBox1.DataSource = Enum.GetValues(typeof(ItemCategory));

            Program.RegisteredUsers.Add(new AppUser("username", "pass", "user@gmail.com", "Macedonia", "Negotino", "070/000-000", true));
            Program.RegisteredUsers.Add(new AppUser("zokipoki", "pass", "zokipoki@gmail.com", "Macedonia", "Skopje", "072/000-000", true));

            Program.AllItems = new List<Item>() {
                new Item("Book", "A cook book", ItemType.Buy, ItemCategory.Books, 0, 19.99m, "https://static.vecteezy.com/system/resources/thumbnails/001/486/411/small/open-book-icon-free-vector.jpg", Program.RegisteredUsers[0]),
                new Item("Laptop", "New laptop", ItemType.Buy, ItemCategory.Electronics, 0, 1000m, "https://static.vecteezy.com/system/resources/thumbnails/000/551/713/small/laptop_007.jpg", Program.RegisteredUsers[0]),
                new Item("Bicycle", "Used bicycle", ItemType.Rent, ItemCategory.Vehicle, 7, 100m, "https://static.vecteezy.com/system/resources/thumbnails/005/132/881/small/ecology-bicycle-icon-set-vector.jpg", Program.RegisteredUsers[0]),
                new Item("Camera", "GoPro camera", ItemType.Rent, ItemCategory.Electronics, 3, 250m, "https://static.vecteezy.com/system/resources/thumbnails/006/998/431/small/photo-camera-icons-photo-camera-icon-design-illustration-photo-camera-simple-sign-photo-camera-image-vector.jpg", Program.RegisteredUsers[0]),
                new Item("Motorcycle", "New superbike", ItemType.Buy, ItemCategory.Vehicle, 0, 20000m, "https://static.vecteezy.com/system/resources/thumbnails/004/875/492/small/motorbike-rider-motorcycle-racing-illustration-in-white-background-vector.jpg", Program.RegisteredUsers[0])
            };

            foreach(Item item in Program.AllItems)
            {
                Program.RegisteredUsers[0].usersItems.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            tbSearch.Size = new Size((int)((int)this.Width * 0.40), 27);
            btnSearch.Location = new Point((int)((int)this.Width * 0.40) + 20, tbSearch.Location.Y);
            btnRegister.Location = new Point(this.Width - 150, tbSearch.Location.Y);
            btnLogIn.Location = new Point(this.Width - 265, tbSearch.Location.Y);
            btnPost.Visible = false;
            btnMyAcc.Visible = false;
            uname.Visible = false;
            btnCart.Visible = false;
            flowLayoutPanel1.Location = new Point(0, 80);
            flowLayoutPanel1.Size = new Size(this.Width, (int)((int)this.Height * 0.8));
            MakeBoxes(Program.AllItems);


            /*            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                        tbSearch.Width = (int)(this.Width * 0.4);
                        tbSearch.Location = new Point(this.Width - tbSearch.Width - 20, tbSearch.Location.Y);

                        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnSearch.Location = new Point(tbSearch.Location.X + tbSearch.Width + 5, btnSearch.Location.Y);

                        // Position other buttons using anchoring
                        btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnRegister.Location = new Point(this.Width - 150, tbSearch.Location.Y);

                        btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnLogIn.Location = new Point(this.Width - 265, tbSearch.Location.Y);
            */

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
                Boxes.Add(new ItemDisplayContorl(it[i], Program.LoggedIn, this));
                if (Program.LoggedIn == null)
                {
                    Boxes[i].btnAddToCart.Visible = false;
                }

                flowLayoutPanel1.Controls.Add(Boxes[i]);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;
            ItemCategory selectedCategory = (ItemCategory)comboBox1.SelectedItem;
            List<Item> search = Program.AllItems.FindAll(el => el.Name.Contains(tbSearch.Text, StringComparison.CurrentCultureIgnoreCase) &&
                (selectedCategory == ItemCategory.All || el.Category == selectedCategory));
            MakeBoxes(search);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm(Program.RegisteredUsers);
            if (login.ShowDialog() == DialogResult.OK && login.user != null)
            {
                Program.LoggedIn = login.user;
                btnLogIn.Visible = false;
                btnRegister.Visible = false;
                login.Close();

                uname.Text = Program.LoggedIn.Username;
                uname.Location = new Point(this.Width - 350, tbSearch.Location.Y);
                uname.Font = new Font("Arial", 14, FontStyle.Bold);
                uname.Size = new Size(200, 40);
                if (Program.LoggedIn != null && Program.LoggedIn.IsSeller)
                {
                    // If the user is logged in as a seller, make the "Post Item" button visible
                    btnPost.Visible = true;
                    btnPost.Location = new Point(uname.Location.X - btnPost.Width - 35, uname.Location.Y);
                    btnPost.Size = new Size(100, 40);
                }
                else
                {
                    // If the user is not a seller or not logged in, hide the "Post Item" button
                    btnPost.Visible = false;
                }
                btnMyAcc.Visible = true;
                uname.Visible = true;
                btnMyAcc.Text = "My Account";
                btnMyAcc.Location = btnRegister.Location = new Point(this.Width - 170, tbSearch.Location.Y);
                btnMyAcc.Size = new Size(120, 36);
                btnCart.Visible = true;
                btnCart.Size = new Size(120, 36);
                btnCart.Location = new Point(uname.Location.X - 250, tbSearch.Location.Y);
                MakeBoxes(Program.AllItems);
                foreach (ItemDisplayContorl itemDisplay in Boxes)
                {
                    itemDisplay.btnAddToCart.Visible = true;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(Program.RegisteredUsers);
            if (register.ShowDialog() == DialogResult.OK && register.user != null)
            {
                Program.RegisteredUsers.Add(register.user);
                register.Close();
            }
        }

        private void btnMyAcc_Click(object sender, EventArgs e)
        {
            MyAccountForm myAccountForm = new MyAccountForm(Program.LoggedIn);
            myAccountForm.ShowDialog();
            MakeBoxes(Program.AllItems);
            if(Program.LoggedIn == null)
            {
                btnPost.Visible = false;
                btnMyAcc.Visible = false;
                uname.Visible = false;
                btnCart.Visible = false;
                btnLogIn.Visible = true;
                btnRegister.Visible = true;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            PostItemForm postItemForm = new PostItemForm(Program.LoggedIn);
            postItemForm.ShowDialog();
            if (postItemForm.newItem != null)
            {
                Program.AllItems.Add(postItemForm.newItem);
                Program.LoggedIn.usersItems.Add(postItemForm.newItem);
                MakeBoxes(Program.AllItems);
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tbSearch.Size = new Size((int)((int)this.Width * 0.40), 27);
            btnSearch.Location = new Point((int)((int)this.Width * 0.40) + 20, tbSearch.Location.Y);
            if (Program.LoggedIn == null)
            {
                btnRegister.Location = new Point(this.Width - 150, tbSearch.Location.Y);
                btnLogIn.Location = new Point(this.Width - 265, tbSearch.Location.Y);
            }
            else
            {
                uname.Location = new Point(this.Width - 350, tbSearch.Location.Y);
                btnPost.Location = new Point(uname.Location.X - btnPost.Width - 35, uname.Location.Y);
                btnMyAcc.Location = btnRegister.Location = new Point(this.Width - 170, tbSearch.Location.Y);
                btnCart.Location = new Point(uname.Location.X - 250, tbSearch.Location.Y);
            }

            flowLayoutPanel1.Location = new Point(0, 80);
            flowLayoutPanel1.Size = new Size(this.Width, (int)((int)this.Height * 0.8));
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(Program.LoggedIn);
            cartForm.ShowDialog();
            MakeBoxes(Program.AllItems);
        }
    }
}