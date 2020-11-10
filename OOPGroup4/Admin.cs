using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOPGroup4
{
    class Admin : Member_of_school
    {
        //List<string>[,] AdminTimeTable= new List<string>[13,7];
        
        public Admin(string place, string school_name, int number_of_student, string id, string name, string surname, string password,
            int age, string sexe, string mail) : base(place, name, id, name, surname, password, age, sexe, mail)
        {

        }


        #region Absence_fonction
        /// <summary>
        /// Allows to change the parameter "active" from the absence from 1 to 0.
        /// The admin can then add a comment to justificate the absence.
        /// </summary>
        /// <param name="nameStudent"></param>
        public void JustifyAnAbsence(int studentID, int absNumber, string comment)
        {
            student[studentID].absence[absNumber].active = 0;
            student[studentID].absence[absNumber].comments = comment;
        }
        #endregion
        #region Get_information_fonction
        #endregion

    }
}
