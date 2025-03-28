using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{

    public class StringOperationVersion2 : IStringOperations
    {
        public void AppendString(string actualString, string newStringToAppend)
        {
            throw new NotImplementedException();
           
        }

        public string FindSubstring(string actualString, int index)
        {
            throw new NotImplementedException();
        }

        public string GetEmptyString()
        {
            throw new NotImplementedException();
        }

        public int LengthOfString(string actualString)
        {
         //   throw new NotImplementedException();
         return actualString.Length;    
        }
    }


    public class StringWorking : IStringOperations
    {
        public void AppendString(string actualString, string newStringToAppend)
        {
           string newString= string.Concat(actualString, newStringToAppend);
            Console.WriteLine(newString);
        }

        public string FindSubstring(string actualString, int index)
        {
           string s= actualString.Substring(index);
           return s;    
        }

        public int LengthOfString(string actualString)
        {

            throw new NotImplementedException();
            
            
        }
        public string GetEmptyString() { 
        string s=string.Empty;
            if (string.IsNullOrEmpty(s)) {
                 s=string.Empty;    

            }
            return s;
            
        
        }

    }
}
