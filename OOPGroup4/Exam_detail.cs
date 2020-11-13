using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            return student_Evaluation.Count;
        }
        public double MoyPromo(int id, Promotion a )
        {
            List<Student> studentPromo = a.ListStudentPromo();
            double total =0;
            int numberOfStudent =0;
            foreach (Student student in studentPromo)
            {
               List<Evaluation> studentlist = student.StudentEvaluation();

                foreach(Evaluation eval in studentlist)
                {
                    if (eval.idEval == id)
                    {
                        total += eval.grade;
                        numberOfStudent += 1;
                    }
                }
            }      
            if (numberOfStudent!= 0)
            {
                return (total / numberOfStudent);
            }
            else
            {
                Console.WriteLine($"no one has done this evaluation : {id}");
                return -1;
            }           
        }
        public Evaluation Last_Exam()
        {
            return student_Evaluation[student_Evaluation.Count - 1];
        }
        public double Moy_Mat(string matter)
        {
            double sum = 0;
            double coef = 0;
            foreach (Evaluation eval in student_Evaluation)
            {
                if (eval.matter == matter)
                {
                    sum += eval.grade * eval.coef;
                    coef += eval.coef;
                }
            }

            if (coef != 0)
            {
                double moy = (sum / coef);
                return moy;
            }
            else
            {
                Console.Write("there is still no evaluation in matter ");
                return -1;
            }
        }
        public string ExamDetail()
        {
            string info=($"nb evaluation : {Nb_Evaluation()} ");
            

            return info;
        }
    } 
}
