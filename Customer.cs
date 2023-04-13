using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassesAndRecords.Course;

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
                return FirstName + ", " + _LastName;

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

namespace ClassesAndRecords
{
    class Program
    {
        //static void PrintCourse(Course course)
        //{
        //    Console.WriteLine(course.Name);
        //}
        static void Main(string[] args)
        {
            var PluralSightCourse = new Course();
            PluralSightCourse.Name = "Working with C# records";
            PluralSightCourse.Auther = "Roland Gijit";

            var ClassRoomCourse = new CourseRecord("Working with C# records", "Roland Gijit");

            //destructuring

            //var name = ClassRoomCourse.Name;
            //var author = ClassRoomCourse.Author;
            var (name, author) = ClassRoomCourse;
            Console.WriteLine(name);
            Console.WriteLine(author);
            //var anotherCourse = PluralSightCourse;
            //Console.WriteLine(PluralSightCourse.Name);
            //Console.WriteLine(anotherCourse.Name);
            //PrintCourse(PluralSightCourse);
        }

    }
    public class Course
    {
        public string Name { get; set; }
        public string Auther { get; set; }

        public record CourseRecord(string Name, string Author);
    }
}


