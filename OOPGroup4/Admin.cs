using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOPGroup4
{
    class Admin : Member_of_school
    {
        List<string>[,] AdminTimeTable= new List<string>[13,7];
        
        public Admin(string place, string school_name, int number_of_student, string id, string name, string surname, string password,
            int age, string sexe, string mail) : base(place, name, number_of_student, id, name, surname, password, age, sexe, mail)
        {

        }

        #region Class_Fonction

        /// <summary>
        /// Create a new Class.
        /// Choose a name, the differents students in it and the teacher in charge of them.
        /// </summary>
        /// <param name="listClass"></param>
        /// <param name="listStudent"></param>
        /// <param name="listTeacher"></param>
        public void ClassCreation(List<Class> listClass, List<Student> listStudent, List<Faculty_member> listTeacher)
        {

        }
        /// <summary>
        /// Change the teacher in charge of a class.
        /// </summary>
        /// <param name="listClass"></param>
        /// <param name="listTeacher"></param>
        public void ChangingClassTeacher(List<Class> listClass, List<Faculty_member> listTeacher)
        {

        }
        /// <summary>
        /// Change the name of a Class. Two classes can't have the same name.
        /// </summary>
        /// <param name="listClass"></param>
        public void ChangingClassName(List<Class> listClass)
        {

        }
        #endregion
        #region Subject_fonction
        // Créer une nouvellle matière
        public void NewSubject(List<Subject> listSubject, string name)
        {

        }
        //Changer le nom d'une matière
        public void ChangeSubjectName(List<Subject> listSubject, string newName, string OldName)
        {

        }
        /// <summary>
        /// Allow to change a student from one class to another.
        /// </summary>
        /// <param name="nameStudentToChange"></param>
        /// <param name="listClass"></param>
        static void ChangementDeClasse( string nameStudentToChange, List<Class> listClass)
        {

        }
        #endregion
        #region TimeTable_function
        /// <summary>
        /// Create a new timeTable for a classe.
        /// </summary>
        /// <param name="listClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="listSubject"></param>
        public void CreateTimeTable(List<Class> listClasse, string nomClasse, List<Subject> listSubject)
        {

        }
        /// <summary>
        /// Add new subject to the admin's TimeTable wich the student will be able to choose 
        /// for their own TimeTable.
        /// </summary>
        /// <param name="listClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="listSubject"></param>
        public void Add_SubjectToTimetable(List<Class> listClasse, string nomClasse, List<Subject> listSubject)
        {

        }
        /// <summary>
        /// Allows to delete, modify the shedule or the countain of a course.
        /// </summary>
        /// <param name="listClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="listSubject"></param>
        public void ModifyTimeTable(List<Class> listClasse, string nomClasse, List<Subject> listSubject)
        {

        }
        #endregion
        #region Get_information_fonction
     
        /// <summary>
        /// Get the name, field of study, name of the class supervised, 
        /// nb of hours worked per week and the information relative 
        /// to the classe Member_of_school
        /// </summary>
        public void getTeacherFile()
        {

        }
        /// <summary>
        /// Get  the information relative to the classe Member_of_school
        /// in addition of the name of the class, the number of absences and 
        /// a boolean saying if the student has payed everithing.
        /// </summary>
        public void GetStudentFile()
        {

        }
        /// <summary>
        /// Get the historical of the bills payed, their date and amount.
        /// Then print all the domain in wich the student must paid specifying if he has yet payed,
        /// and if not how much he has to pay.
        /// 
        /// </summary>
        public void GetStudentBillHistoric()
        {

        }
        /// <summary>
        /// Get all the grade of the student sorted by domain with the average in each domain 
        /// Get also the average gradeof the student.
        /// </summary>
        public void GetStudentGrade()
        {

        }
        /// <summary>
        /// Get the historical of the student's absences with their date 
        /// and a comment on their justification.
        /// </summary>
        public void GetStudentAbsenceHistorical()
        {

        }
        #endregion
        
    }
}
