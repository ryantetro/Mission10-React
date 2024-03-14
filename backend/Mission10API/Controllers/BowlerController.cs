using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10API.Models;

namespace Mission10API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        // Private field to hold the repository instance
        private IBowlingRepository _bowlingRepository;

        // Constructor injecting the bowling repository interface
        public BowlerController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        // HTTP GET method to retrieve bowler data, including team associations
        [HttpGet]
        public ActionResult<IEnumerable<Bowler>> GetWithTeams()
        {
            var bowlerData = _bowlingRepository.GetBowlersWithTeams();
            if (bowlerData == null || !bowlerData.Any())
            {
                return NotFound();
            }
            return Ok(bowlerData);
        }
    }
}
