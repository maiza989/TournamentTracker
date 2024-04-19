using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentTrackerLibaray
{
    public class TurnamentModel
    {
        /// <summary>
        /// Represent the name of the turnament
        /// </summary>
        public string TurnamentName { get; set; }
        /// <summary>
        /// Repersent the amount of fee to enter the turnament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represent the a list of team that entered the turnament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represent the list of prizes for winners of the trunament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represent a random number of round based on how many teams are in the turnament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
