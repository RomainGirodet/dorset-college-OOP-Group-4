using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Course
    {
        public string topic; // matter studied in the course
        public string professor; // professor ensuring the course
        public string description; // description of the course 
        public List<Student> participant;

        public Course(string topic)
        {
            this.topic = topic;
        }
         
        public Course(string topic, string professor, string description)
        {
            this.topic = topic;
            this.professor = professor;
            this.description = description;
        }

        public Course(string topic, string professor, string description, List<Student> participant)
        {
            this.topic = topic;
            this.professor = professor;
            this.description = description;
            this.participant = participant;
        }
        
    }
}
