using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentTrackerLibaray
{
    public class TeamModel
    {
        /// <summary>
        /// Represent a list of teams for the turnament.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represent the name of a team.
        /// </summary>
        public string TeamName { get; set; } 
    }
}
