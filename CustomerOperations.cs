using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class CustomerOperations:Customer
    {


        public void GetAllCustomerData()
        {
            //base._city--- yes accessible
            base._password = "MyPassword";
        }
    }
}
