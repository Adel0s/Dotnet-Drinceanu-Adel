using System;
using System.Collections.Generic;
using System.Text;

namespace Drinceanu_Adel
{
    public class Person
    {
        string middleName = "Hastag"; //field
        string _middleName = "Hastag2"; //field
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Property
        public string FullName
        {
            get 
            {
                return FirstName + " " + LastName;
            }
        }

        //Method
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
