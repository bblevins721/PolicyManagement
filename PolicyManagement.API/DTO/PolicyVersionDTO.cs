using System;
using System.IO;

namespace PolicyManagement.API.DTO
{
    public class PolicyVersionDTO
    {
        /// <summary>
        /// Policy ID
        /// </summary>
        public int Id { get; set; }

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

        public FileStream Document { get; set; }

    }
}
