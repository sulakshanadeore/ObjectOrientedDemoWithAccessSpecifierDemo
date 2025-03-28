using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Person
    {
        public Person()
        {
            FirstName = "Raj";
           LastName = "Hareshwar";
            DateOfBirth = new DateTime(1999, 09, 11);
        }
        public Person(string fname,string lname,DateTime dob)
        {
            FirstName=fname;
            LastName=lname; 
            DateOfBirth=dob;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


        public void DisplayEmpDetails()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DateOfBirth);

        }

    }
}
