using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thesoccerleague.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string PlayerName { get; set; }
        [Required]
        public DateTime PlayerDateOfBorn { get; set; }
        public int PlayerValue { get; set; }
        public string PlayerLogo { get; set; }
        [Required]
        [Display(Name = "Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
