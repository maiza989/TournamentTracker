using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentTrackerLibaray
{
    public class MatchupModel
    {
        /// <summary>
        /// Repersent a list of teams matchup being entered in the turnament 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Repersent the winner team
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Repersent the round the turnament match is currnetly in
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
