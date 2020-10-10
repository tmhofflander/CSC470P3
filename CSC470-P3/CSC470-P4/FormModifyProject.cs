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
    public partial class FormModifyProject : Form
    {
        Project toModify;
        FakeProjectRepository fpr = new FakeProjectRepository();
        public FormModifyProject(Project _toModify)
        {
            InitializeComponent();
            CenterToScreen();

            toModify = _toModify;

            textBox1.Text = toModify.Name;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.Id = toModify.Id;
            project.Name = textBox1.Text.Trim();
            string result = fpr.Modify(project.Id, project);

            if (result != "")
                MessageBox.Show(result);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
