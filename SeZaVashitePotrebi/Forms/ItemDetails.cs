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
        }
    }
}
