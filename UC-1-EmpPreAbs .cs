using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmplyoeeWageProblemUsingOOps
{
    public class UC_1_EmpPreAbs
    {
        public void EmpPresentAbsent()
        {
            Random random = new Random();
            int num = random.Next(2);

            if (num == 1)
            {
                Console.WriteLine("Emplyoee is Present");
            }
            else
            {
                Console.WriteLine("Emplyoee is Absent");
            }
        }
    }
}
