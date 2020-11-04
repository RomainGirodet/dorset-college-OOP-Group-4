using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Promotion
    {
        List<Student> listStudentPromo;
        List<Faculty_member> listTeacherPromo;
        List<Class> listClassPromo;
        //List<Subject> ListClassSubject;

        public Promotion(List<Student> listStudentPromo,List<Faculty_member> listTeacherPromo,List<Class> listClassPromo)
        {
            this.listClassPromo = listClassPromo;
            this.listStudentPromo = listStudentPromo;
            this.listTeacherPromo = listTeacherPromo;

           // this.ListClassSubject = new List<Subject>;
        }
    }
}
