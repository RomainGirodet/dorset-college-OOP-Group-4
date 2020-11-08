
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    // Corentin Chatin 23201

    class Exam_detail
    {
        public List<Evaluation> student_Evaluation { get; set; }
        public Exam_detail()
        {

        }
        public int Nb_Evaluation()
        {
            return student_Evaluation.Count ;
        }
        public double Moy()
        {
            // return classMoy;
            return 0;
        }
        public Evaluation Last_Exam()
        {
            return student_Evaluation[student_Evaluation.Count -1 ];
        }
        public double Moy_Mat(string matter)
        {
            double sum = 0 ;
            double coef =0; 
            foreach (Evaluation eval in student_Evaluation ){
                if (eval.matter == matter){
            sum += eval.grade*eval.coef;
            coef += eval.coef ;
                }
            }
      
            if (coef!= 0){  
                double moy = ( sum/ coef ) ;
                return moy;}
            else {return -1 ;}
        }

    }
}

