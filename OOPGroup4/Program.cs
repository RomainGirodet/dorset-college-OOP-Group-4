﻿using System;
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


            Console.WriteLine("running");
            List<Student> listStudentPromoTest = new List<Student>();
            List<Faculty_member> listTeacherPromoTest = new List<Faculty_member>();
            List<string> ListClassSubjectTest = new List<string>();
            Promotion promotionTest = new Promotion(listStudentPromoTest, listTeacherPromoTest);







            Console.WriteLine("running creation of student ");
            string[] tableau = new string[15];
            string path = "D:/Documents/simueleve.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int nbligne = lines.Length - 1;



            for (int i = 1; i < nbligne; i++)
            {
                string[] columns = lines[i].Split(';');


                string place = columns[0];
                string school_name = columns[1];
                string id = columns[2];
                string name = columns[3];
                string surname = columns[4];
                string password = columns[5];
                int age = Convert.ToInt32(columns[6]);
                string sexe = columns[7];
                string mail = columns[8];
                promotionTest.listStudentPromo.Add(new Student(place, school_name, id, name, surname, password, age, sexe, mail));
            }
            Console.ReadKey();
            Console.WriteLine(" student affichage  ");
            foreach (Student a in listStudentPromoTest)
            {
                Console.WriteLine(a.Name + "   " + a.Password);
            }
            Console.ReadKey();
        }
    }
}
