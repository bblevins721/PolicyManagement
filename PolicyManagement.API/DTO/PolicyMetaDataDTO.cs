using System;

namespace PolicyManagement.API.DTO
{
    public class PolicyMetaDataDTO
    {
        /// <summary>
        /// Policy ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Policy Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Policy Description
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Number of versions
        /// </summary>
        public int VersionCount{ get; set; }

        /// <summary>
        /// Date first Created
        /// </summary>
        public DateTime FirstCreatedDate { get; set; }

        public bool IsActive { get; set; }

        public int ActiveVersionId { get; set; }

    }
}
