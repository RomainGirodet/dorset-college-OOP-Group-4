using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOPGroup4
{
    class Faculty_member : Member_of_school
    {
        private string subject;
        private List<Student> myStudent;
        private Timetable timetable;

        public Faculty_member(string place, string school_name, string id, string name, string surname, string password, int age, string sex, string email, string subject, List<Student> myStudent)
            : base(place, name,id, name, surname, password, age, sex, email)
        {
            this.subject = subject;
            this.myStudent = myStudent;
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
        }

        public List<Student> MyStudent
        {
            get
            {
                return this.myStudent;
            }
        }

        public Timetable Timetable
        {
            get { return timetable; }
        }

        public string TeacherName
        {
            get { return Name; }
        }


        /// <summary>
        /// put a grade to a student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int Grade(Student student)
        {
            return 1;
        }

        /// <summary>
        /// return true if the student attended class and false if he didn't
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool Assessment(Student student)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void AccessInfo()
        {

        }
    }
}