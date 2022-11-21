using Microsoft.AspNetCore.Mvc;
using RugbyManagementAPI.Models;
using RugbyManagementAPI.ViewModels;
using RugbyManagementAPI.Repositories;

namespace RugbyManagementAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly RugbyContext _context;

        public MatchController(RugbyContext context)
        {
            _context = context;
        }

        [Route("create")]
        [HttpPost]
        public long Create(Match model)
        {
            MatchRepository matchRepository = new MatchRepository(_context);
            long matchId = matchRepository.Create(model);

            return matchId;
        }

        [Route("getalljointeams")]
        [HttpGet]
        public List<MatchViewModel> GetAllJoinTeams()
        {
            var matchRepository = new MatchRepository(_context);
            var matches = matchRepository.GetAllJoinTeams();

            return matches;
        }
    }
}
