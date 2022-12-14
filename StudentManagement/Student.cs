using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace StudentManagement
{
    internal class Student
    {
        private int _student_id;
        private string _student_name;
        private string _student_email;
        private string _student_phone;
        private string _dob;
        private HashSet<string> _course_names;
        private static Dictionary<int, Student> students = new();

        public Student(
            string std_id,
            string std_name,
            string std_email,
            string std_phone,
            string std_dob
            )
        {
            try
            {
                this._student_id = Int32.Parse(std_id);
                this._student_name = std_name;
                this._student_email = std_email;
                this._student_phone = std_phone;
                this._dob = std_dob;
                this._course_names = new HashSet<string>();
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Data");
            }
        }

        public static void AddStudent(Student s) {
            try
            {
                students.Add(s._student_id, s);
            }
            catch (ArgumentException e) {
                MessageBox.Show("Student with Id alredy present");
            }
        }

        public static Dictionary<int, Student>.ValueCollection GetAllStudents()
        {
            return students.Values;
        }

        public static void RemoveStudents(int Id) { 
            students.Remove(Id);
        }

        public static void ClearStudents()
        {
            students.Clear();
        }

        public static void AddCoursesToStuend(int ID,string course_name) {
            try
            {

                students[ID]._course_names.Add(course_name);
            }
            catch (KeyNotFoundException e)
            {
                MessageBox.Show("Student with Id not found");
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Course alredy selected");
            }
        }

        public static void RemoveCourseFromStudent(int ID, string course_name)
        {
            try
            {
                students[ID]._course_names.Remove(course_name);
            }
            catch (KeyNotFoundException e) {
                MessageBox.Show("Student with Id not found");
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Course alredy selected");
            }
        }

        public static List<Student> GetStudentByCourseName(string coruse_name) 
        {
            List<Student> students_list = new List<Student>();
            foreach (Student s in students.Values)
            {
                if (s._course_names.Contains(coruse_name))
                {
                    students_list.Add(s);
                }
            }
            return students_list;
        }

        public static HashSet<string> GetStudentCourseName(int Id)
        {
            try { 
                return students[Id]._course_names;
            }
            catch (KeyNotFoundException e) {
                MessageBox.Show("Student with Id not found");
            }
            return null;
        }
        public override string ToString()
        {
            return "ID: " + this._student_id.ToString() +
                    "\nName: " + this._student_name +
                    "\nEmail: " + this._student_email +
                    "\nPhone: " + this._student_phone +
                    "\nDOB: " + this._dob + 
                    "\n";
        }
    }
}
