using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OOPGroup4
{
    class Timetable
    {
        public Course[,] courseTable; //Matrix representing the Timetable on 1 year
        public DateTime[] date; // Array representing all the days used in Timetable
          
        /// <summary>
        /// Function which creates a new Timetable for a person 
        /// </summary>
        public void CreateTimetable(int startYear, int startMonth, int startDay)
        {
            #region Intilization of a matrix representing TimeTable

            Calendar calendarBasics = CultureInfo.InvariantCulture.Calendar;
            int daysInYear = calendarBasics.GetDaysInYear(startYear+1); //researched the number of days in year2
            courseTable = new Course[daysInYear, 16]; // timeTable initialization

            #endregion

            #region Holiday dates fixed each year

            DateTime firstNovember = new DateTime(startYear, 11, 1); 
            DateTime armistice = new DateTime(startYear, 11, 11);
            DateTime christmas = new DateTime(startYear, 12, 25);
            DateTime newYearsDay = new DateTime(startYear+1, 1, 1);
            DateTime laborDay = new DateTime(startYear+1, 5, 1);
            DateTime secondArmistice = new DateTime(startYear+1, 5, 8);
            DateTime nationalFest = new DateTime(startYear+1, 7, 14);
            DateTime assomption = new DateTime(startYear+1, 8, 15);

            #endregion 

            #region Calculation of Easter Date

            // Using of the Algorithm of Butcher-Meeus
            int n = (startYear+1) % 19;
            int c = (startYear+1) / 100;
            int u = (startYear+1) % 100;
            int s = c / 4;
            int t = c % 4;
            int p = (c + 8) / 25;
            int q = (c - p + 1) / 3;
            int e = (19*n + c - s - q + 15) % 30;
            int b = u / 4;
            int d = u % 4;
            int l = (2 * t + 2 * b - e - d + 32) % 7;
            int h = (n + 11*e + 22*l) / 451;
            int m = (e + l - 7 * h + 114) / 31;
            int j = (e + l - 7*h + 114) % 31;
            DateTime easter = new DateTime(startYear+1, m, j + 1);
            // this two dates are in function of the easter day
            DateTime ascension = easter.AddDays(40);
            DateTime pentecost = easter.AddDays(49);

            #endregion

            #region initilization of a array representing all the date in the Timetable

            date = new DateTime[daysInYear];
            date[0] = new DateTime(startYear, startMonth, startDay);
            for (int k = 0; k < courseTable.GetLength(1); k++)
            {
                courseTable[0, k] = new Course("", "", "");
            }
            for (int i = 1; i < daysInYear; i++)
            {
                date[i] = date[0].AddDays(i);
                for (int k = 0; k < courseTable.GetLength(1); k++)
                {
                    courseTable[i, k] = new Course("", "", "");
                }
                if (DateTime.Compare(date[i], firstNovember) == 0 || DateTime.Compare(date[i], armistice) == 0 || DateTime.Compare(date[i], christmas) == 0 || DateTime.Compare(date[i], newYearsDay) == 0 || DateTime.Compare(date[i], laborDay) == 0 || DateTime.Compare(date[i], secondArmistice) == 0 || DateTime.Compare(date[i], nationalFest) == 0 || DateTime.Compare(date[i], assomption) == 0 || DateTime.Compare(date[i], easter) == 0 || DateTime.Compare(date[i], ascension) == 0 || DateTime.Compare(date[i], pentecost) == 0)
                {
                    for (int k = 0; k < courseTable.GetLength(1); k++)
                    {
                        courseTable[i, k] = new Course("HOLIDAY");
                    }
                }
            }

            #endregion
        }

        public Course[,] CourseTable
        {
            get { return courseTable; }
        }

        public DateTime[] Date
        {
            get { return date; }
        }
    }
}
