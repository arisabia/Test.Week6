using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6
{
    public class InsuranceManager
    {
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
