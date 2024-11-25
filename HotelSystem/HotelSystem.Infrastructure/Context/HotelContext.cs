using HotelSystem.API.Interfaces;
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
        public HotelContext() { }
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            SeedDatabase(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }


        private static void SeedDatabase(ModelBuilder modelBuilder) { }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
