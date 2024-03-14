using Mission10API.DTOs.APIFun.DTOs;

namespace Mission10API.Models
{

    // Interface defining the contract for a repository dealing with bowling data.
    public interface IBowlingRepository
    {
        // Property to get a collection of all Bowler entities.
        // This allows for read-only access to the list of bowlers in the system.
        IEnumerable<Bowler> Bowlers { get; }

        // Property to get a collection of all Team entities.
        // This allows for read-only access to the list of teams in the system.
        IEnumerable<Team> Teams { get; }

        // Method to retrieve a collection of BowlerWithTeamDTO objects.
        public IEnumerable<BowlerWithTeamDTO> GetBowlersWithTeams();
    }
}
