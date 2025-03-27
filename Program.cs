using LogicLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Customer c=new Customer();
        Console.WriteLine("Enter Customerid");
        c.Customerid=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Customer NAme");
        c.CustomerName = Console.ReadLine();

        Console.WriteLine("Enter the orderDate of the customer");
        c.OrderDate= Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine($"You entered customerid= {c.Customerid}");
        Console.WriteLine($"You entered customername= {c.CustomerName}");
        Console.WriteLine($"You entered ORderdate= {c.OrderDate}");

        Customer c1=new Customer();
        Console.WriteLine("Enter Customerid");
        c1.Customerid = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Customer NAme");
        c1.CustomerName = Console.ReadLine();

        Console.WriteLine("Enter the orderDate of the customer");
        c1.OrderDate = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine($"You entered customerid= {c1.Customerid}");
        Console.WriteLine($"You entered customername= {c1.CustomerName}");
        Console.WriteLine($"You entered ORderdate= {c1.OrderDate}");

        c1._city

        if (c1.Customerid == c.Customerid)
        {
            Console.WriteLine("They are same");
        }
        else {
            Console.WriteLine("Not same.....");
        }



        //Products p=new Products();
        //Console.WriteLine("Enter productid");
        //int prodid=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Eneter PRoduct name");
        //string pname=Console.ReadLine();
        //Console.WriteLine("enter price");
        //float prodprice=Convert.ToSingle(Console.ReadLine());
        //Console.WriteLine("Enter Unit of Measurement");
        //string uom=Console.ReadLine();

        //p.AcceptData(prodid,pname,prodprice,uom);
        //p.DisplayData();

        //Products secondProd=new Products();
        //Console.WriteLine("Enter productid");
        // prodid = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Eneter PRoduct name");
        // pname = Console.ReadLine();
        //Console.WriteLine("enter price");
        // prodprice = Convert.ToSingle(Console.ReadLine());
        //Console.WriteLine("Enter Unit of Measurement");
        // uom = Console.ReadLine();
        //secondProd.AcceptData(prodid,pname, prodprice, 
        //    uom);    
        //secondProd.DisplayData();




    }
}