using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolodexGUI
{
    public partial class frmRolodex : Form
    {
        public frmRolodex()
        {
            InitializeComponent();
        }

        private void rolodexTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolodexTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rolodexDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rolodexDatabaseDataSet.RolodexTable' table. You can move, or remove it, as needed.
            this.rolodexTableTableAdapter.Fill(this.rolodexDatabaseDataSet.RolodexTable);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
