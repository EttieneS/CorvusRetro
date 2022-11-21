using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RugbyManagementAPI.Models;
using RugbyManagementAPI.Repositories;
using Microsoft.AspNetCore.Cors;

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
    }
}
