using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Faculty
    {
        private int _faculty_id;
        private string _faculty_name;
        private string _faculty_email;
        private string _faculty_phone;
        private string _faculty_qualification;
        private List<string> _course_names;
        public static Dictionary<int, Faculty> faculties = new();

        public Faculty(
            string fclt_id,
            string fclt_name,
            string fclt_email,
            string fclt_phone,
            string fclt_qualification
            )
        {
            this._faculty_id = Int32.Parse(fclt_id);
            this._faculty_name = fclt_name;
            this._faculty_email = fclt_email;
            this._faculty_phone = fclt_phone;
            this._faculty_qualification = fclt_qualification;
            this._course_names = new List<string>();
        }

        public static void AddStudent(Faculty f)
        {
            faculties.Add(f._faculty_id, f);
        }

        public static Dictionary<int, Faculty>.ValueCollection GetAllStudents()
        {
            return faculties.Values;
        }

        public static void RemoveStudents(int Id)
        {
            faculties.Remove(Id);
        }

        public static void ClearStudents()
        {
            faculties.Clear();
        }

        public static void AddCoursesToStuends(int ID, string course_name)
        {
            faculties[ID]._course_names.Add(course_name);
        }

        public static List<Faculty> GetStudentByCourseName(string coruse_name)
        {
            List<Faculty> faculties_list = new List<Faculty>();
            foreach (Faculty f in faculties.Values)
            {
                if (f._course_names.Contains(coruse_name))
                {
                    faculties_list.Add(f);
                }
            }
            return faculties_list;
        }
        public override string ToString()
        {
            return "ID: " + this._faculty_id.ToString() +
                    "\nName: " + this._faculty_name +
                    "\nEmail: " + this._faculty_email +
                    "\nPhone: " + this._faculty_phone +
                    "\nQualification: " + this._faculty_qualification +
                    "\n";
        }
    }
}
