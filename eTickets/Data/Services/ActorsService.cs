using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _dbContext;

        public ActorsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Add(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Actor>> GetAll()
        {
            return await _dbContext.Actors.ToListAsync();
        }

        public Task<Actor> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
