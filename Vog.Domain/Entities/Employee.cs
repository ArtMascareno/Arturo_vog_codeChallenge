using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vog.Domain.Entities
{
    public class Employee : Entity
    {
        public Employee(int id,int departmentId, string firstName, string lastName, string jobTitle, string address)
        {
            Id = id;
            DepartmentId = departmentId;
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            Address = address;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        
        public int DepartmentId { get; set; }

    }
}
