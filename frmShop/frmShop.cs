using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmShop
{
    public partial class frmShop : Form
    {
        items i = new items();

        public frmShop()
        {
            InitializeComponent();
            pnlAddItems.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            i.setShopName(edtShopName.Text);
            i.setCellNumber(edtShopCell.Text);
            i.setArray(int.Parse(numProductsQuntity.Value.ToString()));
            pnlAddItems.Visible = true;
        }
    }
}
