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
            //test_Push-Romain_Girodet
            //test fusion 1
            //test faculty_member_2

            List<Student> listStudentPromoTest=new List<Student>();
            List<Faculty_member> listTeacherPromoTest=new List<Faculty_member>();
            List<string> ListClassSubjectTest=new List<string>();

            Promotion promotionTest = new Promotion(listStudentPromoTest, listTeacherPromoTest);

            

            Console.WriteLine("running");
            Console.ReadKey();
            
        }
    }
}
