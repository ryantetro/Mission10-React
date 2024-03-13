using Microsoft.EntityFrameworkCore;
using Mission10API.DTOs.APIFun.DTOs;

namespace Mission10API.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _BowlingLeagueContext;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _BowlingLeagueContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _BowlingLeagueContext.Bowlers;

        public IEnumerable<Team> Teams => _BowlingLeagueContext.Teams;

        public IEnumerable<BowlerWithTeamDTO> GetBowlersWithTeams()
        {
            var bowlersWithTeams = _BowlingLeagueContext.Bowlers
                .Include(b => b.Team)
                .Select(b => new BowlerWithTeamDTO
                {
                    Id = b.BowlerId,
                    FirstName = b.BowlerFirstName,
                    LastName = b.BowlerLastName,
                    MiddleInitial = b.BowlerMiddleInit,
                    Address = b.BowlerAddress,
                    City = b.BowlerCity,
                    State = b.BowlerState,
                    Zip = b.BowlerZip,
                    PhoneNumber = b.BowlerPhoneNumber,
                    TeamName = b.Team.TeamName
                }).ToList();

            return bowlersWithTeams;
        }
    }
}
