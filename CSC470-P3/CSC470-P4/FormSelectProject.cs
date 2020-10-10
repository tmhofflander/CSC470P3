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
        public FakeProjectRepository fpr = new FakeProjectRepository();
        public FakePreferenceRespository fprefr = new FakePreferenceRespository();
        FormMain form;
        int action;

        public FormSelectProject(FormMain fm,int _action)
        {
            InitializeComponent();
            form = fm;
            action = _action;
            List<Project> projects = fpr.GetAll();
            foreach(Project project in projects)
            {
                ListBoxProjects.Items.Add(project.Id+" - "+project.Name);
            }
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            List<Project> projects = fpr.GetAll();
            string id = ListBoxProjects.Items[ListBoxProjects.SelectedIndex].ToString().Substring(0,1);


            if (action == 1)
            {

                fprefr.SetPreference(Session.appUser.UserName, projects[ListBoxProjects.SelectedIndex].Name, id);
                form.ChangeMainText(projects[ListBoxProjects.SelectedIndex].Name);
                foreach (Project project in projects)
                {
                    if (project.Id == Int32.Parse(id))
                        Session.project = project; 
                }
            }
            if (action == 2)
            {
                Project projTemp = null;

                    foreach (Project project in projects)
                    {
                        if (project.Id == Int32.Parse(id)) {
                            projTemp = project;
                        }
                    }
                FormModifyProject modify = new FormModifyProject(projTemp);
                modify.Show();
                
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
