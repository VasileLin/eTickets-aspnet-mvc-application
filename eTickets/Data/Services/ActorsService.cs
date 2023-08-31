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

        public async Task AddAsync(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _dbContext.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _dbContext.Actors.Remove(result);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Actor>> GetAll()
        {
            return await _dbContext.Actors.ToListAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _dbContext.Actors.SingleOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task UpdateAsync(int id, Actor actor)
        {
            var actorToUpdate = _dbContext.Actors.FirstOrDefault(q => q.Id == actor.Id);

            if (actorToUpdate != null)
            {
                actorToUpdate.ProfilePictureURL = actor.ProfilePictureURL;
                actorToUpdate.FullName = actor.FullName;
                actorToUpdate.Bio = actor.Bio;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
