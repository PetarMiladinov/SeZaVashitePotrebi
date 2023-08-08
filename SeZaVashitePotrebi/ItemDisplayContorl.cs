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
        public ItemDisplayContorl(Item item)
        {
            InitializeComponent();

            this.item = item;

            lblCategory.Text = item.Category.ToString();
            lblName.Text = item.Name.ToString();
            lblPrice.Text = item.Price.ToString();
            lblType.Text = item.Type.ToString();
            pictureBox1.ImageLocation = item.Image;
        }
    }
}
