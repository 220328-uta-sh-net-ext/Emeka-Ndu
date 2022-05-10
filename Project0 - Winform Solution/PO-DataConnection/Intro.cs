using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PO_DataConnection
{
    public partial class Intro : Form
    {
        public masterEntities userInfo; 
        public Intro()
        {
            InitializeComponent();
            userInfo= new masterEntities();
        }

        public void userinfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userinfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Intro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Userinfo' table. You can move, or remove it, as needed.
            this.userinfoTableAdapter.Fill(this.masterDataSet.Userinfo);
            

            
        }

             public void introsbmit_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            cnn.Close();

            string customerName = restnameTextBox.Text;
             string customerStreet = reststreetTextBox.Text;
             var customerCity = restcityTextBox.Text;
             var customerZip = restzipcodeTextBox.Text;
             var ratings = raterestTextBox.Text;
             var reviews = reviewrestTextBox.Text;

            userInfo.SaveChanges();




           // MessageBox.Show($"Thanks {restnameTextBox.Text} for providing your information");
        }
    }
}
