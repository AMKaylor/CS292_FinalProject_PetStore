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
        public frmPetInc()
        {
            InitializeComponent();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
