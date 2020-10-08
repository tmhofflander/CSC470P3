namespace CSC470_P4
{
    partial class FormSelectProject
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
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ListBoxProjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.Location = new System.Drawing.Point(400, 309);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(123, 40);
            this.btnSelectProject.TabIndex = 0;
            this.btnSelectProject.Text = "Select Project";
            this.btnSelectProject.UseVisualStyleBackColor = true;
            this.btnSelectProject.Click += new System.EventHandler(this.btnSelectProject_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(183, 312);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(123, 37);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ListBoxProjects
            // 
            this.ListBoxProjects.FormattingEnabled = true;
            this.ListBoxProjects.Location = new System.Drawing.Point(52, 42);
            this.ListBoxProjects.Name = "ListBoxProjects";
            this.ListBoxProjects.Size = new System.Drawing.Size(484, 238);
            this.ListBoxProjects.TabIndex = 2;
            // 
            // FormSelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 411);
            this.Controls.Add(this.ListBoxProjects);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnSelectProject);
            this.Name = "FormSelectProject";
            this.Text = "FormSelectProject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectProject;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListBox ListBoxProjects;
    }
}