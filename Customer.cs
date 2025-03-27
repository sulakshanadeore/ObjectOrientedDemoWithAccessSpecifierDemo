using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Customer
    {
     private   int _custid;//variable/field
        public int Customerid //Property---is a smart method which is used to accept and display data without having to write a extra parameter with a normal method.
        {
        set { _custid = value; }//Accepting the data for _custid, value is a keyword which is used to pass the data from the program.cs customerid to _custid.
        get { return _custid; }//Displaying the data for _custid
        }

        private protected string _password;

      private  string _custname;
        public string CustomerName
        {
            set { _custname = value; }
            get { return _custname; }
        }

      private  DateTime _orderDate;
        public DateTime OrderDate
        {
            set { _orderDate = value; }
            get { return _orderDate; }
        }

        protected string _city;
        public string City
        {
            set { _city = value;
                Products p = new Products();
                p.
            
            }
            get { return _city; }
        
        }

        protected internal string _Country;

        




    }




}
