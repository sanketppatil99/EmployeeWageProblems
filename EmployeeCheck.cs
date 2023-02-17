using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeCheck
    {
        public void EmployeeAttendance()
        {
            int Is_Full_time = 1;

            int Emp_Rate_per_hour = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empCheck = rand.Next(3);
            //Computation
            if (empCheck == Is_Full_time)
            {
                Console.WriteLine("Employee is Full Time");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is not Worked");
                empHrs = 0;
            }
            empWage = Emp_Rate_per_hour * empHrs;
            Console.WriteLine("Employee Wage =  " + empWage);


        }
    }
}
