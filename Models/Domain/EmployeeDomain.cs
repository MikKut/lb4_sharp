using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Domain
{

    public class EmployeeDomain
    {
        public EmployeeDomain(string fistName, string lastName, int salary)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = fistName;
            LastName = lastName;
            Salary = salary;
        }
        public EmployeeDomain(string id, string fistName, string lastName, int salary)
        {
            Id = id;
            FirstName = fistName;
            LastName = lastName;
            Salary = salary;
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}