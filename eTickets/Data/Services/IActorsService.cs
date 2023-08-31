using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<List<Actor>> GetAll();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task UpdateAsync(int id, Actor actor);
        Task DeleteAsync(int id);
    }
}
