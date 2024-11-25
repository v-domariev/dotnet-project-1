
using HotelSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.API.Interfaces
{
    public interface IDbContext
    {

        DbSet<Hotel> Hotels { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token = default);
    }
}
