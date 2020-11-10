using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Course
    {
        public string matter;
        public string professor;
        public string description;
        public Course(string matter, string professor, string description)
        {
            this.matter = matter;
            this.professor = professor;
            this.description = description;
        }
        public Course(string matter)
        {
            this.matter = matter;
        }
    }
}
