using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OOPGroup4
{
    class Timetable
    {
        public Course[,] timeTable; //Matrix representing the Timetable on 1 year
        public List<DayOfWeek> DayOfWeeks;
        public DateTime[] date;

        /// <summary>
        /// Function which creates a new Timetable for a student 
        /// </summary>
        public void CreateTimetable(int year, int year2)
        {
            Calendar calendarBasics = CultureInfo.InvariantCulture.Calendar;
            int daysInYear = calendarBasics.GetDaysInYear(year2);
            timeTable = new Course[daysInYear, 24];

            DateTime firstNovember = new DateTime(year, 11, 1);
            DateTime armistice = new DateTime(year, 11, 11);
            DateTime christmas = new DateTime(year, 12, 25);
            DateTime newYearsDay = new DateTime(year2, 1, 1);
            DateTime laborDay = new DateTime(year2, 5, 1);
            DateTime secondArmistice = new DateTime(year2, 5, 8);
            DateTime nationalFest = new DateTime(year2, 7, 14);
            DateTime assomption = new DateTime(year2, 8, 15);


            int n = year2 % 19;
            int c = year2 / 100;
            int u = year2 % 100;
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
            DateTime easter = new DateTime(year2, m, j + 1);
            DateTime ascension = easter.AddDays(40);
            DateTime pentecost = easter.AddDays(49);

            int months = 9;
            int days = 1;
            date = new DateTime[daysInYear];
            for(int i = 0; i < daysInYear; i++)
            {
                if(months == 4 || months == 6 || months == 9 || months == 11)
                {
                    if(days%31 != 0)
                    {
                        date[i] = new DateTime(year, months, days);
                        days++;
                    }
                    else
                    {
                        months++;
                        days = 1;
                    }
                }
                if (months == 1 || months == 3 || months == 5 || months == 7 || months == 8 || months == 10 || months == 12)
                {
                    if (days % 32 != 0)
                    {
                        date[i] = new DateTime(year, months, days);
                        days++;
                    }
                    else
                    {
                        months++;
                        days = 1;
                    }
                }
                if (months == 2)
                {
                    if(daysInYear == 366)
                    {
                        if (days % 30 != 0)
                        {
                            date[i] = new DateTime(year, months, days);
                            days++;
                        }
                        else
                        {
                            months++;
                            days = 1;
                        }
                    }
                    if (daysInYear == 365)
                    {
                        if (days % 29 != 0)
                        {
                            date[i] = new DateTime(year, months, days);
                            days++;
                        }
                        else
                        {
                            months++;
                            days = 1;
                        }
                    }
                }
                if(months == 13)
                {
                    months = 1;
                    year++;

                }
                if (DateTime.Compare(date[i], firstNovember) == 0 || DateTime.Compare(date[i], armistice) == 0 || DateTime.Compare(date[i], christmas) == 0 || DateTime.Compare(date[i], newYearsDay) == 0 || DateTime.Compare(date[i], laborDay) == 0 || DateTime.Compare(date[i], secondArmistice) == 0 || DateTime.Compare(date[i], nationalFest) == 0 || DateTime.Compare(date[i], assomption) == 0 || DateTime.Compare(date[i], easter) == 0 || DateTime.Compare(date[i], ascension) == 0 || DateTime.Compare(date[i], pentecost) == 0)
                {
                    for(int k = 0; k < timeTable.GetLength(1); k++)
                    {
                        timeTable[i, j] = new Course();
                    }
                }
            }
        }
    }
}
