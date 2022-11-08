namespace StudentManagement
{
    partial class CourseDetails
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
            this.course_name = new System.Windows.Forms.TextBox();
            this.display_course_summary = new System.Windows.Forms.Button();
            this.lbx_Students = new System.Windows.Forms.ListView();
            this.lbx_faculty = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // course_name
            // 
            this.course_name.Location = new System.Drawing.Point(182, 63);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(250, 47);
            this.course_name.TabIndex = 0;
            // 
            // display_course_summary
            // 
            this.display_course_summary.Location = new System.Drawing.Point(734, 52);
            this.display_course_summary.Name = "display_course_summary";
            this.display_course_summary.Size = new System.Drawing.Size(188, 58);
            this.display_course_summary.TabIndex = 1;
            this.display_course_summary.Text = "Display";
            this.display_course_summary.UseVisualStyleBackColor = true;
            this.display_course_summary.Click += new System.EventHandler(this.display_course_summary_Click);
            // 
            // lbx_Students
            // 
            this.lbx_Students.Location = new System.Drawing.Point(12, 368);
            this.lbx_Students.Name = "lbx_Students";
            this.lbx_Students.Size = new System.Drawing.Size(948, 808);
            this.lbx_Students.TabIndex = 2;
            this.lbx_Students.UseCompatibleStateImageBehavior = false;
            // 
            // lbx_faculty
            // 
            this.lbx_faculty.Location = new System.Drawing.Point(1248, 368);
            this.lbx_faculty.Name = "lbx_faculty";
            this.lbx_faculty.Size = new System.Drawing.Size(841, 756);
            this.lbx_faculty.TabIndex = 3;
            this.lbx_faculty.UseCompatibleStateImageBehavior = false;
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2114, 1188);
            this.Controls.Add(this.lbx_faculty);
            this.Controls.Add(this.lbx_Students);
            this.Controls.Add(this.display_course_summary);
            this.Controls.Add(this.course_name);
            this.Name = "CourseDetails";
            this.Text = "CourseDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox course_name;
        private Button display_course_summary;
        private ListView lbx_Students;
        private ListView lbx_faculty;
    }
}