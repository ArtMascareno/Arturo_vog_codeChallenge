using System;
using UserInterface.Services;

namespace UserInterface
{
    class Program
    {
        private static readonly EmployeeService _employeeService = new EmployeeService();
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var employees = _employeeService.ListAll();
            foreach (var employee in employees)
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - {employee.Address}");
        }
    }
}
