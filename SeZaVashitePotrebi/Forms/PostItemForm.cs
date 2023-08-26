using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeZaVashitePotrebi.Classes;

//TODO: Make the whole functionlaity of Posting Items on the App

namespace SeZaVashitePotrebi
{
    public partial class PostItemForm : Form
    {
        public Item? newItem;
        public AppUser User;
        private string? selectedImagePath;

        public PostItemForm(AppUser user)
        {
            InitializeComponent();
            User = user;

            // Populate the item type ComboBox
            comboType.DataSource = Enum.GetValues(typeof(ItemType));
            comboCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDesc.Text;
            ItemCategory category = (ItemCategory)comboCategory.SelectedItem;
            decimal price;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please fill in all fields and provide a valid price.", "Posting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemType type = (ItemType)comboType.SelectedItem;
            int period = type == ItemType.Rent ? (int)numericUpDownRentalPeriod.Value : 0;

            // Create a new item
            newItem = new Item(name, type, category, period, price, selectedImagePath, User);
            

            MessageBox.Show("Item posted successfully!", "Posting", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form
            txtName.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            numericUpDownRentalPeriod.Value = 0;
            comboType.SelectedIndex = 0;
            pictureBox.Image = null;
            selectedImagePath = null;
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemType selectedType = (ItemType)comboType.SelectedItem;
            bool showRentalPeriod = selectedType == ItemType.Rent;
            daysLbl.Visible = showRentalPeriod;
            lblRentalPeriod.Visible = showRentalPeriod;
            numericUpDownRentalPeriod.Visible = showRentalPeriod;
        }

        private void PostItemForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}