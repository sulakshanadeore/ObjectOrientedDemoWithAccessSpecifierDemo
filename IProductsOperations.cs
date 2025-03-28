using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    //Its a contract, ie. it can behave differently with different classes, through the same method name.
    //Only declarations are allowed in the interface.
    //Can you declare constants in interface? Yes and also ofcourse initialize
    //Can you declare variable in interface? No
    public interface IProductsOperations
    {

        const float pi = 3.14f;

        public void AddProduct(Products products);
        public void RemoveProduct(int productid);
        public void UpdateProduct(int productid,Products newProductData);

        public void DeleteProduct(int productid);   


        
    }


    public interface IMoreOperationsOnString
    {
        public void AppendString(string actualString, string newStringToAppend);
        public void InsertString(string actualString, string newStringToInsert);

    }


    public interface IStringOperations
    { 
    public void AppendString(string actualString,string newStringToAppend);
    public int LengthOfString(string actualString);
    public string FindSubstring(string actualString, int index);

        public string GetEmptyString();

    }


}
