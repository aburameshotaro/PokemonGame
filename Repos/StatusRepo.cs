using Microsoft.EntityFrameworkCore;
using PokemonGame.Entities;

namespace PokemonGame.Repos
{
    public class StatusRepo
    {
        private readonly PokemonDbContext _context;

        public StatusRepo(PokemonDbContext context) 
        { 
            _context = context;
        }


        public async Task<int?> FindIdByDescription(string description)
        {
            var statuses = await _context.Status.ToListAsync();
            foreach (var status in statuses)
            {
                if (description.ToLower().Contains(status.Verb))
                {
                    return status.Id;
                }
            }
            return null;
        }
        public async Task<int?> FindIdByVerb(string verb)
        {
            var status = await _context.Status.FirstOrDefaultAsync(s => s.Verb == verb);
            if (status == null) { return null; }
            return status.Id;
        }
    }
}
