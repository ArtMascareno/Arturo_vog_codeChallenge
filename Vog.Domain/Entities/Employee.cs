using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vog.Domain.Entities
{
    public class Employee : Entity
    {
        public Employee(string firstName, string lastName, string jobTitle, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            Address = address;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
    }
}
