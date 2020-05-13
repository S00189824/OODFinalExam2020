using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using David_Coleman_s00189824;

namespace PhoneDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone() { PhoneID = 1, Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OSImage = "/Pics/android.png", Phone_Image = "s20.jpg" };
                Phone p2 = new Phone() { PhoneID = 2, Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OSImage = "/Pics/apple.png", Phone_Image = "iphone11.jpg" };


                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added phones to Database");

                db.SaveChanges();
            }
        }
    }
}
