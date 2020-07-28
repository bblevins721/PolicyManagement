using System;
using System.Collections;
using System.Collections.Generic;

namespace PolicyManagement.API.DTO
{
    public class PolicyGroupingDTO
    {
        /// <summary>
        /// Policy ID
        /// </summary>
        public int Id { get; set; }


        public IEnumerable<PolicyMetaDataDTO> Policies { get; set; }

        public IEnumerable<PolicyGroupingDTO> Folders { get; set; }

    }
}
