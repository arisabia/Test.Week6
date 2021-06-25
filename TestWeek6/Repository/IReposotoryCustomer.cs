using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Models;

namespace TestWeek6.Repository
{
    public interface IReposotoryCustomer : IRepository<Customer>
    {
        public Customer GetByCf(string cf);
        public Customer Update(string cf, Customer customerToUpdate);
        public bool Delete(string cf);
        public bool AddInsurance(string cf, Insurance insurance);
    }
}
