using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Models;

namespace TestWeek6.Repository
{
    public interface IRepositoryInsurance : IRepository<Insurance>
    {
        public Insurance GetByNumber(int number);
        public Insurance Update(int number, Insurance insuranceToUpdate);
        public bool Delete(int number);
        
    }
}
