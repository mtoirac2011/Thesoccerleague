using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thesoccerleague.Models
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string LeagueName { get; set; }
        [Required]
        [Display(Name = "League")]
        public string LeagueCountry { get; set; }
        public string LeagueLogo { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
