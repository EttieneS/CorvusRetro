using RugbyManagementAPI.ViewModels;
using RugbyManagementAPI.Models;
using System.Text.RegularExpressions;

namespace RugbyManagementAPI.Repositories
{
    public class MatchRepository
    {
        private readonly RugbyContext _context;

        public MatchRepository(RugbyContext context)
        {
            _context = context;
        }

        public long Create(Models.Match model)
        {
            _context.Matches.Add(model);
            _context.SaveChanges();

            long id = model.Id;

            return id;
        }

        public List<MatchViewModel> GetAllJoinTeams()
        {
            List<MatchViewModel> list = new List<MatchViewModel>();

            var matches = (from m in _context.Matches
                          join a in _context.Teams on m.TeamAId equals a.Id
                          join b in _context.Teams on m.TeamBId equals b.Id
                          
                          select new MatchViewModel
                          {                              
                              TeamA = a.TeamName,
                              TeamB = b.TeamName,                          
                              Score = m.Score
                          }).ToList();
            
            foreach(var match in matches)
            {                                
                string[] splitString = Regex.Split(match.Score, @"/");

                int ScoreA = Int32.Parse(splitString[0]); 
                int ScoreB = Int32.Parse(splitString[16]);

                if (ScoreA > ScoreB)
                {
                    match.Winner = match.TeamA;
                } else
                {
                    match.Winner = match.TeamB;
                }

                list.Add(match);    
            }

            return list;
        }
    }
}
