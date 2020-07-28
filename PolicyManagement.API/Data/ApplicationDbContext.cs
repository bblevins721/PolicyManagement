using Microsoft.EntityFrameworkCore;
using PolicyManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.API.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Policy> Policies { get; set; }
        public DbSet<PolicyGrouping> PolicyGroups { get; set; }
        public DbSet<PolicyVersion> PolicyVersions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
    }
}
