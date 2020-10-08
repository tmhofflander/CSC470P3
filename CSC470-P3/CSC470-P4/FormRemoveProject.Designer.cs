namespace CSC470_P4
{
    partial class FormRemoveProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.LabelProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Project Name:";
            // 
            // btnRemoveProject
            // 
            this.btnRemoveProject.Location = new System.Drawing.Point(299, 97);
            this.btnRemoveProject.Name = "btnRemoveProject";
            this.btnRemoveProject.Size = new System.Drawing.Size(98, 26);
            this.btnRemoveProject.TabIndex = 10;
            this.btnRemoveProject.Text = "Remove Project";
            this.btnRemoveProject.UseVisualStyleBackColor = true;
            this.btnRemoveProject.Click += new System.EventHandler(this.btnRemoveProject_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 26);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LabelProject
            // 
            this.LabelProject.AutoSize = true;
            this.LabelProject.Location = new System.Drawing.Point(142, 48);
            this.LabelProject.Name = "LabelProject";
            this.LabelProject.Size = new System.Drawing.Size(25, 13);
            this.LabelProject.TabIndex = 12;
            this.LabelProject.Text = "------";
            // 
            // FormRemoveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 157);
            this.Controls.Add(this.LabelProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveProject);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormRemoveProject";
            this.Text = "Remove Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label LabelProject;
    }
}