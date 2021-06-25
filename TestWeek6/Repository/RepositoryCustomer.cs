using Microsoft.Data.SqlClient;
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
    public class RepositoryCustomer : IReposotoryCustomer
    {

        public Customer Create(Customer item)
        {
            using (var ctx = new InsurancePackageContext())
            {
                if (item != null)
                {
                    try
                    {
                        ctx.Entry<Customer>(item).State = EntityState.Added;
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


        public ICollection<Customer> GetAll()
        {
            using (var ctx = new InsurancePackageContext())
            {
                return ctx.Customers.ToList();
            }
        }
        public bool AddInsurance(string cf, Insurance insurance)
        {
            bool result = false;
            using (var ctx = new InsurancePackageContext())
            {
                var customer = GetByCf(cf);
                if (customer !=null)
                {
                    try
                    {
                        customer.Insurances.Add(insurance);
                        insurance.Customer = customer;
                        ctx.SaveChanges();
                        result = true;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }

                }
            }
            return result;
        }
        public Customer GetByCf(string cf)
        {
            using (var ctx = new InsurancePackageContext() )
            {
                if (cf == null || cf.Length == 0)
                {
                    return null;
                }
                return ctx.Customers.Find(cf);

            }
        }

        public Customer Update(string cf, Customer customerToUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(string cf)
        {

            throw new NotImplementedException();
        }

        
    }
}
