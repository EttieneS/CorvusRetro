using RugbyManagementAPI.Models;
using RugbyManagementAPI.ViewModels;

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

        public List<PlayerViewModel> GetAllJoinTeams()
        {
            List<PlayerViewModel> list = new List<PlayerViewModel>();

            var players = (from p in _context.Players
                join t in _context.Teams on p.TeamId equals t.Id
                join po in _context.Positions on p.Position equals po.Id
                select new PlayerViewModel
                {   
                    Id = p.Id,
                    FirstName = p.FirstName, 
                    LastName = p.LastName, 
                    Position = po.Description, 
                    TeamName = t.TeamName, 
                    Active = p.Active.ToString(),
                           
                }).ToList();            
            return players;
        }
    }
}
