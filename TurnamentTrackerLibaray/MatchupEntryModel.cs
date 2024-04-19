using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentTrackerLibaray
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Repersent one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Repersent the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Repersent the matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
