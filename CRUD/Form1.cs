

using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();

            this.Hide();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connectdb = new SqlConnection("Data Source=FACULTY-99;Initial Catalog=Crud2212E1;User ID=sa;Password=aptech");
            connectdb.Open();
        }
    }
}