using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Models
{
    public class Insurance
    {
        public int Number { get; set; }
        public DateTime InitialContractDate { get; set; }
        public float InsurenceCoverage { get; set; }
        public float MonthlyPayment { get; set; }

        public String? CustomerCF { get; set; }
        public Customer Customer { get; set; }
    }
}
