using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    //Employee "is a" /"is also a" Person 

    //Person is parent class , Employee is child class
    //Parent is referred in the child class using "base".
    public class Employee:Person
    {
        public int Empid { get; set; }
        public int Deptno { get; set; }

        public Employee():base()
        {
            
        }
        public Employee(string fname,string lname,DateTime dob,int employeeid,int departmentno):base(fname,lname,dob)
        {
            //base.FirstName = fname;
            //base.LastName = lname;
            //base.DateOfBirth = dob;

            Empid = employeeid;
            Deptno = departmentno;
            
        }

        public void DisplayEmpDetails()
        {
          base.DisplayEmpDetails();
            Console.WriteLine(Empid);
            Console.WriteLine(Deptno);
        
        }
    }
}
