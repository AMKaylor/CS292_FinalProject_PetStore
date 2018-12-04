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
            PopulateFilterDropdown();
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
        private void PopulateFilterDropdown()
        {
			foreach(DataColumn el in petInfoDataSet1.Tables[0].Columns)
			{
				filterComboBox.Items.Add(el.ColumnName);
			}

			//blacklist Id
			filterComboBox.Items.Remove("Id");

			//set a default value to prevent users from trying to sort by nothing.
			filterComboBox.SelectedIndex = 0;
        }

		private void databaseForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'petInfoDataSet1.StoreItems' table. You can move, or remove it, as needed.
			this.storeItemsTableAdapter.Fill(this.petInfoDataSet1.StoreItems);
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
	}
}
