using Microsoft.EntityFrameworkCore;
using Mission10API.DTOs.APIFun.DTOs;

namespace Mission10API.Models
{
    // Implementation of the IBowlingRepository interface
    public class EFBowlingRepository : IBowlingRepository
    {
        // Private field to store the database context
        private BowlingLeagueContext _BowlingLeagueContext;

        // Constructor that injects the database context into the repository
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _BowlingLeagueContext = temp;
        }

        // Property to get all Bowlers from the database
        public IEnumerable<Bowler> Bowlers => _BowlingLeagueContext.Bowlers;

        // Property to get all Teams from the database
        public IEnumerable<Team> Teams => _BowlingLeagueContext.Teams;

        // Method to get all bowlers along with their associated team information
        public IEnumerable<BowlerWithTeamDTO> GetBowlersWithTeams()
        {
            // Query the database for all bowlers, including their team information,
            // and project the results into a collection of BowlerWithTeamDTO objects
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
