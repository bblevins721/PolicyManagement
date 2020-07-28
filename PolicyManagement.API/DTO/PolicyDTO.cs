using System;
using System.Collections;
using System.Collections.Generic;

namespace PolicyManagement.API.DTO
{
    public class PolicyDTO
    {
        /// <summary>
        /// Policy ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Policy meta data
        /// </summary>
        public PolicyMetaDataDTO MetaData { get; set; }

        public IEnumerable<PolicyVersionDTO> Versions { get; set; }

    }
}
