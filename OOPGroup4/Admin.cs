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

        public Admin(string id, string first_name, string last_name, string password,
            string date_of_birth, string gender, string mail, Promotion promoAdmin) : base ( id, first_name, last_name, password, date_of_birth, gender, mail)
        {

            this.promoAdmin = promoAdmin;
        }


        #region Subject_fonction
        // Créer une nouvellle matière
        //public void NewSubject(string nameOfTheSubject)
        //{
        //    bool alreadyExist = false;

        //    foreach (string subject in promoAdmin.ListPromoSubject)
        //    {
        //        if (subject == nameOfTheSubject)
        //        {
        //            alreadyExist = true;
        //        }
        //    }
        //    if (alreadyExist == true)
        //    {
        //        Console.WriteLine("Subject already Exist");
        //    }
        //    else
        //    {
        //        promoAdmin.ListPromoSubject.Add(nameOfTheSubject);
        //    }
        //} 
        //Changer le nom d'une matière
        //public void ChangeSubject(string newName, string OldName)
        //{
        //    foreach (string subject in promoAdmin.ListPromoSubject)
        //    {
        //        if (subject == OldName)
        //        {
        //            subject = newName;
        //        }
        //    }
        //    for (int i = 0; i < promoAdmin.ListPromoSubject.Count; i++)
        //    {
        //        if (promoAdmin.ListPromoSubject[i] == OldName)
        //        {
        //            promoAdmin.ListPromoSubject[i] = newName;
        //        }
        //    }

        //}
        //public void deleteSubject(string nameOfTheSubject)
        //{
            //for (int i = 0; i < promoAdmin.ListPromoSubject.Count; i++)
            //{
            //    if (promoAdmin.ListPromoSubject[i] == nameOfTheSubject)
            //    {
            //        promoAdmin.ListPromoSubject.RemoveAt(i);
            //    }
            //}
        //    foreach (string subject in promoAdmin.ListPromoSubject)
        //    {
        //        if (subject == nameOfTheSubject)
        //        {
        //            promoAdmin.ListPromoSubject.Remove(subject);
        //        }
        //    }
        //}
        #endregion
        #region TimeTable_function
        /// <summary>
        /// Create a new timeTable.
        /// </summary>
        /// <param first_name="listClasse"></param>
        /// <param first_name="nomClasse"></param>
        /// <param first_name="listSubject"></param>
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
        /// <param first_name="listClasse"></param>
        /// <param first_name="nomClasse"></param>
        /// <param first_name="listSubject"></param>
        public void Add_CourseToTimetable(Student student)
        {
            DisplayTimeTable(student);
            int timer;
            int starthour = 0;
            int nbhour = 0;
            DateTime day = new DateTime(2000, 01, 01);
            TimeSpan interval;

            do
            {
                timer = 0;
                Console.WriteLine("Select the day of the course like 01/18/2020");
                string date = Console.ReadLine().Replace("/", String.Empty);
                Console.WriteLine(date);
                try
                {
                    day = new DateTime(Convert.ToInt32(date.Substring(4)), Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(2, 2)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");
                    timer--;
                }

                Console.WriteLine("Select the hour begin of the course. Write only the hour without minutes as 8 for 8:00");
                try
                {
                    starthour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                if (starthour < 7 || starthour > 22)
                {
                    timer--;
                    Console.WriteLine("This hour is not in the TimeTable");
                }
                interval = day - student.Timetable.Date[0];
                if ((int)interval.TotalDays < 0 || (int)interval.TotalDays > student.Timetable.CourseTable.GetLength(0))
                {
                    timer--;
                    Console.WriteLine("This Date is out of the TimeTable");
                }
                else if (student.Timetable.CourseTable[(int)interval.TotalDays, starthour - 7] != new Course("", "", ""))
                {
                    timer--;
                    Console.WriteLine("This slot is already used");
                }
                Console.WriteLine("Select the duration of the course with only the number of hour");
                try
                {
                    nbhour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
            } while (timer < 0);

            string topic;
            string professor;
            string description;
            Faculty_member teacher = new Faculty_member("","","","","","","","",new List<Student>(), promoAdmin);
            do
            {
                Console.WriteLine("Select and write the topic of the course");
                foreach(string subject in promoAdmin.ListPromoMandatorySubject)
                {
                    Console.WriteLine(subject);
                }
                topic = Console.ReadLine();
                timer = -1;
                foreach (string subject in promoAdmin.ListPromoMandatorySubject)
                {
                    if(topic == subject)
                    {
                        timer = 0;
                    }
                }
                Console.WriteLine("Select and write the professor of the course");
                foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                {
                    Console.WriteLine(teacherName.TeacherName);
                }
                professor = Console.ReadLine();
                timer = -1;
                foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                {
                    if (professor == teacherName.TeacherName)
                    {
                        timer = 0;
                        teacher = teacherName;
                    }
                }
                Console.WriteLine("Write a description of the course if not press enter");
                description = Console.ReadLine();
            } while (timer < 0);

            for(int i = starthour - 7; i < starthour - 7 + nbhour; i++)
            {
                student.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course(topic, professor, description, student);
                if (teacher.Timetable.CourseTable[(int)interval.TotalDays, i] == new Course("","",""))
                {
                    teacher.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course(topic, professor, description);
                }
                    
            }


            string answer;
            do
            {
                Console.WriteLine("If you want to repeat it each week write yes, if not write no");
                answer = Console.ReadLine();
                if(answer != "yes" && answer != "no")
                {
                    timer--;
                }
            } while (timer < 0);
            
            if(answer == "yes")
            {
                for(int j = (int)interval.TotalDays; j < student.Timetable.CourseTable.GetLength(0); j = +7)
                {
                    for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
                    {
                        if(student.Timetable.CourseTable[j, i] == new Course("", "", ""))
                        {
                            student.Timetable.CourseTable[j, i] = new Course(topic, professor, description);
                        }
                        
                    }
                }
            }
        }
        public void DeleteCourseFromTimetable(Student student)
        {
            DisplayTimeTable(student);
            int timer;
            int starthour = 0;
            int nbhour = 0;
            DateTime day = new DateTime(2000, 01, 01);
            TimeSpan interval;
            do
            {
                timer = 0;
                Console.WriteLine("Select the day of the course like 01/18/2020");
                string date = Console.ReadLine().Replace("/", String.Empty);
                Console.WriteLine(date);
                try
                {
                    day = new DateTime(Convert.ToInt32(date.Substring(4)), Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(2, 2)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");
                    timer--;
                }

                Console.WriteLine("Select the hour begin of the course. Write only the hour without minutes as 8 for 8:00");
                try
                {
                    starthour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                if (starthour < 7 || starthour > 22)
                {
                    timer--;
                    Console.WriteLine("This hour is not in the TimeTable");
                }
                interval = day - student.Timetable.Date[0];
                if ((int)interval.TotalDays < 0 || (int)interval.TotalDays > student.Timetable.CourseTable.GetLength(0))
                {
                    timer--;
                    Console.WriteLine("This Date is out of the TimeTable");
                }
                else if (student.Timetable.CourseTable[(int)interval.TotalDays, starthour - 7] == new Course("", "", ""))
                {
                    timer--;
                    Console.WriteLine("This slot is already empty");
                }
                Console.WriteLine("Select the duration of the course with only the number of hour");
                try
                {
                    nbhour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
            } while (timer < 0);
            Faculty_member teacher = new Faculty_member("", "", "", "", "", "", "", "", new List<Student>(), promoAdmin);



            for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
            {
                foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                {
                    if (student.Timetable.CourseTable[(int)interval.TotalDays, i].Professor == teacherName.TeacherName)
                    {
                        teacher = teacherName;
                    }
                }
                student.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course("","","");
                if (teacher.Timetable.CourseTable[(int)interval.TotalDays, i] != new Course("", "", ""))
                {
                    teacher.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course("","","");
                }
            }
            string answer;
            do
            {
                Console.WriteLine("If you want to repeat it each week write yes, if not write no");
                answer = Console.ReadLine();
                if (answer != "yes" && answer != "no")
                {
                    timer--;
                }
            } while (timer < 0);

            if (answer == "yes")
            {
                for (int j = (int)interval.TotalDays; j < student.Timetable.CourseTable.GetLength(0); j = +7)
                {
                    for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
                    {
                        student.Timetable.CourseTable[j, i] = new Course("","","");
                        if (teacher.Timetable.CourseTable[(int)interval.TotalDays, i] != new Course("", "", ""))
                        {
                            teacher.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course("", "", "");
                        }
                    }
                }
            }
        }
        public void Move_CourseFromTimetable(Student student)
        {
            DisplayTimeTable(student);
            int timer;
            int starthour = 0;
            int nbhour = 0;
            DateTime day = new DateTime(2000, 01, 01);
            TimeSpan interval;
            do
            {
                timer = 0;
                Console.WriteLine("Select the day of the course to move like 01/18/2020");
                string date = Console.ReadLine().Replace("/", String.Empty);
                Console.WriteLine(date);
                try
                {
                    day = new DateTime(Convert.ToInt32(date.Substring(4)), Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(2, 2)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");
                    timer--;
                }

                Console.WriteLine("Select the hour begin of the course to move. Write only the hour without minutes as 8 for 8:00");
                try
                {
                    starthour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                if (starthour < 7 || starthour > 22)
                {
                    timer--;
                    Console.WriteLine("This hour is not in the TimeTable");
                }
                interval = day - student.Timetable.Date[0];
                if ((int)interval.TotalDays < 0 || (int)interval.TotalDays > student.Timetable.CourseTable.GetLength(0))
                {
                    timer--;
                    Console.WriteLine("This Date is out of the TimeTable");
                }
                else if (student.Timetable.CourseTable[(int)interval.TotalDays, starthour - 7] == new Course("", "", ""))
                {
                    timer--;
                    Console.WriteLine("This slot is empty");
                }
                Console.WriteLine("Select the duration of the course with only the number of hour");
                try
                {
                    nbhour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
            } while (timer < 0);

            int starthour2 = 0;
            int nbhour2 = 0;
            DateTime day2 = new DateTime(2000, 01, 01);
            TimeSpan interval2;

            do
            {
                timer = 0;
                Console.WriteLine("Select the day of the course to move like 01/18/2020");
                string date = Console.ReadLine().Replace("/", String.Empty);
                Console.WriteLine(date);
                try
                {
                    day2 = new DateTime(Convert.ToInt32(date.Substring(4)), Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(2, 2)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");
                    timer--;
                }

                Console.WriteLine("Select the hour begin of the course to move. Write only the hour without minutes as 8 for 8:00");
                try
                {
                    starthour2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                if (starthour2 < 7 || starthour2 > 22)
                {
                    timer--;
                    Console.WriteLine("This hour is not in the TimeTable");
                }
                interval2 = day - student.Timetable.Date[0];
                if ((int)interval2.TotalDays < 0 || (int)interval2.TotalDays > student.Timetable.CourseTable.GetLength(0))
                {
                    timer--;
                    Console.WriteLine("This Date is out of the TimeTable");
                }
                else if (student.Timetable.CourseTable[(int)interval2.TotalDays, starthour2 - 7] != new Course("", "", ""))
                {
                    timer--;
                    Console.WriteLine("This slot is already used");
                }
                Console.WriteLine("Select the duration of the course with only the number of hour");
                try
                {
                    nbhour2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
            } while (timer < 0);
            Faculty_member teacher = new Faculty_member("", "", "", "", "", "", "", "", new List<Student>(), promoAdmin); string topic = "";
            string professor = "";
            string description = "";
            for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
            {
                topic = student.Timetable.CourseTable[(int)interval.TotalDays, i].Topic;
                professor = student.Timetable.CourseTable[(int)interval.TotalDays, i].Professor;
                description = student.Timetable.CourseTable[(int)interval.TotalDays, i].Description;

                student.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course("","","");
            }
            
            for (int i = starthour2 - 7; i < starthour2 - 7 + nbhour2; i++)
            {
                foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                {
                    if (student.Timetable.CourseTable[(int)interval.TotalDays, i].Professor == teacherName.TeacherName)
                    {
                        teacher = teacherName;
                    }
                }
                student.Timetable.CourseTable[(int)interval2.TotalDays, i] = new Course(topic, professor, description, student);
                if (teacher.Timetable.CourseTable[(int)interval2.TotalDays, i] == new Course("", "", ""))
                {
                    teacher.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course(topic, professor, description);
                }
            }
        }
        public void Modify_Topic_And_Professor_CourseFromTimetable(Student student)
        {
            int timer;
            int starthour = 0;
            int nbhour = 0;
            DateTime day = new DateTime(2000, 01, 01);
            TimeSpan interval;
            do
            {
                timer = 0;
                Console.WriteLine("Select the day of the course like 01/18/2020");
                string date = Console.ReadLine().Replace("/", String.Empty);
                Console.WriteLine(date);
                try
                {
                    day = new DateTime(Convert.ToInt32(date.Substring(4)), Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(2, 2)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");
                    timer--;
                }

                Console.WriteLine("Select the hour begin of the course. Write only the hour without minutes as 8 for 8:00");
                try
                {
                    starthour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                if (starthour < 7 || starthour > 22)
                {
                    timer--;
                    Console.WriteLine("This hour is not in the TimeTable");
                }
                interval = day - student.Timetable.Date[0];
                if ((int)interval.TotalDays < 0 || (int)interval.TotalDays > student.Timetable.CourseTable.GetLength(0))
                {
                    timer--;
                    Console.WriteLine("This Date is out of the TimeTable");
                }
                else if (student.Timetable.CourseTable[(int)interval.TotalDays, starthour - 7] != new Course("", "", ""))
                {
                    timer--;
                    Console.WriteLine("This slot is already used");
                }
                Console.WriteLine("Select the duration of the course with only the number of hour");
                try
                {
                    nbhour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                
            } while (timer < 0);

            string topic;
            string professor;

            Faculty_member teacher = new Faculty_member("", "", "", "", "", "", "", "", new List<Student>(), promoAdmin);
            Faculty_member oldTeacher = new Faculty_member("", "", "", "", "", "", "", "", new List<Student>(), promoAdmin);
            do
            {
                Console.WriteLine("Select and write the new topic of the course");
                foreach (string subject in promoAdmin.ListPromoMandatorySubject)
                {
                    Console.WriteLine(subject);
                }
                topic = Console.ReadLine();
                timer = -1;
                foreach (string subject in promoAdmin.ListPromoMandatorySubject)
                {
                    if (topic == subject)
                    {
                        timer = 0;
                    }
                }
                Console.WriteLine("Select and write the new professor of the course");
                foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                {
                    Console.WriteLine(teacherName.TeacherName);
                }
                professor = Console.ReadLine();
                timer = -1;
                foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                {
                    if (professor == teacherName.TeacherName)
                    {
                        timer = 0;
                        teacher = teacherName;
                    }

                }
            } while (timer < 0);

            for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
            {

                student.Timetable.CourseTable[(int)interval.TotalDays, i].Topic = topic;
                student.Timetable.CourseTable[(int)interval.TotalDays, i].Professor = professor;
                if (teacher.Timetable.CourseTable[(int)interval.TotalDays, i] == new Course("", "", ""))
                {
                    teacher.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course(topic, professor, student.Timetable.CourseTable[(int)interval.TotalDays, i].Description);
                }
                
            }

            string answer;
            do
            {
                Console.WriteLine("Do this action on all participant? yes or no");
                answer = Console.ReadLine();
                timer = 0;
                if (answer != "yes" && answer != "no")
                {
                    timer--;
                }

            } while (timer < 0);
            if(answer == "yes")
            {
                for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
                {
                    foreach (Faculty_member teacherName in promoAdmin.ListTeacherPromo)
                    {
                        if (student.Timetable.CourseTable[(int)interval.TotalDays, i].Professor == teacherName.TeacherName)
                        {
                            oldTeacher = teacherName;
                        }

                    }
                    oldTeacher.Timetable.CourseTable[(int)interval.TotalDays, i] = new Course("", "", "");

                    foreach (Student students in student.Timetable.CourseTable[(int)interval.TotalDays, i].Participant)
                    {
                        students.Timetable.CourseTable[(int)interval.TotalDays, i].Topic = topic;
                        students.Timetable.CourseTable[(int)interval.TotalDays, i].Professor = professor;
                        
                    }   
                }
            }


        }
        public void Modify_Description_CourseFromTimeTable(Student student)
        {
            int timer;
            int starthour = 0;
            int nbhour = 0;
            DateTime day = new DateTime(2000, 01, 01);
            TimeSpan interval;
            do
            {
                timer = 0;
                Console.WriteLine("Select the day of the course like 01/18/2020");
                string date = Console.ReadLine().Replace("/", String.Empty);
                Console.WriteLine(date);
                try
                {
                    day = new DateTime(Convert.ToInt32(date.Substring(4)), Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(2, 2)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date impossible");
                    timer--;
                }

                Console.WriteLine("Select the hour begin of the course. Write only the hour without minutes as 8 for 8:00");
                try
                {
                    starthour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }
                if (starthour < 7 || starthour > 22)
                {
                    timer--;
                    Console.WriteLine("This hour is not in the TimeTable");
                }
                interval = day - student.Timetable.Date[0];
                if ((int)interval.TotalDays < 0 || (int)interval.TotalDays > student.Timetable.CourseTable.GetLength(0))
                {
                    timer--;
                    Console.WriteLine("This Date is out of the TimeTable");
                }
                else if (student.Timetable.CourseTable[(int)interval.TotalDays, starthour - 7] != new Course("", "", ""))
                {
                    timer--;
                    Console.WriteLine("This slot is already used");
                }
                Console.WriteLine("Select the duration of the course with only the number of hour");
                try
                {
                    nbhour = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hour impossible");
                    timer--;
                }

            } while (timer < 0);

            Faculty_member teacher = new Faculty_member("", "", "", "", "", "", "", "", new List<Student>(), promoAdmin);
            Console.WriteLine("Write the new description");
            string description = Console.ReadLine();
            for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
            {
                student.Timetable.CourseTable[(int)interval.TotalDays, i].Description = description;
            }


            string answer;
            do
            {
                Console.WriteLine("Do this action on all participant? yes or no");
                answer = Console.ReadLine();
                timer = 0;
                if (answer != "yes" && answer != "no")
                {
                    timer--;
                }

            } while (timer < 0);
            if (answer == "yes")
            {
                for (int i = starthour - 7; i < starthour - 7 + nbhour; i++)
                {
                    foreach (Student students in student.Timetable.CourseTable[(int)interval.TotalDays, i].Participant)
                    {
                        students.Timetable.CourseTable[(int)interval.TotalDays, i].Description = description;
                    }

                }
            }

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
        /// <param first_name="nameStudent"></param>
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
        /// <param first_name="id"></param>
        public Student FindStudent(string id)
        {
            return promoAdmin.ListStudentPromo.Find(x => x.Id == id);
        }
        public Faculty_member FindTeacher(string id)
        {
            return promoAdmin.ListTeacherPromo.Find(x => x.Id == id);
        }
        /// <summary>
        /// Get the first_name, field of study, and the information relative 
        /// to the classe Member_of_school
        /// </summary>
        public string GetTeacherFile(string teacher_id)
        {
            string info = "";
            Faculty_member teacher = FindTeacher(teacher_id);

            info = ("Last_name:" + teacher.Last_name + " First_name:" + teacher.First_name
                       + "\n Fields of study: " + teacher.Subject
                       + "\n Date_of_birth: " + teacher.Date_of_birth + " Gender: " + teacher.Gender
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
            info = ("Last_name:" + student.Last_name + " First_name:" + student.First_name
                        + "\n Date_of_birth: " + student.Date_of_birth + " Gender: " + student.Gender
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
                info += ("Payer's first_name : " + payment.Payer_name + "\nPayment method : " + payment.Payment_method + "\nAmount : " + payment.Amount + "\nDate : " + payment.Date.ToString());
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
                info += ("Payer's first_name : " + payment.Payer_name + "\nPayment method : " + payment.Payment_method + "\nAmount : " + payment.Amount + "\nDate : " + payment.Date.ToString());
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
