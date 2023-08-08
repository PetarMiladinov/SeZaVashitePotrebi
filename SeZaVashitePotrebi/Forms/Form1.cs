using System.ComponentModel;
using System.Drawing.Text;
using System.Windows.Forms;
using SeZaVashitePotrebi.Classes;

//TODO: Post Button to be placed where its neeeded.

namespace SeZaVashitePotrebi
{
    public partial class Form1 : Form
    {
        public List<Item> AllItems { get; set; }
        public List<GroupBox> Boxes { get; set; }
        // private BindingList<Item> itemsBindingList;

        public User? LoggedIn { get; set; }

        public List<User> RegisteredUsers { get; set; }

        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanel1);

            AllItems = new List<Item>() {
                new Item("Book", ItemType.Buy, ItemCategory.Books, 0, 19.99m, "https://static.vecteezy.com/system/resources/thumbnails/001/486/411/small/open-book-icon-free-vector.jpg"),
                new Item("Laptop", ItemType.Buy, ItemCategory.Electronics, 0, 999.99m, "https://static.vecteezy.com/system/resources/thumbnails/000/551/713/small/laptop_007.jpg"),
                new Item("Bicycle", ItemType.Rent, ItemCategory.Vehicle, 7, 50m, "https://static.vecteezy.com/system/resources/thumbnails/005/132/881/small/ecology-bicycle-icon-set-vector.jpg"),
                new Item("Camera", ItemType.Rent, ItemCategory.Electronics, 3, 25m, "https://static.vecteezy.com/system/resources/thumbnails/006/998/431/small/photo-camera-icons-photo-camera-icon-design-illustration-photo-camera-simple-sign-photo-camera-image-vector.jpg"),
                new Item("Motorcycle", ItemType.Buy, ItemCategory.Vehicle, 0, 50m, "https://static.vecteezy.com/system/resources/thumbnails/004/875/492/small/motorbike-rider-motorcycle-racing-illustration-in-white-background-vector.jpg")
            };

            foreach (Item item in AllItems)
            {
                ItemDisplayContorl itemDisplay = new ItemDisplayContorl(item);
                flowLayoutPanel1.Controls.Add(itemDisplay);
            }

            // Boxes = new List<GroupBox>();
            RegisteredUsers = new List<User>();
            comboBox1.DataSource = Enum.GetValues(typeof(ItemCategory));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            tbSearch.Size = new Size((int)((int)this.Width * 0.40), 27);
            btnSearch.Location = new Point((int)((int)this.Width * 0.40) + 20, tbSearch.Location.Y);
            btnRegister.Location = new Point(this.Width - 150, tbSearch.Location.Y);
            btnLogIn.Location = new Point(this.Width - 265, tbSearch.Location.Y);
            btnPost.Visible = false;
           // MakeBoxes(AllItems);
            flowLayoutPanel1.Location = new Point(0, tbSearch.Bottom + 10);
            flowLayoutPanel1.Height = (int)(this.Height * 0.6);

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
            RegisteredUsers.Add(new User("username", "pass", "user@gmail.com", "Macedonia", "Negotino", "070/000-000", false));
        }

        private void MakeBoxes(List<Item> it)
        {
            foreach (GroupBox box in Boxes)
            {
                this.Controls.Remove(box);
            }
            Boxes.Clear();
            for (int i = 0; i < it.Count; i++)
            {
                Boxes.Add(new GroupBox());
                if (i == 0)
                {
                    Boxes[i].Location = new Point(tbSearch.Location.X, tbSearch.Location.Y + 40);
                }
                else
                {
                    Boxes[i].Location = new Point(tbSearch.Location.X, Boxes[i - 1].Location.Y + 240);
                }
                Boxes[i].Size = new Size(this.Width - 60, 230);

                Label n = new Label();
                n.Text = it[i].Name;
                n.Location = new Point(250, 30);
                n.Font = new Font("Arial", 16, FontStyle.Bold);
                n.Size = new Size(200, 40);
                Boxes[i].Controls.Add(n);

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = it[i].Image;
                pictureBox.Size = new Size(200, 200);
                pictureBox.Location = new Point(10, 20);
                Boxes[i].Controls.Add(pictureBox);

                this.Controls.Add(Boxes[i]);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;
            ItemCategory selectedCategory = (ItemCategory)comboBox1.SelectedItem;
            List<Item> search = AllItems.FindAll(el => el.Name.Contains(tbSearch.Text, StringComparison.CurrentCultureIgnoreCase) &&
                (selectedCategory == ItemCategory.All || el.Category == selectedCategory));
            MakeBoxes(search);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm(RegisteredUsers);
            if (login.ShowDialog() == DialogResult.OK && login.user != null)
            {
                LoggedIn = login.user;
                btnLogIn.Visible = false;
                btnRegister.Visible = false;
                login.Close();
                Label uname = new Label();
                uname.Text = LoggedIn.Username;
                uname.Location = new Point(this.Width - 350, tbSearch.Location.Y);
                uname.Font = new Font("Arial", 14, FontStyle.Bold);
                uname.Size = new Size(200, 40);
                if (LoggedIn != null && LoggedIn.IsSeller)
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
                Button btnMyAcc = new Button();
                btnMyAcc.Text = "My Account";
                btnMyAcc.Click += new EventHandler(this.btnMyAcc_Click);
                btnMyAcc.Location = btnRegister.Location = new Point(this.Width - 170, tbSearch.Location.Y);
                btnMyAcc.Size = new Size(120, 36);
                this.Controls.Add(btnMyAcc);
                this.Controls.Add(uname);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(RegisteredUsers);
            if (register.ShowDialog() == DialogResult.OK && register.user != null)
            {
                RegisteredUsers.Add(register.user);
                register.Close();
            }
        }

        private void btnMyAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var postItemForm = new PostItemForm(LoggedIn.usersItems);
            postItemForm.ShowDialog();
        }
    }
}