using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public interface IOperations
    {
        public int AddNumbers(int number1,int number2);
        public int AddStrings(string str1, string str2);
        
        public int FindAscii(char c);   

    }

    public interface INumbers
    { 
    public decimal ConcatNumbers(decimal number1, decimal number2); 
    
    }


    public interface IAllOperations:IOperations,INumbers
    {
        public void Print();
    
    }

   public class implementAll : IAllOperations
    {
        public int AddNumbers(int number1, int number2)
        {
        return number1 + number2;   
        }

        public int AddStrings(string str1, string str2)
        {
            string s=string.Concat(str1, str2);  
            return s.Length;
        }

        public decimal ConcatNumbers(decimal number1, decimal number2)
        {
           

            decimal result = number1 + number2; 
            return result;

        }

        public int FindAscii(char c)
        {
            return (int)c;
        }

        public void Print()
        {
            Console.WriteLine("Print Functionality");
        }
    }
}
