using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace OOPGroup4
{
    class Admin : Member_of_school
    {
        List<Student> listAdminStudentPromo = new List<Student>();
        List<Faculty_member> listAdminTeacherPromo = new List<Faculty_member>();
        List<string> listClassSubject = new List<string>();

        Promotion promoAdmin;

        public Admin(string place, string school_name, int number_of_student, string id, string name, string surname, string password,
            int age, string sexe, string mail, Promotion promoAdmin) : base(place, name, id, name, surname, password, age, sexe, mail)
        {

            this.promoAdmin = promoAdmin;
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
        public void CreateTimeTable(List<Student> studentList, List<Faculty_member> teacherList)
        {
            int startYear = 0;
            int startMonth = 0;
            int startDay = 0;
            int timer = 0;
            
            do
            {
                timer = 0;
                Console.WriteLine("Which year do you want to start the TimeTable");
                try
                {
                    startYear = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    timer--;
                }

                Console.WriteLine("Which month do you want to start the TimeTable");
                try
                {
                    startMonth = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    timer--;
                }
                Console.WriteLine("Which day do you want to start the TimeTable");
                try
                {
                    startDay = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    timer--;
                }
                try
                {
                    DateTime dateTest = new DateTime(startYear, startMonth, startDay);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");

                    timer--;
                }
                if(new DateTime(startYear,startMonth,startDay).DayOfWeek != DayOfWeek.Monday)
                {
                    Console.WriteLine("this is not the start of one week");
                    timer--;
                }
            } while (timer < 0);

            foreach (Student student in studentList)
            {
                student.Timetable.CreateTimetable(startYear, startMonth, startDay);
            }
            foreach (Faculty_member teacher in teacherList)
            {
                teacher.Timetable.CreateTimetable(startYear, startMonth, startDay);
            }
        }

        public void DisplayTimeTable(Student student)
        {
            int j = 0;
            int l = 0;
            int m = 0;
            int max = 0;
            int start = 0;
            for (int i = 0; i < student.Timetable.Date.Length; i++)
            {

                if (j == 6 || i == student.Timetable.Date.Length - 1)
                {

                    Console.WriteLine($"{student.Timetable.Date[i]}");
                    Console.Write(String.Format("{0,-20} ", student.Timetable.Date[0].DayOfWeek));
                    m = i % 7;
                    if (m == 0 && i != student.Timetable.Date.Length - 1)
                    {
                        m = 6;
                    }
                    for (l = 1; l < m + 1; l++)
                    {
                        Console.Write(String.Format("|  {0,-20} ", student.Timetable.Date[l].DayOfWeek));
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    for (l = 0; l < 16; l++)
                    {

                        Console.Write(String.Format("{0, -20} ", student.Timetable.courseTable[i - 6, l].Topic));
                        if (i == student.Timetable.Date.Length - 1)
                        {
                            start = i + 1;
                            max = student.Timetable.Date.Length - 1;
                        }
                        else
                        {
                            start = i - 5;
                            max = i;
                        }
                        for (m = start; m <= max; m++)
                        {
                            Console.Write(String.Format("|{0,-22} ", student.Timetable.courseTable[m, l].Topic));
                        }
                        Console.WriteLine("|");



                        Console.Write(String.Format("{0, -20} ", student.Timetable.courseTable[i - 6, l].professor));
                        for (m = start; m <= max; m++)
                        {
                            Console.Write(String.Format("|{0,-22} ", student.Timetable.courseTable[m, l].professor));
                        }
                        Console.WriteLine(String.Format("|{0,9} ", l + 7 + ":00"));



                        Console.Write(String.Format("{0,-20} ", student.Timetable.courseTable[i - 6, l].Description));
                        for (m = start; m <= max; m++)
                        {
                            Console.Write(String.Format("|{0,-22} ", student.Timetable.courseTable[m, l].Description));
                        }
                        Console.WriteLine("|");

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }

                    Console.WriteLine();
                    j = 0;
                }
                else
                {
                    Console.Write($"{student.Timetable.Date[i]}  |  ");
                    j++;
                }



            }

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
        public void JustifyAnAbsence(string student_id, int absNumber, string comment)
        {
            Student student = FindStudent(student_id);

            student.Absence_list[absNumber - 1].Active = false;
            student.Absence_list[absNumber - 1].Comments = comment;
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
        public string GetTeacherFile(string teacher_id)
        {
            string info = "";
            Faculty_member teacher = FindTeacher(teacher_id);

            info = ("Surname:" + teacher.Surname + " Name:" + teacher.Name
                       + "\n Fields of study: " + teacher.Subject
                       + "\n Age: " + teacher.Age + " Sexe: " + teacher.Sexe
                       + "\n email: " + teacher.Mail);
            return info;

        }


        /// <summary>
        /// Get  the information relative to the classe Member_of_school
        ///  the number of absences and 
        /// a boolean saying if the student has payed everything.
        /// </summary>
        public string GetStudentFile(string student_id)
        {
            Student student = FindStudent(student_id);
            string info = "";
            info = ("Surname:" + student.Surname + " Name:" + student.Name
                        + "\n Age: " + student.Age + " Sexe: " + student.Sexe
                        + "\n email: " + student.Mail
                        + "\n Number of absence: " + NumberOfAbsence(student)
                        + "\n The student has payed everything: " + HasPayedEverything(student_id));

            return info;
        }

        /// <summary>
        /// Displays all the student's payments
        /// </summary>
        public string ToStringStudentPayments(string student_id)
        {
            string info = "";
            foreach (Payment payment in FindStudent(student_id).Payment_list)
            {
                info += ("Payer's name : " + payment.Payer_name + "\nPayment method : " + payment.Payment_method + "\nAmount : " + payment.Amount + "\nDate : " + payment.Date.ToString());
            }
            return info;
        }
        /// <summary>
        /// Displays all the student's payments for a specific invoice
        /// </summary>
        public string ToStringStudentSpecificInvoice(string student_id,string invoice_title)
        {
            string info = "";
            Invoice invoice = FindStudent(student_id).Invoice_list.Find(x => x.Title == invoice_title);
            foreach (Payment payment in invoice.Payments)
            {
                info += ("Payer's name : " + payment.Payer_name + "\nPayment method : " + payment.Payment_method + "\nAmount : " + payment.Amount + "\nDate : " + payment.Date.ToString());
            }
            return info;
        }
        /// <summary>
        /// Displays all of the student's invoices
        /// </summary>
        public string GetStudentInvoice(string student_id)
        {
            string info = "";
            foreach (Invoice invoice in FindStudent(student_id).Invoice_list)
            {
                info += ("Title : " + invoice.Title + "\nAmount : " + invoice.Amount + "\nDeadline : " + invoice.Deadline.ToString());
            }
            return info;
        }
        public bool HasPayedInvoice(string student_id, string invoice_title)
        {
            bool r = false;
            Invoice invoice = FindStudent(student_id).Invoice_list.Find(x => x.Title == invoice_title);
            if(FindStudent(student_id).Invoice_list.Find(x => x.Title == invoice_title).Amount_left == 0)
            {
                r = true;
            }
            return r; 
        }
        public bool HasPayedEverything(string student_id)
        {
            bool r = true;
            foreach (Invoice invoice in FindStudent(student_id).Invoice_list)
            {
                if(invoice.Amount_left != 0)
                {
                    r = false;
                }
            }
            return r;
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
        public string GetStudentAbsenceHistorical(string student_id)
        {
            Student student = FindStudent(student_id);
            string info = "";
            for (int i = 0; i < student.Absence_list.Count; i++)
            {
                if (student.Absence_list[i].Active == true)
                {
                    info += ((i + 1) + ") Date: " + student.Absence_list[i].Date + " | Class: " + student.Absence_list[i].Classes + " | Timeslot: " + student.Absence_list[i].Timeslot
                                 + "\n Duration: " + student.Absence_list[i].Time + " | Comments: " + student.Absence_list[i].Comments);
                }
            }
            return info;
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
        
        #endregion

    }
}
