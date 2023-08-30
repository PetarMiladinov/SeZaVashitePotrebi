using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
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
        public List<ItemDisplayContorl> Boxes { get; set; } = new List<ItemDisplayContorl>();
        public List<ItemDisplayContorl> BoxesPurchased { get; set; } = new List<ItemDisplayContorl>();
        public List<Item> items { get; set; }
        public bool LogOut { get; set; } = false;

        public MyAccountForm(Classes.AppUser? loggedIn)
        {
            InitializeComponent();

            this.user = loggedIn;

            

            this.items = loggedIn.usersItems;
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

        private void MakeBoxesPurchased(List<Item> it)
        {
            foreach (ItemDisplayContorl box in BoxesPurchased)
            {
                flowLayoutPanel2.Controls.Remove(box);
                box.Dispose();
            }
            BoxesPurchased.Clear();
            for (int i = 0; i < it.Count; i++)
            {
                BoxesPurchased.Add(new ItemDisplayContorl(it[i], user, this));
                BoxesPurchased[i].btnAddToCart.Visible = false;
                BoxesPurchased[i].btnDelete.Visible = false;
                flowLayoutPanel2.Controls.Add(BoxesPurchased[i]);
            }
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            MakeBoxes(items);
            MakeBoxesPurchased(Program.LoggedIn.purchasedItems);
            // Populate basic user information
            lblName.Text = user.Username;
            lblEmail.Text = user.Email;
            lblLocation.Text = user.City + ", " + user.Country;
        }

        public void RefreshMyAcc()
        {
            MakeBoxes(user.usersItems);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.LoggedIn = null;
            this.Close();
        }
    }
}
