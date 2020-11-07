
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    // Corentin Chatin 23201

    class Exam_detail
    {
        public SortedList<string, Evaluation> student_Evaluation { get; set; }
        public Exam_detail()
        {

        }
        public int Nb_Evaluation()
        {
            return 0;
        }
        public double Moy()
        {
            return 0;
        }
        public Evaluation Last_Exam()
        {
            return new Evaluation();
        }
        public double Moy_Mat(string matter)
        {
            return 0;
        }

    }
}

