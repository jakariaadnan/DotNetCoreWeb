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
        public DbSet<Department> departments { get; set; }
        public DbSet<Designation> designations { get; set; }
        public DbSet<EmployeeType> employeeTypes { get; set; }
        public DbSet<Rank> ranks { get; set; }
        public DbSet<Religion> religions { get; set; }
        public DbSet<Section> sections { get; set; }
        public DbSet<SpecialBranchUnit> specialBranchUnits { get; set; }
        public DbSet<SubBranchUnit> subBranchUnits { get; set; }
        public DbSet<StatusInfo> statusInfos { get; set; }
        public DbSet<BCSBatch> bCSBatches { get; set; }
        public DbSet<UserLog> userLogs { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Division> divisions { get; set; }
        public DbSet<DocumentCategory> documentCategories { get; set; }

        #endregion

        #region Employee Infoes
        public DbSet<EmployeeInfo> employeeInfos{ get; set; }
        public DbSet<DocumentMaster> documentMaster { get; set; }
        public DbSet<DocumentDetails> documentDetails { get; set; }

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
