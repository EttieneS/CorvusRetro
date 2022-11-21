using RugbyManagementAPI.Models;

namespace RugbyManagementAPI.Repositories
{
    public class TeamRepository
    {
        private readonly RugbyContext _context;

        public TeamRepository(RugbyContext context)
        {
            _context = context;
        }

        public long Create(Team model)
        {
            _context.Teams.Add(model);
            _context.SaveChanges();

            long id = model.Id;

            return id;
        }

        public List<Team> GetAll()
        {
            return _context.Teams.ToList();
        }
    }
}
