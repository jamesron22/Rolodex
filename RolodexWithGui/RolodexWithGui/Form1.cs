using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolodexWithGui
{
    public partial class frmRolodex : Form
    {
        public frmRolodex()
        {
            InitializeComponent();
        }

        private void rolodexBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolodexBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rolodexDatabaseDataSet);

        }

        private void frmRolodex_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rolodexDatabaseDataSet.Rolodex' table. You can move, or remove it, as needed.
            this.rolodexTableAdapter.Fill(this.rolodexDatabaseDataSet.Rolodex);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
