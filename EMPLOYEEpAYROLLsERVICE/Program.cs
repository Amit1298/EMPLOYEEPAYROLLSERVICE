using System;

namespace EMPLOYEEpAYROLLsERVICE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetAllEmployee();
        }
    }
}
