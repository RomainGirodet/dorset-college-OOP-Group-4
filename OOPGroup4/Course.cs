using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Course
    {
        public string matter; // matter studied in the course
        public string professor; // professor ensuring the course
        public string description; // description of the course 

        public Course(string matter)
        {
            this.matter = matter;
        }

        public Course(string matter, string professor, string description)
        {
            this.matter = matter;
            this.professor = professor;
            this.description = description;
        }
        
    }
}
