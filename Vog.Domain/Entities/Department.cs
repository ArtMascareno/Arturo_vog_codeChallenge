using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vog.Domain.Entities
{
    public class Department : Entity
    {
        public string Name { get; set; }
        [Index(IsUnique = true)]
        [StringLength(450)]
        public string Address { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
