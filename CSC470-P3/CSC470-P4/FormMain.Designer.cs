namespace CSC470_P4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.removeProjectToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton1.Text = "Preferences";
            // 
            // selectProjectToolStripMenuItem
            // 
            this.selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            this.selectProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectProjectToolStripMenuItem.Text = "Select Project";
            this.selectProjectToolStripMenuItem.Click += new System.EventHandler(this.selectProjectToolStripMenuItem_Click);
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click);
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyProjectToolStripMenuItem.Text = "Modify Project";
            this.modifyProjectToolStripMenuItem.Click += new System.EventHandler(this.modifyProjectToolStripMenuItem_Click);
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            this.removeProjectToolStripMenuItem.Click += new System.EventHandler(this.removeProjectToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Issue";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countByAssigneeToolStripMenuItem,
            this.listByAssigneeToolStripMenuItem,
            this.countByArtifactToolStripMenuItem,
            this.listByArtifactToolStripMenuItem,
            this.countByDateRangeToolStripMenuItem,
            this.listByDateRangeToolStripMenuItem,
            this.trendByDateRangeToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // countByAssigneeToolStripMenuItem
            // 
            this.countByAssigneeToolStripMenuItem.Name = "countByAssigneeToolStripMenuItem";
            this.countByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            // 
            // listByAssigneeToolStripMenuItem
            // 
            this.listByAssigneeToolStripMenuItem.Name = "listByAssigneeToolStripMenuItem";
            this.listByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByAssigneeToolStripMenuItem.Text = "List by Assignee";
            // 
            // countByArtifactToolStripMenuItem
            // 
            this.countByArtifactToolStripMenuItem.Name = "countByArtifactToolStripMenuItem";
            this.countByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByArtifactToolStripMenuItem.Text = "Count by Artifact";
            // 
            // listByArtifactToolStripMenuItem
            // 
            this.listByArtifactToolStripMenuItem.Name = "listByArtifactToolStripMenuItem";
            this.listByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByArtifactToolStripMenuItem.Text = "List by Artifact";
            // 
            // countByDateRangeToolStripMenuItem
            // 
            this.countByDateRangeToolStripMenuItem.Name = "countByDateRangeToolStripMenuItem";
            this.countByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            // 
            // listByDateRangeToolStripMenuItem
            // 
            this.listByDateRangeToolStripMenuItem.Name = "listByDateRangeToolStripMenuItem";
            this.listByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByDateRangeToolStripMenuItem.Text = "List by Date Range";
            // 
            // trendByDateRangeToolStripMenuItem
            // 
            this.trendByDateRangeToolStripMenuItem.Name = "trendByDateRangeToolStripMenuItem";
            this.trendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.trendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(88, 22);
            this.toolStripDropDownButton2.Text = "Requirement";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(56, 22);
            this.toolStripDropDownButton3.Text = "Design";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton4.Text = "Test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem selectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendByDateRangeToolStripMenuItem;
    }
}

