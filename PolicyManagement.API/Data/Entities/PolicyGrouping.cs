using PolicyManagment.Data;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PolicyManagement.Data
{
    public class PolicyGrouping : BaseEntity
    {



        public IEnumerable<Policy> Policies { get; set; }

        public IEnumerable<PolicyGrouping> Folders { get; set; }

    }
}
