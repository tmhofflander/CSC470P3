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
            List<Project> projects = fpr.GetAll();
            foreach(Project project in projects)
            {
                ListBoxProjects.Items.Add(project.Id+" - "+project.Name);
            }
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
