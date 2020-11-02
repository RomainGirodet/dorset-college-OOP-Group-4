using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGroup4
{
    class Timetable
    {
        public Subject[,] Calendar; //Matrix representing the Timetable on 1 year

        /// <summary>
        /// Function which creates a new Timetable for a student 
        /// </summary>
        public void CreateTimetable()
        {
            Calendar = new Subject[365, 365];

        }

        /// <summary>
        /// Function Which displays the Timetable
        /// </summary>
        public void DisplayTimetable()
        {

        }

        /// <summary>
        /// Function which adds a Subject in the Timetable
        /// </summary>
        public void AddSubject()
        {

        }

        /// <summary>
        /// Function which removes a Subject from the Timetable
        /// </summary>
        public void RemoveSubject()
        {

        }
    }
}
