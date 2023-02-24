namespace EmployeeWage
{
    class Program
    {
        public class EmpWageBuilder : IComputeEmpWage
        {
            
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;
            List<CompanyEmpWage> list;
            public EmpWageBuilder()
            {
                
                list = new List<CompanyEmpWage>();
            }
            public void AddCompanyCompanyEmpWage(string company, int maxWorkingDays, int maxWorkingHrs, int empPerHrs)
            {
                CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, maxWorkingDays, maxWorkingHrs, empPerHrs);
                list.Add(companyEmpWage);
            }
            public void IterateOverCompanies()
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int totalWage = ComputeEmpWage(list[i]);
                    list[i].SetTotalEmpWage(totalWage);
                    Console.WriteLine(list[i]);
                }
            }
            public int ComputeEmpWage(CompanyEmpWage details)
            {
                
                int empHrs = 0, empWage = 0, day = 1, totalEmpWage = 0, totalEmpHrs = 0;

                Random random = new Random();
                while (day <= details.maxWorkingDays && totalEmpHrs <= details.maxWorkingHrs)
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
                    empWage = empHrs * details.empPerHrs;
                    totalEmpWage = totalEmpWage + empWage;
                    day++;
                    totalEmpHrs = totalEmpHrs + empHrs;
                }
                return totalEmpWage;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Employee Wage Computation\n--------------------------------------------\n");
                EmpWageBuilder builder = new EmpWageBuilder();
                builder.AddCompanyCompanyEmpWage("TCS", 25, 10, 20);
                builder.AddCompanyCompanyEmpWage("Capgemini", 25, 20, 30);
                builder.AddCompanyCompanyEmpWage("Wipro", 35, 30, 45);
                builder.IterateOverCompanies();
                Console.ReadLine();
            }
        }
    }
}
