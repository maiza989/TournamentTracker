using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentTrackerLibaray
{
    /// <summary>
    /// Represent one match in the turnament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Repersent the set of team that are involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Repersent the winner team
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Repersent the round the match is currnetly in
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
