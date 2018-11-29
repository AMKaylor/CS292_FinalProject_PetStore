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
        private readonly frmPetInc _frmPetInc;
        public databaseForm(frmPetInc frmPetInc)
        {
            _frmPetInc = frmPetInc;
            InitializeComponent();
            chooseFilters();
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

        //checks to see which button was clicked on the previous form, and sets visible filters and data accordingly
        private void chooseFilters()
        {
            if (_frmPetInc.getPAButtonClicked())
            {
                 petAccRdioBtn1.Visible = true;
                 petAccRdioBtn2.Visible = true;
                 petAccRdioBtn3.Visible = true;
                 petFoodRdioBtn1.Visible = false;
                 petFoodRdioBtn2.Visible = false;
                 petFoodRdioBtn3.Visible = false;
                 dogsCatsRdioBtn1.Visible = false;
                 dogsCatsRdioBtn2.Visible = false;
                 dogsCatsRdioBtn3.Visible = false;
                 marineRdioBtn1.Visible = false;
                 marineRdioBtn2.Visible = false;
                 marineRdioBtn3.Visible = false;
                 
                petAccPanel.Visible = true;
                petFoodPanel.Visible = false;
                dogsCatsPanel.Visible = false;
                marinePanel.Visible = false;
                
            }
            else if (_frmPetInc.getPFButtonClicked())
            {
                 petAccRdioBtn1.Visible = false;
                 petAccRdioBtn2.Visible = false;
                 petAccRdioBtn3.Visible = false;
                 petFoodRdioBtn1.Visible = true;
                 petFoodRdioBtn2.Visible = true;
                 petFoodRdioBtn3.Visible = true;
                 dogsCatsRdioBtn1.Visible = false;
                 dogsCatsRdioBtn2.Visible = false;
                 dogsCatsRdioBtn3.Visible = false;
                 marineRdioBtn1.Visible = false;
                 marineRdioBtn2.Visible = false;
                 marineRdioBtn3.Visible = false;
                
                petAccPanel.Visible = false;
                petFoodPanel.Visible = true;
                dogsCatsPanel.Visible = false;
                marinePanel.Visible = false;
                
            }
            else if (_frmPetInc.getDogsCatsButtonClicked())
            {
                 petAccRdioBtn1.Visible = false;
                 petAccRdioBtn2.Visible = false;
                 petAccRdioBtn3.Visible = false;
                 petFoodRdioBtn1.Visible = false;
                 petFoodRdioBtn2.Visible = false;
                 petFoodRdioBtn3.Visible = false;
                 dogsCatsRdioBtn1.Visible = true;
                 dogsCatsRdioBtn2.Visible = true;
                 dogsCatsRdioBtn3.Visible = true;
                 marineRdioBtn1.Visible = false;
                 marineRdioBtn2.Visible = false;
                 marineRdioBtn3.Visible = false;
                
                petAccPanel.Visible = false;
                petFoodPanel.Visible = false;
                dogsCatsPanel.Visible = true;
                marinePanel.Visible = false;
                
            }
            else
            {
                 petAccRdioBtn1.Visible = false;
                 petAccRdioBtn2.Visible = false;
                 petAccRdioBtn3.Visible = false;
                 petFoodRdioBtn1.Visible = false;
                 petFoodRdioBtn2.Visible = false;
                 petFoodRdioBtn3.Visible = false;
                 dogsCatsRdioBtn1.Visible = false;
                 dogsCatsRdioBtn2.Visible = false;
                 dogsCatsRdioBtn3.Visible = false;
                 marineRdioBtn1.Visible = true;
                 marineRdioBtn2.Visible = true;
                 marineRdioBtn3.Visible = true;
                 
                petAccPanel.Visible = false;
                petFoodPanel.Visible = false;
                dogsCatsPanel.Visible = false;
                marinePanel.Visible = true;
                
            }
        }
    }
}
