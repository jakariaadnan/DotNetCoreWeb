using DotNetCore.Data.Entity;
using DotNetCore.Data.Entity.AddressData;
using DotNetCore.Data.Entity.EmployeeInfos;
using DotNetCore.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.Data
{
    public class CoreWebDBContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CoreWebDBContext(DbContextOptions<CoreWebDBContext> options, IHttpContextAccessor _httpContextAccessor) : base(options)
        {
            this._httpContextAccessor = _httpContextAccessor;
        }

        #region Master Data
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SpecialBranchUnit> SpecialBranchUnits { get; set; }
        public DbSet<SubBranchUnit> SubBranchUnits { get; set; }
        public DbSet<StatusInfo> StatusInfos { get; set; }
        public DbSet<BCSBatch> BCSBatches { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }


        #endregion

        #region Employee Infoes
        public DbSet<EmployeeInfo> EmployeeInfos{ get; set; }

        #endregion

        #region Settings Configs
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {

            var entities = ChangeTracker.Entries().Where(x => x.Entity is Base && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUsername = !string.IsNullOrEmpty(_httpContextAccessor?.HttpContext?.User?.Identity?.Name)
                ? _httpContextAccessor.HttpContext.User.Identity.Name
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((Base)entity.Entity).createdAt = DateTime.Now;
                    ((Base)entity.Entity).createdBy = currentUsername;
                }
                else
                {
                    entity.Property("createdAt").IsModified = false;
                    entity.Property("createdBy").IsModified = false;
                    ((Base)entity.Entity).updatedAt = DateTime.Now;
                    ((Base)entity.Entity).updatedBy = currentUsername;
                }
                
            }
        }
        #endregion


    }
}
