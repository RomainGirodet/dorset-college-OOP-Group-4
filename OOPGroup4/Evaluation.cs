using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Evaluation
    {
        public int idEval;
        public string date;
        public string matter;
        public string teacher;
        public  double grade ;
        public  string type;
        public int coef ;


        public Evaluation(int idEval, string matter, double grade)
        {
            this.idEval = idEval;
            this.matter = matter;
            this.grade = grade;
        }
    }
}
