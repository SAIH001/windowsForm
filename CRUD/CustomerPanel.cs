using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CustomerPanel : Form
    {
        String loginUserName;
        String loginUserEmail;
        public CustomerPanel(string loginUserName, string loginUserEmail)
        {
            InitializeComponent();
            this.loginUserName = loginUserName;
            this.loginUserEmail = loginUserEmail;
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {

            username.Text = loginUserName;
            useremail.Text = loginUserEmail;


        }
    }
}
