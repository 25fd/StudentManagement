namespace StudentManagement
{
    partial class StudentCoursesSelection
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
            this.std_id = new System.Windows.Forms.TextBox();
            this.start_selection = new System.Windows.Forms.Button();
            this.select_courses = new System.Windows.Forms.Button();
            this.available_courses = new System.Windows.Forms.ComboBox();
            this.std_information = new System.Windows.Forms.ListBox();
            this.unasign_course = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selected_courses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // std_id
            // 
            this.std_id.Location = new System.Drawing.Point(374, 139);
            this.std_id.Margin = new System.Windows.Forms.Padding(2);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(250, 47);
            this.std_id.TabIndex = 1;
            this.std_id.TextChanged += new System.EventHandler(this.std_id_TextChanged);
            // 
            // start_selection
            // 
            this.start_selection.Location = new System.Drawing.Point(444, 855);
            this.start_selection.Margin = new System.Windows.Forms.Padding(2);
            this.start_selection.Name = "start_selection";
            this.start_selection.Size = new System.Drawing.Size(300, 57);
            this.start_selection.TabIndex = 4;
            this.start_selection.Text = "GO";
            this.start_selection.UseVisualStyleBackColor = true;
            this.start_selection.Click += new System.EventHandler(this.start_selection_Click);
            // 
            // select_courses
            // 
            this.select_courses.Location = new System.Drawing.Point(212, 633);
            this.select_courses.Margin = new System.Windows.Forms.Padding(2);
            this.select_courses.Name = "select_courses";
            this.select_courses.Size = new System.Drawing.Size(187, 57);
            this.select_courses.TabIndex = 5;
            this.select_courses.Text = "Assign";
            this.select_courses.UseVisualStyleBackColor = true;
            this.select_courses.Click += new System.EventHandler(this.select_courses_Click);
            // 
            // available_courses
            // 
            this.available_courses.FormattingEnabled = true;
            this.available_courses.Location = new System.Drawing.Point(374, 319);
            this.available_courses.Margin = new System.Windows.Forms.Padding(2);
            this.available_courses.Name = "available_courses";
            this.available_courses.Size = new System.Drawing.Size(302, 49);
            this.available_courses.TabIndex = 6;
            // 
            // std_information
            // 
            this.std_information.FormattingEnabled = true;
            this.std_information.ItemHeight = 41;
            this.std_information.Location = new System.Drawing.Point(1182, 146);
            this.std_information.Margin = new System.Windows.Forms.Padding(2);
            this.std_information.Name = "std_information";
            this.std_information.Size = new System.Drawing.Size(730, 250);
            this.std_information.TabIndex = 7;
            this.std_information.SelectedIndexChanged += new System.EventHandler(this.std_information_SelectedIndexChanged);
            // 
            // unasign_course
            // 
            this.unasign_course.Location = new System.Drawing.Point(650, 644);
            this.unasign_course.Margin = new System.Windows.Forms.Padding(6);
            this.unasign_course.Name = "unasign_course";
            this.unasign_course.Size = new System.Drawing.Size(200, 59);
            this.unasign_course.TabIndex = 8;
            this.unasign_course.Text = "UnAssign";
            this.unasign_course.UseVisualStyleBackColor = true;
            this.unasign_course.Click += new System.EventHandler(this.unasign_course_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Available Course";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // selected_courses
            // 
            this.selected_courses.FormattingEnabled = true;
            this.selected_courses.Location = new System.Drawing.Point(374, 483);
            this.selected_courses.Name = "selected_courses";
            this.selected_courses.Size = new System.Drawing.Size(302, 49);
            this.selected_courses.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selected Course";
            // 
            // StudentCoursesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1056);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selected_courses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unasign_course);
            this.Controls.Add(this.std_information);
            this.Controls.Add(this.available_courses);
            this.Controls.Add(this.select_courses);
            this.Controls.Add(this.start_selection);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentCoursesSelection";
            this.Text = "StudentCoursesSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox std_id;
        private Button start_selection;
        private Button select_courses;
        private ComboBox available_courses;
        private ListBox std_information;
        private Button unasign_course;
        private Label label2;
        private ComboBox selected_courses;
        private Label label3;
    }
}