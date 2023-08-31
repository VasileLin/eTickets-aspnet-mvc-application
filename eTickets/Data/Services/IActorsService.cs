using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<List<Actor>> GetAll();
        Task<Actor> GetById(int id);
        Task Add(Actor actor);
        Task<Actor> Update(int id, Actor actor);
        Task Delete(int id);
    }
}
