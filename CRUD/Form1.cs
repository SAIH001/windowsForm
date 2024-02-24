

using System.Collections.Generic;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {

        SqlConnection connectionDb = new SqlConnection("Data Source=FACULTY-99;Initial Catalog=Crud2212E1;User ID=sa;Password=aptech");
        public Form1()
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
            Login loginform = new Login();
            loginform.Show();

            this.Hide();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {


        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            String User_Enter_Name = username.Text;
            String User_Enter_email = useremail.Text;
            String User_Enter_password = userpassword.Text;



            String insertQuery = "insert into userRegistration values('"+User_Enter_Name+"','"+User_Enter_email+"','"+User_Enter_password+"')";

            SqlCommand dlvryBoy = new SqlCommand(insertQuery, connectionDb);

            dlvryBoy.ExecuteNonQuery();

            MessageBox.Show("Data Inserted Successfull !!");

            username.Text = "";
            useremail.Text = "";
            userpassword.Text = "";


        }
    }
}