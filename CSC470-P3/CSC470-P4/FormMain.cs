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
        public AppUser appUser = Session.appUser;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            CenterToScreen();
            DialogResult result = DialogResult.OK;
            if (!appUser.IsAuthenticated && result == DialogResult.OK)
            {
                FormLogin formLogin = new FormLogin();
               
                result = formLogin.ShowDialog();
                appUser = formLogin.appUser;
                Session.appUser = appUser;
            }

            if(result != DialogResult.OK)
            {
                Close();
            }
            else
            {
                FormSelectProject select = new FormSelectProject(this, 1);
                if (select.ShowDialog() == DialogResult.Cancel)
                    Close();
            }
        }

        public void ChangeMainText(String text)
        {
            this.Text ="Main - " + text;
        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject select = new FormSelectProject(this,1);
            select.Show();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateProject create = new FormCreateProject();
            create.Show();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject select = new FormSelectProject(this, 2);
            select.Show();
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject remove = new FormSelectProject(this, 3);
            remove.Show();
        }
    }
}
