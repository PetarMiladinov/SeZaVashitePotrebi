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
    public partial class LoggedInForm : Form
    {
        public LoggedInForm()
        {
            InitializeComponent();
            var items = new List<Item>
            {
      new Item("Book", ItemType.Buy, 0, 19.99m),
    new Item("Laptop", ItemType.Buy, 0, 999.99m),
    new Item("Bicycle", ItemType.Rent, 7, 50m),
    new Item("Camera", ItemType.Rent, 3, 25m)
            };

            dataGridView1.DataSource = items;
        }
    }
}
