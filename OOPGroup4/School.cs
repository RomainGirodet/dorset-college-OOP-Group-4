using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class School
    {
        string place;
        string school_name;
        

        public School(string place, string school_name)
        {
            this.place = place;
            this.school_name = school_name;
            
        }

        public string Place
        {
            get { return this.place; }
        }
        public string School_name
        {
            get { return this.school_name; }
        }
    }
}
