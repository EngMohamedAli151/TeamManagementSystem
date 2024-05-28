using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamDataBase.Model.Configration;

namespace TeamDataBase.Model.TeamDbcontext
{
    public class TeamDbContext:IdentityDbContext<IdentityUser>
    {
        public TeamDbContext(DbContextOptions<TeamDbContext>options):base(options) 
        {
            
        }
        #region DbSet
        public DbSet<DailyStandUp> DailyStandUp { get; set;}
        #endregion
        #region Configration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.ApplyConfiguration(new DailyStandUpConfig());

        }
        #endregion
    }
}
