using CSC470_P3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P4
{
    public partial class FormRemoveProject : Form
    {
        Project toRemove;
        FakeProjectRepository fpr = new FakeProjectRepository();
        public FormRemoveProject(Project _toRemove)
        {
            InitializeComponent();
            CenterToScreen();
            toRemove = _toRemove;
            LabelProject.Text = toRemove.Name;
        }

        private void btnRemoveProject_Click(object sender, EventArgs e)
        {
            string result = "";
            if (MessageBox.Show("Are you sure you want to remove project: \n" + toRemove.Name + "?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                result = fpr.Remove(toRemove.Id);
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
