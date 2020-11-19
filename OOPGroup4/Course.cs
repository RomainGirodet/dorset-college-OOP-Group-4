using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Course
    {
        public string topic; // matter studied in the course
        public Faculty_member professor; // professor ensuring the course
        public string description; // description of the course 
        public List<Student> participant;

        public Course(string topic)
        {
            this.topic = topic;
        }
         
        public Course(string topic, Faculty_member professor, string description)
        {
            this.topic = topic;
            this.professor = professor;
            this.description = description;
        }

        public Course(string topic, Faculty_member professor, string description, Student student)
        {
            this.topic = topic;
            this.professor = professor;
            this.description = description;
            participant.Add(student);
        }
        
        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public Faculty_member Professor
        {
            get { return professor; }
            set { professor = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<Student> Participant
        {
            get { return participant; }
            
        }
    }
}
