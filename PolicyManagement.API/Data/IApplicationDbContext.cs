using Microsoft.EntityFrameworkCore;
using PolicyManagement.Data;

namespace PolicyManagement.API.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Policy> Policies { get; set; }
        DbSet<PolicyGrouping> PolicyGroups { get; set; }
        DbSet<PolicyVersion> PolicyVersions { get; set; }
    }
}