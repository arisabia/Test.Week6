using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Models
{
    public class Customer
    {
        public String CF { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Address { get; set; }


        public ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    }
}
