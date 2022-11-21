using RugbyManagementAPI.ViewModels;
using RugbyManagementAPI.Models;

namespace RugbyManagementAPI.Repositories
{
    public class MatchRepository
    {
        private readonly RugbyContext _context;

        public MatchRepository(RugbyContext context)
        {
            _context = context;
        }

        public long Create(Match model)
        {
            _context.Matches.Add(model);
            _context.SaveChanges();

            long id = model.Id;

            return id;
        }

        public List<MatchViewModel> GetAllJoinTeams()
        {
            var matches = (from m in _context.Matches
                          join a in _context.Teams on m.TeamAId equals a.Id
                          join b in _context.Teams on m.TeamBId equals b.Id
                          select new MatchViewModel
                          {                              
                              TeamA = a.TeamName,
                              TeamB = b.TeamName,
                          }).ToList();

            return matches;
        }
    }
}
