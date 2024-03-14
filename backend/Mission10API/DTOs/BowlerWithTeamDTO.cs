using Mission10API.Models;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mission10API.DTOs
{

    namespace APIFun.DTOs
    {
        public class BowlerWithTeamDTO
        {
            public int Id { get; set; } // Unique identifier for the bowler

            public string? Address { get; set; }

            public string? City { get; set; }

            public string? State { get; set; }

            public string? Zip { get; set; }

            public string? PhoneNumber { get; set; }

            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? MiddleInitial { get; set; }

            // Name of the team the bowler belongs to
            // This property is not optional, indicating every bowler should be associated with a team when this DTO is used
            public string TeamName { get; set; }
        }
    }
}
