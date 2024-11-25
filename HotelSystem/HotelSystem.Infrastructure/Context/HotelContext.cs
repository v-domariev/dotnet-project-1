using HotelSystem.API.Interfaces;
using HotelSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Infrastructure.Context
{
    public partial class HotelContext : DbContext, IDbContext
    {
        public virtual DbSet<Hotel> Hotels { get; set; }
        public HotelContext() { }
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<Hotel>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Hotel>()
                .Property(p => p.Name)
                .HasMaxLength(50);
            modelBuilder.Entity<Hotel>()
                .Property(p => p.CreationDate)
                .HasDefaultValue(new DateTime(2000, 1, 1));
            SeedDatabase(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }


        private static void SeedDatabase(ModelBuilder modelBuilder) { }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
