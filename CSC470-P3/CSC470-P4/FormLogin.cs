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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _password = txtPassword.Text;
            string _username = txtUsername.Text;

            FakeAppUserRepository FAuserRepo = new FakeAppUserRepository();

            if(FAuserRepo.Login(_username, _password))
            {
                FAuserRepo.SetAuthentication(_username, true);
                FAuserRepo.GetByUserName(_username);

                Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password.", "Attention");
                DialogResult = DialogResult.No;
            }

        }

    }
}
