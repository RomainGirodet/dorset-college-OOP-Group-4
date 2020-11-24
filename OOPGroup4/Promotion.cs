using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Promotion
    {
        public List<Student> listStudentPromo;
        List<Faculty_member> listTeacherPromo;

        List<string> listPromoMandatorySubject= new List<string>();
        List<string> listPromoOptionalSubject=new List<string>();

        public Promotion(List<Student> listStudentPromo, List<Faculty_member> listTeacherPromo)
        {

            this.listStudentPromo = listStudentPromo;
            this.listTeacherPromo = listTeacherPromo;

            listPromoMandatorySubject.Add("Fluid Mechanics");
            listPromoMandatorySubject.Add("Data Structure & Algorithm");
            listPromoMandatorySubject.Add("Numerical Analysis ");
            listPromoMandatorySubject.Add("Statistical Inference");
            listPromoMandatorySubject.Add("Object-Oriented Programming");

            listPromoOptionalSubject.Add("Napoleon's History");
            listPromoOptionalSubject.Add("Sewing");
            listPromoOptionalSubject.Add("HTML & CSS");
            listPromoOptionalSubject.Add("Philosophy");
            listPromoOptionalSubject.Add("SolidWorks");
            listPromoOptionalSubject.Add("Rhetoric");
            listPromoOptionalSubject.Add("Cooking");
            listPromoOptionalSubject.Add("Military preparation");
           
                



        }
        //public Promotion(List<Student> listStudentPromo, List<Faculty_member> listTeacherPromo, List<string> listPromoSubject)
        //{

        //    this.listStudentPromo = listStudentPromo;
        //    this.listTeacherPromo = listTeacherPromo;
        //    this.listPromoSubject = listPromoSubject;

        //}
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
        //public List<string> ListPromoSubject
        //{
        //    get { return this.listPromoSubject; }
        //    set { this.listPromoSubject = value; }


        //}
    }
}
