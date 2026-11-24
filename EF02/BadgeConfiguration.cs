using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.SqlServer;

namespace EF02
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasOne(p => p.Attendee)
                .WithOne(p => p.Badge)
                .HasForeignKey<Badge>(c => c.AttendeeId);
        }
    }
}
