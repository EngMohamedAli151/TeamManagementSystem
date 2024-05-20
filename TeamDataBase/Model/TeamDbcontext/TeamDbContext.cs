using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDataBase.Model.Configration;

namespace TeamDataBase.Model.TeamDbcontext
{
    public class TeamDbContext:DbContext
    {
        public TeamDbContext(DbContextOptions<TeamDbContext>options):base(options) 
        {
            
        }
        #region DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<DailyStandUp> DailyStandUp { get; set;}
        #endregion
        #region Configration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new DailyStandUpConfig());

        }
        #endregion
    }
}
