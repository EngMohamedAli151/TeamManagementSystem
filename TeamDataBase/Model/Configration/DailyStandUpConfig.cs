using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDataBase.Model.Configration
{
    public class DailyStandUpConfig : IEntityTypeConfiguration<DailyStandUp>
    {
        public void Configure(EntityTypeBuilder<DailyStandUp> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(u => u.Status)
            .IsRequired()
            .HasMaxLength(4000)
            .HasColumnType("NVARCHAR(4000)");

        }
    }
}
