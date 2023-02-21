using EmployeeWageComputationUsingOOPS;

namespace EmpWageCompNonStaticProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuiltArray empWageBuiltArray = new EmpWageBuiltArray();
            empWageBuiltArray.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuiltArray.addCompanyEmpWage("Reliance", 20, 2, 10);
            empWageBuiltArray.computeEmpWage();
        }
    }
}
