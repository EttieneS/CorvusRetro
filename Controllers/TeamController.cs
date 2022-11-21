using Microsoft.AspNetCore.Mvc;
using RugbyManagementAPI.Models;
using RugbyManagementAPI.Repositories;

namespace RugbyManagementAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly RugbyContext _context;
        public TeamController(RugbyContext context)
        {
            _context = context;
        }

        [Route("create")]
        [HttpPost]
        public long create(Team model)
        {
            TeamRepository teamRepository = new TeamRepository(_context);
            long playerId = teamRepository.Create(model);

            return playerId;
        }
    }
}
