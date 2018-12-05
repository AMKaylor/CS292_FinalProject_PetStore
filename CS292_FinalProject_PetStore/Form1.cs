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
		//Boolean Properties are false by default, the stuff in brackets is shorthand for getters and setters for each Property
		public Boolean PetAccessoriesButtonClicked { get; set; }
		public Boolean PetFoodButtonClicked { get; set; }
        public Boolean DogsCatsButtonClicked { get; set; }
        public Boolean MarineLifeButtonClicked { get; set; }
        wishlistForm wsForm = new wishlistForm();

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
            wsForm.Show();
        }

        private void btnPetAccessories_Click(object sender, EventArgs e)
        {
            PetAccessoriesButtonClicked = true;
            PetFoodButtonClicked = false;
            DogsCatsButtonClicked = false;
            MarineLifeButtonClicked = false;
            showDBForm();
        }

        private void btnPetFood_Click(object sender, EventArgs e)
        {
            PetAccessoriesButtonClicked = false;
            PetFoodButtonClicked = true;
            DogsCatsButtonClicked = false;
            MarineLifeButtonClicked = false;
            showDBForm();
        }

        private void btnDogsCats_Click(object sender, EventArgs e)
        {
            PetAccessoriesButtonClicked = false;
            PetFoodButtonClicked = false;
            DogsCatsButtonClicked = true;
            MarineLifeButtonClicked = false;
            showDBForm();
        }

        private void btnMarineLife_Click(object sender, EventArgs e)
        {
            PetAccessoriesButtonClicked = false;
            PetFoodButtonClicked = false;
            DogsCatsButtonClicked = false;
            MarineLifeButtonClicked = true;
            showDBForm();
        }

        //opens the form to show the database view
        private void showDBForm()
        {
            var db = new databaseForm(this, wsForm);
            db.Show();
        }


        //public Boolean getPAButtonClicked()
        //{
        //    return PetAccessoriesButtonClicked;
        //}
        //public Boolean getPFButtonClicked()
        //{
        //    return PetFoodButtonClicked;
        //}
        //public Boolean getDogsCatsButtonClicked()
        //{
        //    return DogsCatsButtonClicked;
        //}
        //public Boolean getMarineLifeButtonClicked()
        //{
        //    return MarineLifeButtonClicked;
        //}

    }
}
