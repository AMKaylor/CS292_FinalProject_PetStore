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

        Boolean petAccessoriesButtonClicked = false;
        Boolean petFoodButtonClicked = false;
        Boolean dogsCatsButtonClicked = false;
        Boolean marineLifeButtonClicked = false;

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
            
            petAccessoriesButtonClicked = true;
            petFoodButtonClicked = false;
            dogsCatsButtonClicked = false;
            marineLifeButtonClicked = false;
            showDBForm();
        }

        private void btnPetFood_Click(object sender, EventArgs e)
        {
           
            petAccessoriesButtonClicked = false;
            petFoodButtonClicked = true;
            dogsCatsButtonClicked = false;
            marineLifeButtonClicked = false;
            showDBForm();
        }

        private void btnDogsCats_Click(object sender, EventArgs e)
        {
           
            petAccessoriesButtonClicked = false;
            petFoodButtonClicked = false;
            dogsCatsButtonClicked = true;
            marineLifeButtonClicked = false;
            showDBForm();
        }

        private void btnMarineLife_Click(object sender, EventArgs e)
        {
           
            petAccessoriesButtonClicked = false;
            petFoodButtonClicked = false;
            dogsCatsButtonClicked = false;
            marineLifeButtonClicked = true;
            showDBForm();
        }

        //opens the form to show the database view
        private void showDBForm()
        {
            var db = new databaseForm(this);
            db.Show();
        }

        //opens the form to show the wishlist view
        private void showWishlistForm()
        {
            var ws = new wishlistForm();
            ws.Show();
        }

        public Boolean getPAButtonClicked()
        {
            return petAccessoriesButtonClicked;
        }
        public Boolean getPFButtonClicked()
        {
            return petFoodButtonClicked;
        }
        public Boolean getDogsCatsButtonClicked()
        {
            return dogsCatsButtonClicked;
        }
        public Boolean getMarineLifeButtonClicked()
        {
            return marineLifeButtonClicked;
        }

    }
}
