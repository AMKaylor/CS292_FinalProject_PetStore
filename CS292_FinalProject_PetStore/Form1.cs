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
    public partial class frmPetInc : Form
    {

        bool petAccessoriesButtonClicked = false;
        bool petFoodButtonClicked = false;
        bool dogsCatsButtonClicked = false;
        bool marineLifeButtonClicked = false;

        public frmPetInc()
        {
            InitializeComponent();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Comment for Initial Commit
        }

        private void btnMenuWishlist_Click(object sender, EventArgs e)
        {
            showWishlistForm();

        }

        private void btnPetAccessories_Click(object sender, EventArgs e)
        {
            showDBForm();
            petAccessoriesButtonClicked = true;
            petFoodButtonClicked = false;
            dogsCatsButtonClicked = false;
            marineLifeButtonClicked = false;

        }

        private void btnPetFood_Click(object sender, EventArgs e)
        {
            showDBForm();
            petAccessoriesButtonClicked = false;
            petFoodButtonClicked = true;
            dogsCatsButtonClicked = false;
            marineLifeButtonClicked = false;
        }

        private void btnDogsCats_Click(object sender, EventArgs e)
        {
            showDBForm();
            petAccessoriesButtonClicked = false;
            petFoodButtonClicked = false;
            dogsCatsButtonClicked = true;
            marineLifeButtonClicked = false;
        }

        private void btnMarineLife_Click(object sender, EventArgs e)
        {
            showDBForm();
            petAccessoriesButtonClicked = false;
            petFoodButtonClicked = false;
            dogsCatsButtonClicked = false;
            marineLifeButtonClicked = true;
        }

        //opens the form to show the database view
        private void showDBForm()
        {
            var db = new databaseForm();
            db.Show();
        }

        //opens the form to show the wishlist view
        private void showWishlistForm()
        {
            var ws = new wishlistForm();
            ws.Show();
        }

        public bool getPAButtonClicked()
        {
            return petAccessoriesButtonClicked;
        }
        public bool getPFButtonClicked()
        {
            return petFoodButtonClicked;
        }
    }
}
