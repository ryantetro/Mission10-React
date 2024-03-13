using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10API.Models;

namespace Mission10API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlerController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

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
