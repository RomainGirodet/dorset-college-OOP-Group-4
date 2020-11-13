using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace OOPGroup4
{
    class Admin : Member_of_school
    {
        Promotion promoAdmin;
        public Admin(string place, string school_name, int number_of_student, string id, string name, string surname, string password,
            int age, string sexe, string mail) : base(place, name, id, name, surname, password, age, sexe, mail)
        {


            List<Student> listAdminStudentPromo = new List<Student>();
            List<Faculty_member> listAdminTeacherPromo = new List<Faculty_member>();
            List<string> listClassSubject=new List<string>();

            Promotion promoAdmin = new Promotion(listAdminStudentPromo, listAdminTeacherPromo);
        }

      
        #region Subject_fonction
        // Créer une nouvellle matière
        public void NewSubject(string nameOfTheSubject)
        {
            bool alreadyExist = false;
            for(int i=0;i<promoAdmin.ListPromoSubject.Count;i++)
            {
                if(promoAdmin.ListPromoSubject[i]==nameOfTheSubject)
                {
                    alreadyExist = false;
                }
            }
        }
        //Changer le nom d'une matière
        public void ChangeSubject( string newName, string OldName)
        {
            for (int i = 0; i < promoAdmin.ListPromoSubject.Count; i++)
            {
                if (promoAdmin.ListPromoSubject[i] == OldName)
                {
                    promoAdmin.ListPromoSubject[i] = newName;
                }
            }
        }
        public void deleteSubject(string nameOfTheSubject)
        {
            for (int i = 0; i < promoAdmin.ListPromoSubject.Count; i++)
            {
                if (promoAdmin.ListPromoSubject[i] == nameOfTheSubject)
                {
                    promoAdmin.ListPromoSubject.RemoveAt(i);
                }
            }
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
        public void Add_CourseToTimetable(string studentID)
        {


        }
        
        public void DeleteCourseFromTimetable(string studentID)
        {

        }
        //public void Exchange_SubjectFromTimetable(string studentID, List<Course> listSubject)
        //{

        //}
        public void Move_CourseFromTimetable(string studentID)
        {

        }
        public void Modify_CourseFromTimetable(string studentID)
        {

        }
        #endregion
        #region Invoice functions
        public void CreateInvoice(string studentId,string title,double amount,DateTime deadline)
        {
            Invoice invoice = new Invoice(title, amount, deadline);
            FindStudent(studentId).Invoice_list.Add(invoice);
            // option to add invoice to several students ?
        }
        public void MofifyInvoiceDeadline(string student_id,string title,DateTime new_deadline)
        {
            FindStudent(student_id).Invoice_list.Find(x => x.Title == title).Deadline=new_deadline;
        }
        public void MofifyInvoiceAmount(string student_id,string title,double new_amount)
        {
            FindStudent(student_id).Invoice_list.Find(x => x.Title == title).Amount = new_amount;
        }
        public void MofifyInvoiceName(string student_id,string title,string new_title)
        {
            FindStudent(student_id).Invoice_list.Find(x => x.Title == title).Title = new_title;
        }

        #endregion
        #region Absence_fonction
        /// <summary>
        /// Allows to change the parameter "active" from the absence from 1 to 0.
        /// The admin can then add a comment to justificate the absence.
        /// </summary>
        /// <param name="nameStudent"></param>
        public void JustifyAnAbsence(string studentID, int absNumber, string comment)
        {
            myStudent[studentID].absence_list[absNumber - 1].active = false;
            myStudent[studentID].absence_list[absNumber - 1].comments = comment;
        }
        #endregion
        #region Get_information_fonction
        /// <summary>
        /// returns the student that corresponds to the id, else returns error
        /// </summary>
        /// <param name="id"></param>
        public Student FindStudent(string id)
        {
            return promoAdmin.ListStudentPromo.Find(x => x.Id == id);
        }

        /// <summary>
        /// Get the name, field of study, and the information relative 
        /// to the classe Member_of_school
        /// </summary>
        public void GetTeacherFile(string teacherID)
        {
            for (int i=0;i<promoAdmin.ListTeacherPromo.Count;i++)
            {
                if(promoAdmin.ListTeacherPromo[i].Id==teacherID)
                {
                    Console.WriteLine("Surname:" + promoAdmin.ListTeacherPromo[i].Surname+ " Name:" + promoAdmin.ListTeacherPromo[i].Name 
                        + "\n Fields of study: " + promoAdmin.ListTeacherPromo[i].Subject
                        + "\n Age: " + promoAdmin.ListTeacherPromo[i].Age+ " Sexe: "+promoAdmin.ListTeacherPromo[i].Sexe
                        +"\n email: "+promoAdmin.ListTeacherPromo[i].Mail);
                }
            }
            
        }
        /// <summary>
        /// Get  the information relative to the classe Member_of_school
        ///  the number of absences and 
        /// a boolean saying if the student has payed everything.
        /// </summary>
        public void GetStudentFile(string studentID)
        {
            Student student;
   
            for (int i = 0; i < promoAdmin.ListStudentPromo.Count; i++)
            {
                if (promoAdmin.ListStudentPromo[i].Id == studentID)
                {
                    student = promoAdmin.ListStudentPromo[i];
                    Console.WriteLine("Surname:" + student.Surname + " Name:" + student.Name                      
                        +"\n Age: " + student.Age + " Sexe: " + student.Sexe
                        +"\n email: " + student.Mail
                        +"\n Number of absence: "+ NumberOfAbsence(student)
                        +"\n The student has payed everything: "+ HasPayedEverything(student));
                }
            }
        }
        /// <summary>
        /// Displays all the student's payments
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
        #region AboutStudent_fonction
        static int NumberOfAbsence(Student student)
        {
            int counter = 0;
            
           for (int i=0;i<student.Absence_list.Count;i++)
            {
                if (student.Absence_list[i].Active==true)
                {
                    counter++;
                }
            }
            return counter;
        }
        static bool HasPayedEverything(Student student)
        {
           bool checker = true;
           return checker;
        }
        #endregion

    }
}
