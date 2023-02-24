using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeCheck
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public void ComputeEmpWage(string company, int empPerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            
            int empHrs = 0;
            int empWage = 0;
            int day = 1;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;

            
            Random random = new Random();
            while (day <= maxWorkingDays && totalEmpHrs <= maxWorkingHrs)
            {
                int empAttendence = random.Next(0, 3);
                switch (empAttendence)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empPerHrs;
                totalEmpWage = totalEmpWage + empWage;
                day++;
                totalEmpHrs = totalEmpHrs + empHrs;
            }
            Console.WriteLine("Total Employee Wage for {0}  TotalEmpWage: {1} and totalHrs: {2} ", company ,totalEmpWage, totalEmpHrs);

        }
    }
}
