namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentID = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentEmail = new System.Windows.Forms.TextBox();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.studentDOB = new System.Windows.Forms.TextBox();
            this.fID = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.fEmail = new System.Windows.Forms.TextBox();
            this.fNumber = new System.Windows.Forms.TextBox();
            this.fQualification = new System.Windows.Forms.TextBox();
            this.cNumber = new System.Windows.Forms.TextBox();
            this.cName = new System.Windows.Forms.TextBox();
            this.cDescription = new System.Windows.Forms.TextBox();
            this.cRoom = new System.Windows.Forms.TextBox();
            this.cMaxAllowed = new System.Windows.Forms.TextBox();
            this.add_std = new System.Windows.Forms.Button();
            this.remove_std = new System.Windows.Forms.Button();
            this.clear_std = new System.Windows.Forms.Button();
            this.display_std = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.remove_fclty = new System.Windows.Forms.Button();
            this.clear_fclty = new System.Windows.Forms.Button();
            this.display_fclty = new System.Windows.Forms.Button();
            this.add_course = new System.Windows.Forms.Button();
            this.remove_course = new System.Windows.Forms.Button();
            this.clear_course = new System.Windows.Forms.Button();
            this.display_cpurse = new System.Windows.Forms.Button();
            this.lbx_students = new System.Windows.Forms.ListBox();
            this.lbc_faculties = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.std_course_selection = new System.Windows.Forms.Button();
            this.fclt_course_selection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(126, 88);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(250, 47);
            this.studentID.TabIndex = 0;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(567, 86);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(250, 47);
            this.studentName.TabIndex = 1;
            // 
            // studentEmail
            // 
            this.studentEmail.Location = new System.Drawing.Point(1017, 75);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(250, 47);
            this.studentEmail.TabIndex = 2;
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(1382, 79);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(250, 47);
            this.studentNumber.TabIndex = 3;
            // 
            // studentDOB
            // 
            this.studentDOB.Location = new System.Drawing.Point(1797, 88);
            this.studentDOB.Name = "studentDOB";
            this.studentDOB.Size = new System.Drawing.Size(250, 47);
            this.studentDOB.TabIndex = 4;
            // 
            // fID
            // 
            this.fID.Location = new System.Drawing.Point(126, 454);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(250, 47);
            this.fID.TabIndex = 5;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(567, 454);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(250, 47);
            this.fName.TabIndex = 6;
            // 
            // fEmail
            // 
            this.fEmail.Location = new System.Drawing.Point(1017, 454);
            this.fEmail.Name = "fEmail";
            this.fEmail.Size = new System.Drawing.Size(250, 47);
            this.fEmail.TabIndex = 7;
            // 
            // fNumber
            // 
            this.fNumber.Location = new System.Drawing.Point(1382, 454);
            this.fNumber.Name = "fNumber";
            this.fNumber.Size = new System.Drawing.Size(250, 47);
            this.fNumber.TabIndex = 8;
            // 
            // fQualification
            // 
            this.fQualification.Location = new System.Drawing.Point(1797, 454);
            this.fQualification.Name = "fQualification";
            this.fQualification.Size = new System.Drawing.Size(250, 47);
            this.fQualification.TabIndex = 9;
            // 
            // cNumber
            // 
            this.cNumber.Location = new System.Drawing.Point(126, 866);
            this.cNumber.Name = "cNumber";
            this.cNumber.Size = new System.Drawing.Size(250, 47);
            this.cNumber.TabIndex = 10;
            // 
            // cName
            // 
            this.cName.Location = new System.Drawing.Point(567, 866);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(250, 47);
            this.cName.TabIndex = 11;
            // 
            // cDescription
            // 
            this.cDescription.Location = new System.Drawing.Point(1017, 866);
            this.cDescription.Name = "cDescription";
            this.cDescription.Size = new System.Drawing.Size(250, 47);
            this.cDescription.TabIndex = 12;
            // 
            // cRoom
            // 
            this.cRoom.Location = new System.Drawing.Point(1382, 866);
            this.cRoom.Name = "cRoom";
            this.cRoom.Size = new System.Drawing.Size(250, 47);
            this.cRoom.TabIndex = 13;
            // 
            // cMaxAllowed
            // 
            this.cMaxAllowed.Location = new System.Drawing.Point(1797, 866);
            this.cMaxAllowed.Name = "cMaxAllowed";
            this.cMaxAllowed.Size = new System.Drawing.Size(250, 47);
            this.cMaxAllowed.TabIndex = 14;
            // 
            // add_std
            // 
            this.add_std.Location = new System.Drawing.Point(213, 255);
            this.add_std.Name = "add_std";
            this.add_std.Size = new System.Drawing.Size(188, 58);
            this.add_std.TabIndex = 15;
            this.add_std.Text = "add Student";
            this.add_std.UseVisualStyleBackColor = true;
            this.add_std.Click += new System.EventHandler(this.add_std_Click);
            // 
            // remove_std
            // 
            this.remove_std.Location = new System.Drawing.Point(662, 254);
            this.remove_std.Name = "remove_std";
            this.remove_std.Size = new System.Drawing.Size(188, 58);
            this.remove_std.TabIndex = 16;
            this.remove_std.Text = "remove Student";
            this.remove_std.UseVisualStyleBackColor = true;
            // 
            // clear_std
            // 
            this.clear_std.Location = new System.Drawing.Point(1134, 254);
            this.clear_std.Name = "clear_std";
            this.clear_std.Size = new System.Drawing.Size(188, 58);
            this.clear_std.TabIndex = 17;
            this.clear_std.Text = "clear Student";
            this.clear_std.UseVisualStyleBackColor = true;
            this.clear_std.Click += new System.EventHandler(this.clear_std_Click);
            // 
            // display_std
            // 
            this.display_std.Location = new System.Drawing.Point(1469, 245);
            this.display_std.Name = "display_std";
            this.display_std.Size = new System.Drawing.Size(188, 58);
            this.display_std.TabIndex = 18;
            this.display_std.Text = "display Student";
            this.display_std.UseVisualStyleBackColor = true;
            this.display_std.Click += new System.EventHandler(this.display_std_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 684);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 58);
            this.button5.TabIndex = 19;
            this.button5.Text = "add faculty";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // remove_fclty
            // 
            this.remove_fclty.Location = new System.Drawing.Point(706, 681);
            this.remove_fclty.Name = "remove_fclty";
            this.remove_fclty.Size = new System.Drawing.Size(188, 58);
            this.remove_fclty.TabIndex = 20;
            this.remove_fclty.Text = "remove faculty";
            this.remove_fclty.UseVisualStyleBackColor = true;
            this.remove_fclty.Click += new System.EventHandler(this.remove_fclty_Click);
            // 
            // clear_fclty
            // 
            this.clear_fclty.Location = new System.Drawing.Point(1146, 667);
            this.clear_fclty.Name = "clear_fclty";
            this.clear_fclty.Size = new System.Drawing.Size(188, 58);
            this.clear_fclty.TabIndex = 21;
            this.clear_fclty.Text = "clear faculty";
            this.clear_fclty.UseVisualStyleBackColor = true;
            this.clear_fclty.Click += new System.EventHandler(this.clear_fclty_Click);
            // 
            // display_fclty
            // 
            this.display_fclty.Location = new System.Drawing.Point(1592, 648);
            this.display_fclty.Name = "display_fclty";
            this.display_fclty.Size = new System.Drawing.Size(188, 58);
            this.display_fclty.TabIndex = 22;
            this.display_fclty.Text = "display faculty";
            this.display_fclty.UseVisualStyleBackColor = true;
            this.display_fclty.Click += new System.EventHandler(this.display_fclty_Click);
            // 
            // add_course
            // 
            this.add_course.Location = new System.Drawing.Point(331, 944);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(188, 58);
            this.add_course.TabIndex = 23;
            this.add_course.Text = "add Course";
            this.add_course.UseVisualStyleBackColor = true;
            this.add_course.Click += new System.EventHandler(this.add_course_Click);
            // 
            // remove_course
            // 
            this.remove_course.Location = new System.Drawing.Point(909, 964);
            this.remove_course.Name = "remove_course";
            this.remove_course.Size = new System.Drawing.Size(188, 58);
            this.remove_course.TabIndex = 24;
            this.remove_course.Text = "remove Course";
            this.remove_course.UseVisualStyleBackColor = true;
            this.remove_course.Click += new System.EventHandler(this.remove_course_Click);
            // 
            // clear_course
            // 
            this.clear_course.Location = new System.Drawing.Point(1375, 958);
            this.clear_course.Name = "clear_course";
            this.clear_course.Size = new System.Drawing.Size(188, 58);
            this.clear_course.TabIndex = 25;
            this.clear_course.Text = "clear Course";
            this.clear_course.UseVisualStyleBackColor = true;
            this.clear_course.Click += new System.EventHandler(this.clear_course_Click);
            // 
            // display_cpurse
            // 
            this.display_cpurse.Location = new System.Drawing.Point(1730, 962);
            this.display_cpurse.Name = "display_cpurse";
            this.display_cpurse.Size = new System.Drawing.Size(188, 58);
            this.display_cpurse.TabIndex = 26;
            this.display_cpurse.Text = "disply Course";
            this.display_cpurse.UseVisualStyleBackColor = true;
            this.display_cpurse.Click += new System.EventHandler(this.display_cpurse_Click);
            // 
            // lbx_students
            // 
            this.lbx_students.FormattingEnabled = true;
            this.lbx_students.ItemHeight = 41;
            this.lbx_students.Location = new System.Drawing.Point(1925, 184);
            this.lbx_students.Name = "lbx_students";
            this.lbx_students.Size = new System.Drawing.Size(300, 209);
            this.lbx_students.TabIndex = 27;
            this.lbx_students.SelectedIndexChanged += new System.EventHandler(this.lbx_students_SelectedIndexChanged);
            // 
            // lbc_faculties
            // 
            this.lbc_faculties.FormattingEnabled = true;
            this.lbc_faculties.ItemHeight = 41;
            this.lbc_faculties.Location = new System.Drawing.Point(1897, 588);
            this.lbc_faculties.Name = "lbc_faculties";
            this.lbc_faculties.Size = new System.Drawing.Size(300, 209);
            this.lbc_faculties.TabIndex = 28;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 41;
            this.listBox2.Location = new System.Drawing.Point(1915, 1043);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(300, 209);
            this.listBox2.TabIndex = 29;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // std_course_selection
            // 
            this.std_course_selection.Location = new System.Drawing.Point(-3, 3);
            this.std_course_selection.Name = "std_course_selection";
            this.std_course_selection.Size = new System.Drawing.Size(429, 58);
            this.std_course_selection.TabIndex = 30;
            this.std_course_selection.Text = "Student Course Selection";
            this.std_course_selection.UseVisualStyleBackColor = true;
            this.std_course_selection.Click += new System.EventHandler(this.std_course_selection_Click);
            // 
            // fclt_course_selection
            // 
            this.fclt_course_selection.Location = new System.Drawing.Point(481, 12);
            this.fclt_course_selection.Name = "fclt_course_selection";
            this.fclt_course_selection.Size = new System.Drawing.Size(350, 58);
            this.fclt_course_selection.TabIndex = 31;
            this.fclt_course_selection.Text = "Faculty Course Selection";
            this.fclt_course_selection.UseVisualStyleBackColor = true;
            this.fclt_course_selection.Click += new System.EventHandler(this.fclt_course_selection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2332, 1378);
            this.Controls.Add(this.fclt_course_selection);
            this.Controls.Add(this.std_course_selection);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbc_faculties);
            this.Controls.Add(this.lbx_students);
            this.Controls.Add(this.display_cpurse);
            this.Controls.Add(this.clear_course);
            this.Controls.Add(this.remove_course);
            this.Controls.Add(this.add_course);
            this.Controls.Add(this.display_fclty);
            this.Controls.Add(this.clear_fclty);
            this.Controls.Add(this.remove_fclty);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.display_std);
            this.Controls.Add(this.clear_std);
            this.Controls.Add(this.remove_std);
            this.Controls.Add(this.add_std);
            this.Controls.Add(this.cMaxAllowed);
            this.Controls.Add(this.cRoom);
            this.Controls.Add(this.cDescription);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.cNumber);
            this.Controls.Add(this.fQualification);
            this.Controls.Add(this.fNumber);
            this.Controls.Add(this.fEmail);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.fID);
            this.Controls.Add(this.studentDOB);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.studentEmail);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox studentID;
        private TextBox studentName;
        private TextBox studentEmail;
        private TextBox studentNumber;
        private TextBox studentDOB;
        private TextBox fID;
        private TextBox fName;
        private TextBox fEmail;
        private TextBox fNumber;
        private TextBox fQualification;
        private TextBox cNumber;
        private TextBox cName;
        private TextBox cDescription;
        private TextBox cRoom;
        private TextBox cMaxAllowed;
        private Button add_std;
        private Button remove_std;
        private Button clear_std;
        private Button display_std;
        private Button button5;
        private Button remove_fclty;
        private Button clear_fclty;
        private Button display_fclty;
        private Button add_course;
        private Button remove_course;
        private Button clear_course;
        private Button display_cpurse;
        private ListBox lbx_students;
        private ListBox lbc_faculties;
        private ListBox listBox2;
        private Button std_course_selection;
        private Button fclt_course_selection;
    }
}