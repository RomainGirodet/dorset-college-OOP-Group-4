using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Absence
    {
        // Test branche push
        //test 2.0

        // Champs :

        public string classes; // Name of classes.
        public int date; // Date of absence.
        public int timeslot; // Time slot of absence.
        public int time; // Duration of absence in hours.
        public int active = 1; // allows to know if the absence is effective or not (1 if it is, 0 if not).
        public string comments; // Optional


        // Constructeur :

        public Absence(string classes, int date, int timeslot, int time) // Don't need active because it's 1 by default, nether comments because it's optional.
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

        public int Active
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
