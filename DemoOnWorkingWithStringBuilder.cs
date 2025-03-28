using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class DemoOnWorkingWithStringBuilder : IMoreOperationsOnString,IStringOperations
    {
        public void AppendString(string actualString, string newStringToAppend)
        {
           //StringBuilder b=new StringBuilder();
            StringBuilder b = new StringBuilder("Hello");
            Console.WriteLine("Length=" + b.Length);
            for (int i = 0; i < b.Length; i++) {
                Console.Write(b[i]);
            }
            Console.WriteLine("-------------------------");
           b= b.Append(newStringToAppend);
            Console.WriteLine("After Appending the Length of Stringbuilder b=" + b.Length);
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }


        }


        public void InsertString(string actualString, string newStringToInsert)
        {
            StringBuilder sb = new StringBuilder(actualString);
            sb = sb.Insert(2, newStringToInsert);
           Console.WriteLine(sb);
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
            throw new NotImplementedException();
        }
    }

}
