using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class WageComputation
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        string company;
        int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage = 0;
        public WageComputation(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmployeeWage()
        {
            int empHour = 0, workingDays = 0, totalHours = 0;
            int check;
            Random random = new Random();
            while (workingDays <= numOfWorkingDays && totalHours <= maxHoursPerMonth)
            {
                workingDays++;
                check = random.Next(0, 3);
                switch (check)
                {
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalHours += empHour;
                Console.WriteLine("Day {0} Employee hours {1}", workingDays, totalHours);
            }
            totalEmpWage = totalHours * this.empRatePerHour;
        }
        public string displaySalary()
        {
            return "Total Employee wage for the Company " + company + " is : " + totalEmpWage;
        }
    }
}
