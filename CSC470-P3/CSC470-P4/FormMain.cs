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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            AppUser appUser = new AppUser();
            CenterToScreen();
            DialogResult result = DialogResult.OK;
            if (!appUser.IsAuthenticated && result == DialogResult.OK)
            {
                FormLogin formLogin = new FormLogin();
                result = formLogin.ShowDialog();
            }



            if (result != DialogResult.OK)
            {
                Close();
            }
            else
            {
                this.Text = "Main - No Project Selected";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
