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

        public List<Match> GetAll()
        {
            return _context.Matches.ToList();            
        }
    }
}
