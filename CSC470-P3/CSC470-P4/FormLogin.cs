using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSC470_P3;

namespace CSC470_P4
{
    public partial class FormLogin : Form
    {

        FakeAppUserRepository FAuserRepo = new FakeAppUserRepository();
        public AppUser appUser = new AppUser();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _password = txtPassword.Text;
            string _username = txtUsername.Text;

           

            if(FAuserRepo.Login(_username, _password))
            {
                FAuserRepo.SetAuthentication(_username, true);
                this.appUser = FAuserRepo.GetByUserName(_username);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password.", "Attention");
            }

        }

    }
}
