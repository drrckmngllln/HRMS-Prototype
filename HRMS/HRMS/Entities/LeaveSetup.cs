﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Entities
{
    internal class LeaveSetup : BaseEntity
    {
        public string LeaveType { get; set; }
        public string Credits { get; set; }
    }
}
