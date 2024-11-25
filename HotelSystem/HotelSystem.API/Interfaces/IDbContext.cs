
namespace HotelSystem.API.Interfaces
{
    public interface IDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken token = default);
    }
}
