using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Coleman_s00189824
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OSImage { get; set; }
        public string Phone_Image { get; set; }

        public override string ToString()
        {
            return Name;
        }


        public void IncreasePrice(decimal Percentage)
        {
            
            Price += (Price / 100) * Percentage;
        }
    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }

        public DbSet<Phone> Phones { get; set; }
    }

}
