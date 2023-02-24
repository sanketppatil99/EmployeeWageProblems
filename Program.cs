namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            WageComputation samsung = new WageComputation("Samsung", 20, 5, 10);
            WageComputation reliance = new WageComputation("Reliance", 10, 4, 15);
            WageComputation airtel = new WageComputation("Airtel", 30, 5, 20);
            samsung.ComputeEmployeeWage();
            Console.WriteLine(samsung.displaySalary() + "\n");
            reliance.ComputeEmployeeWage();
            Console.WriteLine(reliance.displaySalary() + "\n");
            airtel.ComputeEmployeeWage();
            Console.WriteLine(airtel.displaySalary() + "\n");
        }
    }
}
