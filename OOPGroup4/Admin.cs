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
          
            foreach(string subject in promoAdmin.ListPromoSubject)
            {
                if (subject == nameOfTheSubject)
                {
                    alreadyExist = true;
                }
            }
            if (alreadyExist==true)
            {
                Console.WriteLine("Subject already Exist");
            }
            else
            {
                promoAdmin.ListPromoSubject.Add(nameOfTheSubject);
            }
        }
        //Changer le nom d'une matière
        public void ChangeSubject( string newName, string OldName)
        {
            //foreach (string subject in promoAdmin.ListPromoSubject)
            //{
            //    if (subject == OldName)
            //    {
            //        subject = newName;
            //    }
            //}
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
            //for (int i = 0; i < promoAdmin.ListPromoSubject.Count; i++)
            //{
            //    if (promoAdmin.ListPromoSubject[i] == nameOfTheSubject)
            //    {
            //        promoAdmin.ListPromoSubject.RemoveAt(i);
            //    }
            //}
            foreach (string subject in promoAdmin.ListPromoSubject)
            {
                if (subject == nameOfTheSubject)
                {
                    promoAdmin.ListPromoSubject.Remove(subject);
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
            //myStudent[studentID].absence_list[absNumber - 1].active = false;
            //myStudent[studentID].absence_list[absNumber - 1].comments = comment;
        }
        #endregion
        #region Get_information_fonction
        /// <summary>
        /// returns the student that corresponds to the id
        /// </summary>
        /// <param name="id"></param>
        public Student FindStudent(string id)
        {
            return promoAdmin.ListStudentPromo.Find(x => x.Id == id);
        }
        public Faculty_member FindTeacher(string id)
        {
            return promoAdmin.ListTeacherPromo.Find(x => x.Id == id);
        }
        /// <summary>
        /// Get the name, field of study, and the information relative 
        /// to the classe Member_of_school
        /// </summary>
        public void GetTeacherFile(string teacherID)
        {
            Faculty_member teacher = FindTeacher(teacherID);

            Console.WriteLine("Surname:" + teacher.Surname + " Name:" + teacher.Name
                       + "\n Fields of study: " + teacher.Subject
                       + "\n Age: " + teacher.Age + " Sexe: " + teacher.Sexe
                       + "\n email: " + teacher.Mail);

        }


        /// <summary>
        /// Get  the information relative to the classe Member_of_school
        ///  the number of absences and 
        /// a boolean saying if the student has payed everything.
        /// </summary>
        public void GetStudentFile(string studentID)
        {
            Student student = FindStudent(studentID);

            Console.WriteLine("Surname:" + student.Surname + " Name:" + student.Name
                        + "\n Age: " + student.Age + " Sexe: " + student.Sexe
                        + "\n email: " + student.Mail
                        + "\n Number of absence: " + NumberOfAbsence(student)
                        + "\n The student has payed everything: " + HasPayedEverything(student));


        }

        /// <summary>
        /// Displays all the student's payments
        /// </summary>
        public void ToStringStudentPayments(string student_id)
        {
            foreach(Payment payment in FindStudent(student_id).Payment_list)
            {
                Console.WriteLine("Payer's name : " + payment.Payer_name + "\nAmount : " + payment.Amount + "\nDate : " + payment.Date.ToString()); // add enum later
            }
        }
        /// <summary>
        /// Displays all the student's payments for a specific invoice
        /// </summary>
        public void ToStringStudentSpecificInvoice(string student_id,string invoice_title)
        {
            Invoice invoice = FindStudent(student_id).Invoice_list.Find(x => x.Title == invoice_title);
            foreach(Payment payment in invoice.Payments)
            {
                Console.WriteLine("Payer's name : " + payment.Payer_name + "\nAmount : " + payment.Amount + "\nDate : " + payment.Date.ToString()); // add enum later
            }
        }
        /// <summary>
        /// Displays all of the student's invoices
        /// </summary>
        public void GetStudentInvoice(string student_id)
        {
            foreach(Invoice invoice in FindStudent(student_id).Invoice_list)
            {
                Console.WriteLine("Title : " + invoice.Title + "\nAmount : " + invoice.Amount+"\nDeadline : "+invoice.Deadline.ToString());
            }
        }
        public bool HasPayedInvoice(string student_id, string invoice_title)
        {
            bool r = false;
            double c = 0;
            Invoice invoice = FindStudent(student_id).Invoice_list.Find(x => x.Title == invoice_title);
            foreach (Payment payment in invoice.Payments)
            {
                c += payment.Amount;
            }
            if (c >= invoice.Amount) // if the user can overpay 
            {
                r = true;
            }
            return r; // works but should be done inside the class with a what's left to pay
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
        public bool HasPayedEverything(Student student)
        {
            bool checker = true;
            foreach(Invoice invoiceStudent in student.Invoice_list)
            {
            }
            return checker;
        }
        #endregion

    }
}
