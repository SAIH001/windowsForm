using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Login : Form
    {
        SqlConnection connectionDb = new SqlConnection("Data Source=FACULTY-99;Initial Catalog=Crud2212E1;User ID=sa;Password=aptech");
        public Login()
        {
            InitializeComponent();
            try
            {
                connectionDb.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 registrationform = new Form1();
            registrationform.Show();

            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String userEmail = userLoginEmail.Text;
            String userPass = userLoginPassword.Text;


            String findQuery = "select * from userRegistration where USER_EMAIL ='" + userEmail + "' AND USER_PASSWORD = '" + userPass + "' ";



            SqlCommand dkvryyyy = new SqlCommand(findQuery, connectionDb);

            SqlDataReader recordReader = dkvryyyy.ExecuteReader();

            recordReader.Read();

            String useremail = recordReader["USER_EMAIL"].ToString();
            String username = recordReader["USER_NAME"].ToString();


            CustomerPanel customerPan = new CustomerPanel(useremail,username);
            customerPan.Show();
            this.Close();


         


        }
    }
}
