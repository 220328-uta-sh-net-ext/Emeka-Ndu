namespace P0_Restaurant_Review
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {Userlogin.Text}. \n Please continue to see and review restaurants");
        }
    }
}