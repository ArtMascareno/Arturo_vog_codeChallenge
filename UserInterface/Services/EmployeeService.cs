using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vog.Domain.Entities;
using Vog.Domain.Mock;

namespace UserInterface.Services
{
    public class EmployeeService
    {
        public IEnumerable<Employee> GetAll()
        {
            MockData mockData = new MockData();
            return mockData.GetEmployees();
        }

        public IList<Employee> ListAll()
        {
            MockData mockData = new MockData();
            return mockData.GetEmployees();
        }
    }
}
