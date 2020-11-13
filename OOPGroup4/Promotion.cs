using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Promotion
    {
       private List<Student> listStudentPromo;
        List<Faculty_member> listTeacherPromo;
        
        List<string> ListClassSubject;

        public Promotion(List<Student> listStudentPromo,List<Faculty_member> listTeacherPromo)
        {
            
            this.listStudentPromo = listStudentPromo;
            this.listTeacherPromo = listTeacherPromo;

           
        }

        public List<Student> ListStudentPromo()
        {
            return  listStudentPromo;
        }

    }
}
