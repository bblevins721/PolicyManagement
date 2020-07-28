using PolicyManagment.Data;
using System;
using System.IO;

namespace PolicyManagement.Data
{
    public class PolicyVersion : BaseEntity
    {


        /// <summary>
        /// Number of versions
        /// </summary>
        public decimal VersionNumber { get; set; }

        /// <summary>
        /// Date  Created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Version description
        /// </summary>
        public string Description { get; set; }

        public string Document { get; set; }

    }
}
