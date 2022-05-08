using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_0_Restaurant_Reviews
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.masterDataSet.Users);

        }
    }
}
