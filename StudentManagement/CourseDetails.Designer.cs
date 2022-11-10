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
            this.lbx_course = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // course_name
            // 
            this.course_name.Location = new System.Drawing.Point(650, 62);
            this.course_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(289, 47);
            this.course_name.TabIndex = 0;
            // 
            // display_course_summary
            // 
            this.display_course_summary.Location = new System.Drawing.Point(1362, 62);
            this.display_course_summary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.display_course_summary.Name = "display_course_summary";
            this.display_course_summary.Size = new System.Drawing.Size(187, 57);
            this.display_course_summary.TabIndex = 1;
            this.display_course_summary.Text = "Display";
            this.display_course_summary.UseVisualStyleBackColor = true;
            this.display_course_summary.Click += new System.EventHandler(this.display_course_summary_Click);
            // 
            // lbx_Students
            // 
            this.lbx_Students.Location = new System.Drawing.Point(13, 369);
            this.lbx_Students.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbx_Students.Name = "lbx_Students";
            this.lbx_Students.Size = new System.Drawing.Size(909, 527);
            this.lbx_Students.TabIndex = 2;
            this.lbx_Students.UseCompatibleStateImageBehavior = false;
            // 
            // lbx_faculty
            // 
            this.lbx_faculty.Location = new System.Drawing.Point(975, 379);
            this.lbx_faculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbx_faculty.Name = "lbx_faculty";
            this.lbx_faculty.Size = new System.Drawing.Size(830, 527);
            this.lbx_faculty.TabIndex = 3;
            this.lbx_faculty.UseCompatibleStateImageBehavior = false;
            // 
            // lbx_course
            // 
            this.lbx_course.FormattingEnabled = true;
            this.lbx_course.ItemHeight = 41;
            this.lbx_course.Location = new System.Drawing.Point(1875, 390);
            this.lbx_course.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbx_course.Name = "lbx_course";
            this.lbx_course.Size = new System.Drawing.Size(634, 496);
            this.lbx_course.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1330, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2261, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course Name";
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2539, 1538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_course);
            this.Controls.Add(this.lbx_faculty);
            this.Controls.Add(this.lbx_Students);
            this.Controls.Add(this.display_course_summary);
            this.Controls.Add(this.course_name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private ListBox lbx_course;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}