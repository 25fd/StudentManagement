using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CourseDetails : Form
    {
        public CourseDetails()
        {
            InitializeComponent();
        }

        private void display_course_summary_Click(object sender, EventArgs e)
        {
            string courseName = course_name.Text.Trim();
            Faculty faculty = Faculty.GetFacultiesByCourseName(courseName);
            List<Student> students = Student.GetStudentByCourseName(courseName);
            lbx_faculty.Items.Add(faculty.ToString());
            foreach (Student s in students)
            {
                lbx_Students.Items.Add(s.ToString());
            }
        }
    }
}
