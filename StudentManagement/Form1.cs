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
    }
}