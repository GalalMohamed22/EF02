using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;


namespace EF02
{
    internal class EventHubDBContaxt: DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-80O93R7\\SQLEXPRESS;Database=BookStore;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>()
                .HasOne(p => p.Organizer)
                .WithOne(c => c.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(p => p.OrganizerID);


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventHubDBContaxt).Assembly);
        }


    }
}
