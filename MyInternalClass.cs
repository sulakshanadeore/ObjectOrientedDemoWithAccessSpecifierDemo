using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MyInternalClass
    {

        private int _privateVariable;
        public int _publicVariable;
        internal int _internalVariable;
        protected int _protectedVariable;
       protected internal int _protectedInternalVariable;

    }

    public class AnotherClass : MyInternalClass
    {

        public void Check()
        { 
        base._publicVariable = 1;
            base._protectedVariable = 2;
            base._protectedInternalVariable = 3;
            
        
        }
    
    }

    public class SomeOtherClass
    {

        public void Check() { 
        MyInternalClass obj=new MyInternalClass();
            obj._publicVariable = 1;
            obj._internalVariable = 2;
            obj._protectedInternalVariable= 3;
            //obj._protectedVariable = 1;        Error
        
        }
    
    }

}
