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

        Promotion schoolpromotion;
        public Faculty_member(string id, string first_name, string last_name, string password,
            string date_of_birth, string gender, string mail, string subject, List<Student> myStudent, Promotion schoolpromotion)
            : base(id, first_name, last_name, password, date_of_birth, gender, mail)
        {
            this.subject = subject;
            this.myStudent = myStudent;
            this.schoolpromotion = schoolpromotion;
        }
        #region Property
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
        #endregion
        #region fonction
       


        public string TeacherName
        {
            get { return First_name; }
        }

        public Student FindStudent(string id)
        {
            return MyStudent.Find(x => x.Id == id);
            
        }

        /// <summary>
        /// put a grade to a student;
        /// </summary>
        /// <param first_name="student"></param>
        /// <returns></returns>
        public void  Grade(string idStudent,  double idEvaluation)
        {
            
        }
        /// <summary>
        /// Allows a teacher to put an exam on one of his course.
        /// </summary>
        public void CreateAnExam()
        {

        }
        /// <summary>
        /// Allows the teacher to report a missing student, the student receive one absence 
        /// </summary>
        /// <param first_name="student"></param>
        /// <returns></returns>
        public bool ReportMissingStudent(string id, string classes, int date, int timeslot, int time)
        {
            Absence absence = new Absence(classes, date, timeslot, time);
            FindStudent(id).Absence_list.Add(absence);
            return true;
        }


        /// <summary>
        /// Get infos on a student, the student must be in the list of the teacher 
        /// </summary>
        public string  GetMyStudentInfo(string student_id)
        {
            Student student = FindStudent(student_id);
            string info = "";
            info = ("Last_name:" + student.Last_name + " First_name:" + student.First_name
                        + "\n Date_of_birth: " + student.Date_of_birth + " Gender: " + student.Gender
                        + "\n email: " + student.Mail
                        + "\n Number of absence: " + NumberOfAbsence(student));
                        

            return info;
        }
        static int NumberOfAbsence(Student student)
        {
            int counter = 0;

            for (int i = 0; i < student.Absence_list.Count; i++)
            {
                if (student.Absence_list[i].Active == true)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    #endregion
}