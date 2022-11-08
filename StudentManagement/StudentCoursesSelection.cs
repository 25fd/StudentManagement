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
    public partial class StudentCoursesSelection : Form
    {
        HashSet<string> selectdCourses;
        HashSet<string> avialbleCourses;
        public StudentCoursesSelection()
        {
            InitializeComponent();
        }

        private void updateListBoxes() 
        {
            std_information.Items.Clear();
            selected_courses.Items.Clear();
            available_courses.Items.Clear();

            selectdCourses = Student.GetStudentCourseName(Int32.Parse(std_id.Text));

            std_information.Items.Add(selectdCourses.ToArray().ToString());

            foreach (string scName in selectdCourses)
            {
                Console.WriteLine(scName);
                selected_courses.Items.Add(scName);
            }

            avialbleCourses.ExceptWith(selectdCourses);
            foreach (string cName in avialbleCourses)
            {
                available_courses.Items.Add(cName);
            }
        }

        private void std_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void start_selection_Click(object sender, EventArgs e)
        {
            avialbleCourses = Course.GetAllCourseNames();
            updateListBoxes();
        }

        private void select_courses_Click(object sender, EventArgs e)
        {
            Object selection = available_courses.SelectedItem;
            Console.WriteLine(selection.ToString());
            Student.AddCoursesToStuend(Int32.Parse(std_id.Text), selection.ToString());
            updateListBoxes();
        }
    }
}
