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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ft_unassign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(801, 867);
            this.go.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(287, 57);
            this.go.TabIndex = 0;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // stslect_course
            // 
            this.stslect_course.Location = new System.Drawing.Point(512, 722);
            this.stslect_course.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stslect_course.Name = "stslect_course";
            this.stslect_course.Size = new System.Drawing.Size(191, 57);
            this.stslect_course.TabIndex = 1;
            this.stslect_course.Text = "Assign";
            this.stslect_course.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stslect_course.UseVisualStyleBackColor = true;
            this.stslect_course.Click += new System.EventHandler(this.stslect_course_Click);
            // 
            // fclt_id
            // 
            this.fclt_id.Location = new System.Drawing.Point(582, 160);
            this.fclt_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fclt_id.Name = "fclt_id";
            this.fclt_id.Size = new System.Drawing.Size(250, 47);
            this.fclt_id.TabIndex = 2;
            // 
            // clouse_list_box
            // 
            this.clouse_list_box.FormattingEnabled = true;
            this.clouse_list_box.Location = new System.Drawing.Point(582, 537);
            this.clouse_list_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clouse_list_box.Name = "clouse_list_box";
            this.clouse_list_box.Size = new System.Drawing.Size(302, 49);
            this.clouse_list_box.TabIndex = 3;
            // 
            // slected_course
            // 
            this.slected_course.AutoSize = true;
            this.slected_course.Location = new System.Drawing.Point(1318, 408);
            this.slected_course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.slected_course.Name = "slected_course";
            this.slected_course.Size = new System.Drawing.Size(98, 41);
            this.slected_course.TabIndex = 4;
            this.slected_course.Text = "Result";
            this.slected_course.Click += new System.EventHandler(this.slected_course_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "FacultyID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 554);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available COurse";
            // 
            // ft_unassign
            // 
            this.ft_unassign.Location = new System.Drawing.Point(1133, 722);
            this.ft_unassign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ft_unassign.Name = "ft_unassign";
            this.ft_unassign.Size = new System.Drawing.Size(200, 59);
            this.ft_unassign.TabIndex = 7;
            this.ft_unassign.Text = "UnAssign";
            this.ft_unassign.UseVisualStyleBackColor = true;
            this.ft_unassign.Click += new System.EventHandler(this.ft_unassign_Click);
            // 
            // FacultyCourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1056);
            this.Controls.Add(this.ft_unassign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slected_course);
            this.Controls.Add(this.clouse_list_box);
            this.Controls.Add(this.fclt_id);
            this.Controls.Add(this.stslect_course);
            this.Controls.Add(this.go);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Label label1;
        private Label label2;
        private Button ft_unassign;
    }
}