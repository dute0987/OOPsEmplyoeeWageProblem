using System;
namespace Day_8_EmplyoeeWageProblemUsingOOps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message For EmplyoeeWage Problem using OOPs
            //Console.WriteLine("Welcome To the EmplyoeeWage Problems Using OOPs Concept");

            //// UC-1-Problem
            //UC_1_EmpPreAbs UC1 = new UC_1_EmpPreAbs();
            //UC1.EmpPresentAbsent();

            ////UC-2-Problem
            //UC_2_EmpWageDaily UC2 = new UC_2_EmpWageDaily();
            //UC2.CalDailyEmpWage();

            ////UC-3-Problem
            //UC_3_PartFullTime UC3 = new UC_3_PartFullTime();
            //UC3.WageOfParTimeFullTime();

            ////UC-4-Problem
            //UC_4_SwitchCaseProblem UC4 = new UC_4_SwitchCaseProblem();
            //UC4.SwitchStatmentCaseProblem();

            //UC-5-Problem
            UC_5_MonthWageCal UC5 = new UC_5_MonthWageCal();
            UC5.CalculationOfMonthlyWage();

            ////UC-6-Problem
            //UC_6_CalOfWageOnCondition UC6 = new UC_6_CalOfWageOnCondition();
            //UC6.WageCalTillGetMaximunCondition();
        }
    }
}
