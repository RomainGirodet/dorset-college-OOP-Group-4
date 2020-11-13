using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Promotion
    {
        List<Student> listStudentPromo;
        List<Faculty_member> listTeacherPromo;

        List<string> listPromoSubject;

        public Promotion(List<Student> listStudentPromo, List<Faculty_member> listTeacherPromo)
        {

            this.listStudentPromo = listStudentPromo;
            this.listTeacherPromo = listTeacherPromo;


        }
        public Promotion(List<Student> listStudentPromo, List<Faculty_member> listTeacherPromo, List<string> listPromoSubject)
        {

            this.listStudentPromo = listStudentPromo;
            this.listTeacherPromo = listTeacherPromo;
            this.listPromoSubject = listPromoSubject;

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
        public List<string> ListPromoSubject
        {
            get { return this.listPromoSubject; }
            set { this.listPromoSubject = value; }



        }
    }
}
