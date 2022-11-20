using RugbyManagementAPI.Models;

namespace RugbyManagementAPI.Repositories
{
    public class PlayerRepository
    {
        private readonly RugbyContext _context;

        public PlayerRepository(RugbyContext context)
        {
            _context = context;
        }

        public long Create(Player model)
        {
            _context.Players.Add(model);
            _context.SaveChanges();

            long id = model.Id;

            return id;
        }
    }
}
