using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Entities
{
    internal class Employee : BaseEntity
    {
        public int EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string ContractStart { get; set; }
        public string ContractExpiration { get; set; }
        public string Status { get; set; }
    }
}
