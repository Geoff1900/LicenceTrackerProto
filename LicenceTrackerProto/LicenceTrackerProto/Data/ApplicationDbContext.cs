using System;
using System.Collections.Generic;
using System.Text;
using LicenceTrackerProto.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LicenceTrackerProto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Licence> items { get; set; }

        //TODO Make this an extension method of the Model Builder Class
        //TODO Ascynchronously read data from a file of MS licence Data
        protected  override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Licence>().HasData(new Licence{ ID = Guid.NewGuid(), User = "Geoff", LicenceKey = "VS_Pro" });
            modelbuilder.Entity<Licence>().HasData(new Licence { ID = Guid.NewGuid(), User = "Alice", LicenceKey = "WS_Ent" });
        }
    }
}
