using Microsoft.AspNetCore.Mvc;
using RugbyManagementAPI.Models;
using RugbyManagementAPI.ViewModels;
using RugbyManagementAPI.Repositories;

namespace RugbyManagementAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]    
    public class PlayerController : ControllerBase
    {
        private readonly RugbyContext _context;
        public PlayerController(RugbyContext context)
        {
            _context = context;
        }

        [Route("create")]
        [HttpPost]
        public long create(Player model)
        {
            PlayerRepository playerRepository = new PlayerRepository(_context);
            long playerId = playerRepository.Create(model);

            return playerId;
        }

        [Route("getpositions")]
        [HttpGet]
        public List<Position> GetAll()
        {
            var positionRepository = new PositionRepository(_context);
            List<Position> positions = positionRepository.GetAll().ToList();

            return positions;
        }

        [Route("getalljointeams")]
        [HttpGet]
        public List<PlayerViewModel> GetAllJoinTeams()
        {
            var playerRepository = new PlayerRepository(_context);
            var players = playerRepository.GetAllJoinTeams();

            return players;
        }
    }
}
