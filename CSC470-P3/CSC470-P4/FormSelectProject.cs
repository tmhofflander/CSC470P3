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
    public partial class FormSelectProject : Form
    {
        FakeProjectRepository fpr = new FakeProjectRepository();
        public FormSelectProject()
        {
            InitializeComponent();
            ListBoxProjects.DataSource = fpr;
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
