using RugbyManagementAPI.Models;

namespace RugbyManagementAPI.Repositories
{
    public class PositionRepository
    {
        private readonly RugbyContext _context;

        public PositionRepository(RugbyContext context)
        {
            _context = context;
        }
        public List<Position> GetAll()
        {
            return _context.Positions.ToList();
        }
    }
}
