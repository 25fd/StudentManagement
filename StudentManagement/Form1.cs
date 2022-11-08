namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Faculty.AddFaculty(new Faculty(
                fID.Text,
                fName.Text,
                fEmail.Text,
                fNumber.Text,
                fQualification.Text
                ));
            fID.Text = "";
            fName.Text = "";
            fEmail.Text = "";
            fNumber.Text = "";
            fQualification.Text = "";
        }

        private void add_std_Click(object sender, EventArgs e)
        {
            Student.AddStudent(new Student(
                studentID.Text,
                studentName.Text,
                studentEmail.Text,
                studentNumber.Text,
                studentDOB.Text
                ));
            studentID.Text = "";
            studentName.Text = "";
            studentEmail.Text = "";
            studentNumber.Text = "";
            studentDOB.Text = "";
        }

        private void display_std_Click(object sender, EventArgs e)
        {
            Dictionary<int, Student>.ValueCollection  register_students= Student.GetAllStudents();
            foreach (Student s in register_students)
            {
                lbx_students.Items.Add(s.ToString());
            }
        }

        private void lbx_students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_fclty_Click(object sender, EventArgs e)
        {
            Faculty.RemoveFaculty(Int32.Parse(fID.Text));
        }

        private void clear_fclty_Click(object sender, EventArgs e)
        {
            Faculty.ClearFaculties();
        }

        private void display_fclty_Click(object sender, EventArgs e)
        {
            Dictionary<int, Faculty>.ValueCollection register_faculties = Faculty.GetAllFaculties();
            foreach (Faculty f in register_faculties)
            {
                lbc_faculties.Items.Add(f.ToString());
            }
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            Course.AddCourse(new Course(
                cName.Text,
                cDescription.Text,
                cMaxAllowed.Text,
                cRoom.Text,
                cNumber.Text
                ));
            cName.Text = "";
            cDescription.Text = "";
            cMaxAllowed.Text = "";
            cRoom.Text = "";
            cNumber.Text = "";
        }

        private void remove_course_Click(object sender, EventArgs e)
        {
            Course.RemoveCourse(cName.Text);
        }

        private void clear_course_Click(object sender, EventArgs e)
        {
            Course.ClearCourses();
        }

        private void display_cpurse_Click(object sender, EventArgs e)
        {

            Dictionary<string, Course>.ValueCollection registered_courses = Course.GetAllCourses();
            foreach (Course c in registered_courses)
            {
                listBox2.Items.Add(c.ToString());
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void std_course_selection_Click(object sender, EventArgs e)
        {
            StudentCoursesSelection sForm = new StudentCoursesSelection();
            sForm.Show();

        }

        private void fclt_course_selection_Click(object sender, EventArgs e)
        {
            FacultyCourseSelection fcltForm = new FacultyCourseSelection();
            fcltForm.Show();
        }
    }
}