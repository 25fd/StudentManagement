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
    public partial class FacultyCourseSelection : Form
    {
        HashSet<string> avialbleCourses;
        public FacultyCourseSelection()
        {
            InitializeComponent();
        }
        private void go_Click(object sender, EventArgs e)
        {
            string selectedCourse = Faculty.getFacultyCourse(Int32.Parse(fclt_id.Text));
            if (selectedCourse != "") 
            {
                clouse_list_box.Items.Clear();
                slected_course.Text = selectedCourse;
                return;
                //throw error
            }
            slected_course.Text = "No Selection";
            avialbleCourses = Course.GetAllCourseNames();
            foreach (string cName in avialbleCourses)
            {
                clouse_list_box.Items.Add(cName);
            }
        }

        private void FacultyCourseSelection_Load(object sender, EventArgs e)
        {

        }

        private void slected_course_Click(object sender, EventArgs e)
        {

        }

        private void stslect_course_Click(object sender, EventArgs e)
        {
            Object selection = clouse_list_box.SelectedItem;
            Faculty.AddCourseToFaculties(Int32.Parse(fclt_id.Text), selection.ToString());
            slected_course.Text = selection.ToString();
            clouse_list_box.Items.Clear();
        }
    }
}
