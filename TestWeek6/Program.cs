using System;

namespace TestWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool select = true;
            while (select)
            {
                select = InsuranceManager.ScreenMenu();
            }
        }
    }
}
