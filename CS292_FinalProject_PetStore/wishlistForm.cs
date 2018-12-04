using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS292_FinalProject_PetStore
{
    public partial class wishlistForm : Form
    {
        public wishlistForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

		private void wishlistForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'petInfoDataSet2.WishList' table. You can move, or remove it, as needed.
			this.wishListTableAdapter.Fill(this.petInfoDataSet2.WishList);

		}

        //When clicked on, the button will delete the row that a cell has been selected in
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = wishlistGridView.CurrentCell.RowIndex;

            wishlistGridView.Rows.RemoveAt(row);
        }

    }
}
