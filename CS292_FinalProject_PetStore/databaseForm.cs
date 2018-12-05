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
        private readonly wishlistForm _wsForm;
        public databaseForm(frmPetInc frmPetInc, wishlistForm wsForm)
        {
            _frmPetInc = frmPetInc;
            _wsForm = wsForm;
            InitializeComponent();
            PopulateFilterDropdown();

			//Conditionally title the form based on which category was selected in the main form
			if (_frmPetInc.PetAccessoriesButtonClicked)
			{
				this.Text = "Pet Accessories";
			}
			else if (_frmPetInc.PetFoodButtonClicked)
			{
				this.Text = "Pet Food";
			}
			else if (_frmPetInc.DogsCatsButtonClicked)
			{
				this.Text = "Dogs & Cats";
			}
			else
			{
				this.Text = "Marine Life";
			}

		}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void goToWishlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _wsForm.Show();
        }

        //opens the form to show the user the wishlist

        //checks to see which button was clicked on the previous form, and sets visible filters and data accordingly
        private void PopulateFilterDropdown()
        {
			foreach(DataColumn el in petInfoDataSet1.Tables[0].Columns)
			{
				filterComboBox.Items.Add(el.ColumnName);
			}

			//blacklist Id & ProductType because they cause issues
			filterComboBox.Items.Remove("Id");
			filterComboBox.Items.Remove("ProductType");

			//set a default value to prevent users from trying to sort by nothing.
			filterComboBox.SelectedIndex = 0;
        }

		private void databaseForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'petInfoDataSet1.StoreItems' table. You can move, or remove it, as needed.
			//this.storeItemsTableAdapter.Fill(this.petInfoDataSet1.StoreItems);
			if (_frmPetInc.PetAccessoriesButtonClicked)
			{
				this.storeItemsTableAdapter.FillAccessories(this.petInfoDataSet1.StoreItems);
				this.Text = "Pet Accessories";
			}
			else if (_frmPetInc.PetFoodButtonClicked)
			{
				this.storeItemsTableAdapter.FillPetFood(this.petInfoDataSet1.StoreItems);
				this.Text = "Pet Food";
			}
			else if (_frmPetInc.DogsCatsButtonClicked)
			{
				this.storeItemsTableAdapter.FillDogsCats(this.petInfoDataSet1.StoreItems);
				this.Text = "Dogs & Cats";
			}
			else
			{
				this.storeItemsTableAdapter.FillMarineLife(this.petInfoDataSet1.StoreItems);
				this.Text = "Marine Life";
			}
		}

		private DataGridViewColumn GetDataColumn(String name)
		{
			foreach(DataGridViewColumn el in dataGridView1.Columns)
			{
				if (el.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return el;
				}
			}

			return null;
		}

		private void filterRadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			String selectedColumn = filterComboBox.SelectedItem.ToString();
			try
			{
				if (ascRadioBtn.Checked)
				{
					dataGridView1.Sort(GetDataColumn(selectedColumn), ListSortDirection.Ascending);
				}
				else
				{
					dataGridView1.Sort(GetDataColumn(selectedColumn), ListSortDirection.Descending);
				}
			}catch(Exception ex)
			{
				throw ex;
			}
		}

        private void addToWSBtn_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectedRowCount > 0)
            {
                int counter = _wsForm.GetDataGridView().Rows.Count;

                for(int i = 0; i < selectedRowCount; i++)
                {
                   
                    _wsForm.GetDataGridView().Rows.Add();
                    
                    for (int k = 0; k < dataGridView1.SelectedRows[i].Cells.Count; k++) {
                       _wsForm.GetDataGridView().Rows[counter-1].Cells[k].Value = dataGridView1.SelectedRows[i].Cells[k].Value;
                    }
                    counter++;
                }
            }
        }
    }
}
