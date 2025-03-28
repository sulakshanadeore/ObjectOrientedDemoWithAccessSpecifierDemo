namespace LogicLibrary
{
    public class Products
    {
        //Achieved encapsulation--by default all variables are private, ie accessible only inside the class
        int _productid;//variable means field
        string _productname;
        float _price;
        string _UnitOfMeasurement;
        internal string _description;


        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public  int Qty { get; set; }

        public void ShowAllProducts()
        {
            Console.WriteLine("1. Tea 10 \n 2. Coffee 20");
        
        }

        public void AcceptData(int productid, string productname, 
            float price, string unitOfMeasurement)
        {
            
            
        _productid = productid;
        _productname = productname;
            _price = price;
            _UnitOfMeasurement = unitOfMeasurement;
        
        }

        public void DisplayData()
        {
           // Console.WriteLine(_productid + _productname + _price + _UnitOfMeasurement);
           
        string data=string.Concat(_productid, _productname,
            _price, _UnitOfMeasurement);
            Console.WriteLine(data);
        
        
        }



    }



}
