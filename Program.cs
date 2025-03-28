using LogicLibrary;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        StringWorking obj=new StringWorking();
        string s=obj.FindSubstring("Hexaware", 3);
        Console.WriteLine(s);
        obj.AppendString("Hexaware", "Technologies");

        StringOperationVersion2 v2=new StringOperationVersion2();   
        int i=v2.LengthOfString("Hello");
        Console.WriteLine(i);
        
        DemoOnWorkingWithStringBuilder demo=new DemoOnWorkingWithStringBuilder();
        demo.AppendString("Welcome","To Hexaware");
        Console.WriteLine("----------------------------------");

        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.AppendLine("World");
        sb.AppendLine("Hello C#");
        Console.WriteLine(sb);

        Console.WriteLine("-----------------------------");
        StringBuilder strAmt=new StringBuilder("The total amt=");
        strAmt.AppendFormat("{0:C}", 250);
        Console.WriteLine(strAmt);

        Console.WriteLine("======================================");
        demo.InsertString("Hello Hexaware","C#");

        implementAll obj1=new implementAll();
        Console.WriteLine(obj1.FindAscii('A'));
        obj1.Print();
        decimal output=obj1.ConcatNumbers(5444444.333m, 123123.244m);
        Console.WriteLine(output);


        //Login obj=new Login();
        //Console.WriteLine("Enter Username");
        //obj.UserName = Console.ReadLine();
        //Console.WriteLine("Etner Passwrod");
        //obj.Password = Console.ReadLine();

        //LoginAndPlaceOrder();
       
        //Person p=new Person("Tina","Someone,",new DateTime(2000, 01, 11));
        //p.DisplayEmpDetails();

        //Person p1 = new Person();
        //p1.DisplayEmpDetails();

        Console.WriteLine("-------------------------------------------");
      //  Employee emp = new Employee("", "", new DateTime(), 123, 10);
        //Employee emp = new Employee("Tina", "Somename", new DateTime(2000, 01, 11), 123, 10);
        //Person p=new Person();
        //p.FirstName = "Tina";
        //p.LastName = "SomeName";
        //p.DateOfBirth = new DateTime(2000, 01, 11);
        

        //Employee emp=new Employee();
        //emp.Empid = 123;
        //emp.Deptno = 10;
        
        //emp.DisplayEmpDetails();




        //Console.WriteLine("Hello, World!");
        //Customer c=new Customer();
        //Console.WriteLine("Enter Customerid");
        //c.Customerid=Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter Customer NAme");
        //c.CustomerName = Console.ReadLine();

        //Console.WriteLine("Enter the orderDate of the customer");
        //c.OrderDate= Convert.ToDateTime(Console.ReadLine());

        //Console.WriteLine($"You entered customerid= {c.Customerid}");
        //Console.WriteLine($"You entered customername= {c.CustomerName}");
        //Console.WriteLine($"You entered ORderdate= {c.OrderDate}");

        //Customer c1=new Customer();
        //Console.WriteLine("Enter Customerid");
        //c1.Customerid = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter Customer NAme");
        //c1.CustomerName = Console.ReadLine();

        //Console.WriteLine("Enter the orderDate of the customer");
        //c1.OrderDate = Convert.ToDateTime(Console.ReadLine());

        //Console.WriteLine($"You entered customerid= {c1.Customerid}");
        //Console.WriteLine($"You entered customername= {c1.CustomerName}");
        //Console.WriteLine($"You entered ORderdate= {c1.OrderDate}");

        //c1._city

        //if (c1.Customerid == c.Customerid)
        //{
        //    Console.WriteLine("They are same");
        //}
        //else {
        //    Console.WriteLine("Not same.....");
        //}



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

    private static void LoginAndPlaceOrder()
    {
        Console.WriteLine("Enter username");
        string uname = Console.ReadLine();
        Console.WriteLine("Enter password");
        string pwd = Console.ReadLine();
        Console.WriteLine("Enter mobile no");
        long mobNo = Convert.ToInt64(Console.ReadLine());

        //Login obj = new Login("Gauri", "Gauri@123");
        Login obj = new Login(mobNo, uname, pwd);

        Console.WriteLine(obj.UserName + obj.Password + obj.MobileNo);

        Console.WriteLine("Pls wait while we validate your credentials");
        bool isCredentialsValid = obj.ValidateCredentials();
        Console.WriteLine($"Enter this otp to validate yourself  {obj.OTP}");
        Console.WriteLine("Enter the otp sent to you");
        obj.CheckOTP = Convert.ToInt32(Console.ReadLine());
        bool isloginSuccessful = obj.IsLoginSuccessful;
        if (isloginSuccessful)
        {
            Console.WriteLine($"Your login is {isloginSuccessful}");
            Products p = new Products();
            p.ShowAllProducts();
            Console.WriteLine("Now place your order");
            Console.WriteLine("Enter productid");
            p.ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter productname");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price");
            p.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            p.Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the above order confirmed? Press Y/N...");
            char userans = Convert.ToChar(Console.ReadLine());
            if (userans == 'Y')
            {
                Orders custorder = new Orders(p.ProductID, p.ProductName, p.Price, p.Qty);

                double Amt = custorder.CalculateTotalPrice();
                Console.WriteLine($"You have placed a order for {p.ProductName} for a Quantity of {p.Qty} At a price of Rs.{p.Price}, Total Price=Rs.{Amt}");


            }
            else
            {
                Console.WriteLine("Thanks for visiting.....");


            }

        }
    }
}