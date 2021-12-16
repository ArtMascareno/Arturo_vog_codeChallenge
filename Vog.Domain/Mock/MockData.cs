using System;
using System.Collections.Generic;
using System.Text;
using Vog.Domain.Entities;

namespace Vog.Domain.Mock
{
    public class MockData
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, 1, "Arturo", "Mascareño", "Developer", "MyHouse"));
            employees.Add(new Employee(2, 3, "Enrique", "Ramírez", "QA", "Xipe"));
            employees.Add(new Employee(3, 2, "Cecilia", "Mata", "PM", "Garden"));
            employees.Add(new Employee(4, 1, "Luis", "Díaz", "Developer", "Portillo"));
            return employees;
        }
        
        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(1, "Developers", "Xipe", GetEmployees().FindAll(x => x.DepartmentId == 1)));
            departments.Add(new Department(2, "Project Managers", "Comulink", GetEmployees().FindAll(x => x.DepartmentId == 2)));
            departments.Add(new Department(3, "Quality", "XTechnology", GetEmployees().FindAll(x => x.DepartmentId == 3)));

            return departments;
        }
    }
}
