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
    public partial class databaseForm : Form
    {
        public databaseForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void goToWishlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            showWishlistForm();
        }

        //opens the form to show the user the wishlist
        private void showWishlistForm()
        {
            var ws = new wishlistForm();
            ws.Show();
        }

        private void chooseFilters()
        {
       
        }
    }
}
