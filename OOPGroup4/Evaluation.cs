using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Evaluation
    {
         public  string date;
        public  string matter;
        public string teacher;
        public int grade;
        public string type;
        //coef
        public Evaluation(int grade, string type, string matter)
        {
            this.matter = matter;
            this.type = type;
            this.grade = grade;
        }
    }
}
