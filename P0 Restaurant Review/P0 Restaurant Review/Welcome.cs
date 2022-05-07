using System.IO;

namespace P0_Restaurant_Review
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private const string connectionStringFilePath = "C:/Users/nduag/OneDrive/Repos/Emeka-Ndu/P0 Restaurant Review/P0 Restaurant Review/Users.mdf";
        private string connectionString;



        private void User_Click(object sender, EventArgs e)
        {
            var cusername = tbuusername.Text;   
            var cpassword = tbupassword.Text;
            var ausername = tbausername.Text;
            var apassword = tbapassword.Text;

            MessageBox.Show($"Welcome {tbuusername.Text}. \n Please continue to see and review restaurants");

        }
    }

    
}