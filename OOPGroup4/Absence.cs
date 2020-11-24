using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Absence
    {
        // Champs :

        public string classes; // First_name of classes.
        public int date; // Date of absence.
        public int timeslot; // Time slot of absence.
        public int time; // Duration of absence in hours.
        public bool active = true; // allows to know if the absence is effective or not (true if it is, false if not).
        public string comments; // Optional


        // Constructeur :

        public Absence(string classes, int date, int timeslot, int time) // Don't need active because it's true by default, nether comments because it's optional.
        {
            this.classes = classes;
            this.date = date;
            this.timeslot = timeslot;
            this.time = time;
        }


        // Propriétés :

        public string Classes
        {
            get
            {
                return this.classes;
            }

            set
            {
                this.classes = value;
            }
        }

        public int Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public int Timeslot
        {
            get
            {
                return this.timeslot;
            }

            set
            {
                this.timeslot = value;
            }
        }

        public int Time
        {
            get
            {
                return this.time;
            }

            set
            {
                this.time = value;
            }
        }

        public bool Active
        {
            get
            {
                return this.active;
            }

            set
            {
                this.active = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                this.comments = value;
            }
        }
    }
}
