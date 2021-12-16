using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserInterface.Core;
using Vog.Domain.Entities;
using Vog.Domain.Mock;

namespace UserInterface.Services
{


    public class EmployeeService
    {
        //protected DataBaseContext _context;
        //public EmployeeService(DataBaseContext context)
        //{
        //    _context = context;
        //}

        public IEnumerable<Employee> GetAll()
        {
            //return _context.Employees.Select(x => x).ToList();
            MockData mockData = new MockData();
            return mockData.GetEmployees();
        }

        public IList<Employee> ListAll()
        {
            //return _context.Employees.Select(x => x).ToList();
            MockData mockData = new MockData();
            return mockData.GetEmployees();
        }
        
        public IList<Employee> ListAllByDepartment(int departmentId)
        {
            //return _context.Employees.Where(x => x.DepartmentId == departmentId).ToList();
            MockData mockData = new MockData();
            var depEmployees = mockData.GetEmployees().Where(x => x.DepartmentId == departmentId).ToList();
            return depEmployees;
        }
    }
}
