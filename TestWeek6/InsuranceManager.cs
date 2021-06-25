using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Models;
using TestWeek6.Repository;

namespace TestWeek6
{
    public class InsuranceManager
    {
        static IRepository<Insurance> repoInsurance = new RepositoryInsurance();
        static IRepository<Customer> repoCustomer = new RepositoryCustomer();
        public static bool ScreenMenu()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Add Insurance");
            Console.WriteLine("3.Print data");
            Console.WriteLine("0. Exit");

            int choice = InputCheck(3);
            return ChoiceManager(choice);
        }

        private static bool ChoiceManager(int choice)
        {
            bool go = true;
            switch (choice)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    AddInsurance();
                    break;
                case 3:
                    Print();
                    break;
                default:
                    go = false;
                    Console.WriteLine("See you soon");
                    break;
            }
            return go;
        }

        private static void Print()
        {
            Console.WriteLine("What do you want to print?");

        }

        private static void AddInsurance()
        {
            throw new NotImplementedException();
        }

        private static void AddCustomer()
        {
            throw new NotImplementedException();
        }

        private static int InputCheck(int v)
        {
            throw new NotImplementedException();
        }
    }
}
