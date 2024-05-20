using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDataBase.Model.Configration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
            builder.HasMany<DailyStandUp>()
                    .WithOne()
                    .HasForeignKey(d => d.UserFk);

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name )
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("NVARCHAR(100)"); // Explicitly setting NVARCHAR(50)

            builder.Property(u => u.NickName)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("NVARCHAR(50)");

            builder.Property(u => u.Mail)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("NVARCHAR(50)");

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100); // Assuming hashed passwords are no longer than 100 chars
        }
    }
}
