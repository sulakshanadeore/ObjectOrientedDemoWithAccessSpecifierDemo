using LogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    public class OutsideAssemblyClass:MyInternalClass
    {
        public void Check()
        {
            MyInternalClass obj = new MyInternalClass();
            obj._publicVariable = 1;
            //obj._internalVariable = 2;//Error
           // obj._protectedInternalVariable = 3; //Error
          //  obj._protectedVariable = 1;        Error
          base._protectedInternalVariable = 2;  

        }
    }
}
