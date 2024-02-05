using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Entities
{
    internal class Leave : BaseEntity
    {
        public Employee EmployeeName { get; set; }
        public int EmployeeNameId { get; set; }
        public LeaveSetup LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public string Reason { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string EndorseTo { get; set; }
        public string Status { get; set; }
    }
}
