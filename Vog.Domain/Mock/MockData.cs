using System;
using System.Collections.Generic;
using System.Text;
using Vog.Domain.Entities;

namespace Vog.Domain.Mock
{
    public class MockData
    {
        public IList<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Arturo", "Mascareño", "Developer", "MyHouse"));
            employees.Add(new Employee("Enrique", "Ramírez", "QA", "Xipe"));
            employees.Add(new Employee("Cecilia", "Mata", "Designer", "Garden"));
            return employees;
        }
    }
}
