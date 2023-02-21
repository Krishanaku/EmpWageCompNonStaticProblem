namespace EmpWageCompNonStaticProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWage dMart = new EmployeeWage("DMart", 20, 2, 10);
            EmployeeWage reliance = new EmployeeWage("Reliance", 10, 4, 20); 
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
