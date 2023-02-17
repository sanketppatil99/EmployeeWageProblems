namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeCheck employeeCheck = new EmployeeCheck();
            employeeCheck.EmployeeAttendance();
        }
    }
}
