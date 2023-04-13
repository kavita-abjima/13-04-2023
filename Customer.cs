using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL { 
    public class Customers

    {   public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        private string _LastName;

        public string FullName
        {
            get
            {
                return FirstName + " " + _LastName;

            }
        }
        public static int InstanceCount { get; set; }
        public string Lastname{
            get { return _LastName; }

            set { _LastName = value; }
        }
    }
    //public class CustomerTest
    //{
    //    public static object Assert { get; private set; }

    //    public static void Main(string[] args)
    //    {
    //        //arrange
    //        Customers C1 = new Customers
    //        {
    //            FirstName = "kavita",
    //            Lastname = "Jangir"
    //        };

    //        Console.WriteLine(C1.FullName);

    //        var c2 = new Customers();
    //        c2.FirstName = "Kavya";
    //        Customers.InstanceCount += 1;

    //        var c3 = new Customers();
    //        c3.FirstName = "Soniya";
    //        Customers.InstanceCount += 1;

    //        var c4 = new Customers();
    //        c4.FirstName = "Divya";
    //        Customers.InstanceCount += 1;

    //        object value = Assert.AreEqual(3,
    //                                       Customers.InstanceCount);
            
                

    //    }
    //}

}

