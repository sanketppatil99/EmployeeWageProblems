namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeCheck employeeCheck = new EmployeeCheck();
            employeeCheck.ComputeEmpWage("TCS", 25, 10, 20);
            employeeCheck.ComputeEmpWage("Capgemini", 25, 20, 30);
            employeeCheck.ComputeEmpWage("Wipro", 35, 30, 45);
        }
    }
}
