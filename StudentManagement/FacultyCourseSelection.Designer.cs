namespace StudentManagement
{
    partial class FacultyCourseSelection
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
            this.go = new System.Windows.Forms.Button();
            this.stslect_course = new System.Windows.Forms.Button();
            this.fclt_id = new System.Windows.Forms.TextBox();
            this.clouse_list_box = new System.Windows.Forms.ComboBox();
            this.slected_course = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(1014, 178);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(188, 58);
            this.go.TabIndex = 0;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // stslect_course
            // 
            this.stslect_course.Location = new System.Drawing.Point(1014, 560);
            this.stslect_course.Name = "stslect_course";
            this.stslect_course.Size = new System.Drawing.Size(207, 58);
            this.stslect_course.TabIndex = 1;
            this.stslect_course.Text = "select Course";
            this.stslect_course.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stslect_course.UseVisualStyleBackColor = true;
            this.stslect_course.Click += new System.EventHandler(this.stslect_course_Click);
            // 
            // fclt_id
            // 
            this.fclt_id.Location = new System.Drawing.Point(381, 160);
            this.fclt_id.Name = "fclt_id";
            this.fclt_id.Size = new System.Drawing.Size(250, 47);
            this.fclt_id.TabIndex = 2;
            // 
            // clouse_list_box
            // 
            this.clouse_list_box.FormattingEnabled = true;
            this.clouse_list_box.Location = new System.Drawing.Point(381, 560);
            this.clouse_list_box.Name = "clouse_list_box";
            this.clouse_list_box.Size = new System.Drawing.Size(302, 49);
            this.clouse_list_box.TabIndex = 3;
            // 
            // slected_course
            // 
            this.slected_course.AutoSize = true;
            this.slected_course.Location = new System.Drawing.Point(1318, 407);
            this.slected_course.Name = "slected_course";
            this.slected_course.Size = new System.Drawing.Size(97, 41);
            this.slected_course.TabIndex = 4;
            this.slected_course.Text = "label1";
            this.slected_course.Click += new System.EventHandler(this.slected_course_Click);
            // 
            // FacultyCourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2095, 1193);
            this.Controls.Add(this.slected_course);
            this.Controls.Add(this.clouse_list_box);
            this.Controls.Add(this.fclt_id);
            this.Controls.Add(this.stslect_course);
            this.Controls.Add(this.go);
            this.Name = "FacultyCourseSelection";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FacultyCourseSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button go;
        private Button stslect_course;
        private TextBox fclt_id;
        private ComboBox clouse_list_box;
        private Label slected_course;
    }
}