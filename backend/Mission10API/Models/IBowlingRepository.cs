using Mission10API.DTOs.APIFun.DTOs;

namespace Mission10API.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        public IEnumerable<BowlerWithTeamDTO> GetBowlersWithTeams();
    }
}
