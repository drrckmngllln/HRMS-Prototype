using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class AttendanceSetup : BaseEntity
    {
        public string TimeInType { get; set; }
        public string Time { get; set; }
    }
}
