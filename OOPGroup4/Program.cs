using System;
using System.Collections.Generic;

namespace OOPGroup4
{

    // Corentin Chatin 23201
    // Alexis Gibert 22841
    // Pablo Acevedo Rincon 23169
    //Louis Bader 23197
    // Alexis Cerio 22829
    // Romain Girodet 23437
    class Program
    {
        static void Main(string[] args)
        {


           
            List<Student> listStudentPromoTest = new List<Student>();
            List<Faculty_member> listTeacherPromoTest = new List<Faculty_member>();
            List<string> ListClassSubjectTest = new List<string>();
            Promotion promotionTest = new Promotion(listStudentPromoTest, listTeacherPromoTest);
            Console.WriteLine("running");






            //Console.WriteLine("running creation of student ");
            //string[] tableau = new string[15];
            //string path = "D:/Documents/simueleve.csv";
            //string[] lines = System.IO.File.ReadAllLines(path);
            //int nbligne = lines.Length - 1;



            //for (int i = 1; i < nbligne; i++)
            //{
            //    string[] columns = lines[i].Split(';');


            //    string place = columns[0];
            //    string school_name = columns[1];
            //    string id = columns[2];
            //    string first_name = columns[3];
            //    string last_name = columns[4];
            //    string password = columns[5];
            //    int date_of_birth = Convert.ToInt32(columns[6]);
            //    string gender = columns[7];
            //    string mail = columns[8];
            //    promotionTest.listStudentPromo.Add(new Student(place, school_name, id, first_name, last_name, password, date_of_birth, gender, mail));
            //}
            //Console.ReadKey();
            //Console.WriteLine(" student affichage  ");
            //foreach (Student a in listStudentPromoTest)
            //{
            //    Console.WriteLine(a.First_name + "   " + a.Password);
            //}
            Console.ReadKey();
        }
    }
}
