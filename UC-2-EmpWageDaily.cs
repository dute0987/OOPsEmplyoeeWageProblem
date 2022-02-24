using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmplyoeeWageProblemUsingOOps
{
    public class UC_2_EmpWageDaily
    {
        public void CalDailyEmpWage()
        {
            int WageRatePerHour = 20;
            int FullDayHour = 8;
            int CalEmpWage = 0;

            Random random = new Random();
            int num = random.Next(2);

            if (num == 1)
            {
                CalEmpWage = WageRatePerHour * FullDayHour;

                Console.WriteLine("Wage Calculation is:- " + CalEmpWage);
            }
            else
            {
                CalEmpWage = 0;
                Console.WriteLine("Wage Calculation is:- " + CalEmpWage);
            }
        }
    }
}
