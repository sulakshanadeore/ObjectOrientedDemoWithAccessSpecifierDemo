using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Orders:Products
    {
       
        public Orders(int productid, string productname, int price,int qty)
        { 
        
            base.ProductID= productid;  
            base.ProductName= productname;
            base.Price= price;
            base.Qty= qty;
        

        
        }

        
        public double CalculateTotalPrice()
        { 
            return base.Qty *base.Price;
          
        }
    }
}
