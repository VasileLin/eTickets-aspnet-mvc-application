using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly IEntityBaseRepository<Actor> _actorRepository;

        public ActorsService(AppDbContext dbContext, IEntityBaseRepository<Actor> actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public async Task AddAsync(Actor actor)
        {
            await _actorRepository.AddAsync(actor);
        }

        public async Task DeleteAsync(int id)
        {
           await _actorRepository.DeleteAsync(id);
        }

        public async Task<List<Actor>> GetAllAsync()
        {
            return await _actorRepository.GetAllAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await _actorRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int id, Actor actor)
        {
            await _actorRepository.UpdateAsync(id, actor);
            //var actorToUpdate = _dbContext.Actors.FirstOrDefault(q => q.Id == actor.Id);

            //if (actorToUpdate != null)
            //{
            //    actorToUpdate.ProfilePictureURL = actor.ProfilePictureURL;
            //    actorToUpdate.FullName = actor.FullName;
            //    actorToUpdate.Bio = actor.Bio;
            //    await _dbContext.SaveChangesAsync();
            //}
        }
    }
}
