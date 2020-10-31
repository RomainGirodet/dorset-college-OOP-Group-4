using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    // Corentin Chatin 23201

    class Faculty_member
    {

        public List<Class> liste_Classe { get; set; }
        public List<Student> my_student { get; set; }
        public List<Class> my_classes ;

        public Faculty_member()
        {

        }
        public void Assesment(Class classeA)
        {

        }
        public void Grade(Student george)
        {

        }
        public void Acces_Info()
        {

        }
        public void Repport_Missing(Student mickael)

        {    if (langages.Contains(mickael) == true) { 
                Absence(mickael);
                
            }
        else {  Console.WriteLine($" the student {mickael.name} is not one of your student")
            }
        }



    }
}

