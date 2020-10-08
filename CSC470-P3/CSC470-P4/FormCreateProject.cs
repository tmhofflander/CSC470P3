﻿using System;
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
    public partial class FormCreateProject : Form
    {
        
        public FormCreateProject()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FakeProjectRepository fpr = new FakeProjectRepository();
            Project project = new Project { Name = textBox1.Text };
            fpr.Add(project, out project.Id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {

        }
    }
}
