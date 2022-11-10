using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Course
    {
        private string _course_name;
        private string _course_discription;
        private int _course_max_allowed_students;
        private int _course_room;
        private int _course_number;
        public static Dictionary<string, Course> courses = new();

        public Course(
            string c_name,
            string c_description,
            string c_max_allowed_student,
            string c_room,
            string c_number
            ) {
            try
            {
                this._course_name = c_name;
                this._course_discription = c_description;
                this._course_max_allowed_students = Int32.Parse(c_max_allowed_student);
                this._course_room = Int32.Parse(c_room);
                this._course_number = Int32.Parse(c_number);
            }
            catch 
            {
                MessageBox.Show("Please Enter Valid Data");
            }
        }

        public static void AddCourse(Course c)
        {
            try
            {
                courses.Add(c._course_name, c);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("course already added found");
            }
        }

        public static Dictionary<string, Course>.ValueCollection GetAllCourses()
        {
            return courses.Values;
        }

        public static void RemoveCourse(string cName)
        {
            courses.Remove(cName);
        }

        public static void ClearCourses()
        {
            courses.Clear();
        }

        public static Course GetCoueseDetailsByNAme(string cName)
        {
            try {
            return courses[cName];
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("course not found");
            }
            return null;
        }

        public static HashSet<string> GetAllCourseNames () 
        {
            return courses.Keys.ToHashSet<string>();
        }

        public override string ToString()
        {
            return "Course Number: " + this._course_number +
                    "\nCourse Name: " + this._course_name +
                    "\nDiscription: " + this._course_discription +
                    "\nCourse Room: " + this._course_room +
                    "\nMax Students Allowed: " + this._course_max_allowed_students +
                    "\n";
        }
    }
}
