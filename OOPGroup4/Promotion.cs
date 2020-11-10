using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Promotion
    {
        List<Student> listStudentPromo;
        List<Faculty_member> listTeacherPromo;

        List<string> ListClassSubject = new List<string>();

        public Promotion(List<Student> listStudentPromo,List<Faculty_member> listTeacherPromo)
        {
            
            this.listStudentPromo = listStudentPromo;
            this.listTeacherPromo = listTeacherPromo;

           
        }
        public List<Faculty_member> ListTeacherPromo
        {
            get { return this.listTeacherPromo; }
            set { this.listTeacherPromo = value; }
        }
        public List<Student> ListStudentPromo
        {
            get { return this.listStudentPromo; }
            set { this.listStudentPromo = value; }
        }

    }

}
