using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Context;
using TestWeek6.Models;

namespace TestWeek6.Repository
{
    public class RepositoryInsurance : IRepositoryInsurance
    {
        public Insurance Create(Insurance item)
        {
            using (var ctx = new InsurancePackageContext())
            {
                if (item != null)
                {
                    try
                    {
                        ctx.Entry<Insurance>(item).State = EntityState.Added;
                        ctx.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        return null;
                    }

                }
            }
            return item;
        }

       

        public ICollection<Insurance> GetAll()
        {
            using (var ctx = new InsurancePackageContext())
            {
                return ctx.Insuraces.ToList();
            }
        }

        public Insurance GetByNumber(int number)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Insurance Update(int number, Insurance insuranceToUpdate)
        {
            //TODO
            throw new NotImplementedException();
        }
        public bool Delete(int number)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
