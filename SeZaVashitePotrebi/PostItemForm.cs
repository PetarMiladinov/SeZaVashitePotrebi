﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: Make the whole functionlaity of Posting Items on the App

namespace SeZaVashitePotrebi
{
    public partial class PostItemForm : Form
    {
        private List<Item> items;
        private string selectedImagePath;

        public PostItemForm(List<Item> items)
        {
            InitializeComponent();
            this.items = items; // Reference to the list of items from the main form

            // Populate the item type ComboBox
            comboType.DataSource = Enum.GetValues(typeof(ItemType));
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDesc.Text;
            decimal price;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please fill in all fields and provide a valid price.", "Posting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemType type = (ItemType)comboType.SelectedItem;
            int period = type == ItemType.Rent ? (int)numericUpDownRentalPeriod.Value : 0;

            // Create a new item
            Item newItem = new Item(name, type, period, price, selectedImagePath);


            items.Add(newItem); // Add the item to the list

            MessageBox.Show("Item posted successfully!", "Posting", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form
            txtName.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            numericUpDownRentalPeriod.Value = 0;
            comboType.SelectedIndex = 0;
            pictureBox.Image = null;
            selectedImagePath = null;
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
    }
}