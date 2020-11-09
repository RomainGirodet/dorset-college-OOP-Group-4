using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOPGroup4
{
    class Admin : Member_of_school
    {
        //List<string>[,] AdminTimeTable= new List<string>[13,7];
        
        public Admin(string place, string school_name, int number_of_student, string id, string name, string surname, string password,
            int age, string sexe, string mail) : base(place, name, number_of_student, id, name, surname, password, age, sexe, mail)
        {

        }

      
        #region Subject_fonction
        // Créer une nouvellle matière
        public void NewSubject(List<Subject> listSubject, string name)
        {

        }
        //Changer le nom d'une matière
        public void ChangeSubjectName(List<Subject> listSubject, string newName, string OldName)
        {

        }
       
        #endregion
        #region TimeTable_function
        /// <summary>
        /// Create a new timeTable.
        /// </summary>
        /// <param name="listClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="listSubject"></param>
        public void CreateTimeTable()
        {

        }
        /// <summary>
        /// Add new subject to the admin's TimeTable wich the student will be able to choose 
        /// for their own TimeTable.
        /// </summary>
        /// <param name="listClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="listSubject"></param>
        public void Add_SubjectToTimetable(string studentID)
        {

        }
        
        public void Delete_SubjectFromTimetable(string studentID)
        {

        }
        //public void Exchange_SubjectFromTimetable(string studentID, List<Subject> listSubject)
        //{

        //}
        public void Move_SubjectFromTimetable(string studentID)
        {

        }
        public void Modify_SubjectFromTimetable(string studentID)
        {

        }
        #endregion
        #region Payement_and_Invoice_Function
        public void CreateInvoice(string studentID)
        {

        }
        public void MofifyInvoiceDeadline(string studentID)
        {

        }
        public void MofifyInvoiceAmount(string studentID)
        {

        }
        public void MofifyInvoiceName(string studentID)
        {

        }

        #endregion
        #region Absence_fonction
        /// <summary>
        /// Allows to change the parameter "active" from the absence from 1 to 0. test
        /// The admin can then add a comment to justificate the absence.
        /// </summary>
        /// <param name="nameStudent"></param>
        public void JustifyAnAbsence(string studentID)
        {

        }
        #endregion
        #region Get_information_fonction

        /// <summary>
        /// Get the name, field of study, name of the class supervised, 
        /// nb of hours worked per week and the information relative 
        /// to the classe Member_of_school
        /// </summary>
        public void GetTeacherFile(string teacherID)
        {

        }
        /// <summary>
        /// Get  the information relative to the classe Member_of_school
        /// in addition of the name of the class, the number of absences and 
        /// a boolean saying if the student has payed everithing.
        /// </summary>
        public void GetStudentFile(string studentID)
        {

        }
        /// <summary>
        /// Get the historic of the bills payed, their date and amount.
        /// 
        /// </summary>
        public void GetStudentBillHistoric(string studentID)
        {

        }
        /// <summary>
        /// Get the historic of the bills payed linked to a specific invoice with their date and amount.
        /// </summary>
        public void GetStudentBillHistoricOfOneInvoice(string studentID)
        {

        }
        /// <summary>
        /// Get all the invoice of the student with the amount to pay, the amount already payed and the deadline.
        /// </summary>
        public void GetStudentInvoice(string studentID)
        {

        }
        /// <summary>
        /// Get all the grade of the student sorted by domain with the average in each domain 
        /// Get also the average grade of the student.
        /// </summary>
        public void GetStudentGrade(string studentID)
        {

        }
        /// <summary>
        /// Get the historical of the student's absences with their date 
        /// and a comment on their justification.
        /// </summary>
        public void GetStudentAbsenceHistorical(string studentID)
        {

        }
        #endregion
        

    }
}
