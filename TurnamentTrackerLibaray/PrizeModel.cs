using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentTrackerLibaray
{
    public class PrizeModel
    {
        /// <summary>
        /// Repersent the price number. Ex: 1,2,3,4.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Repersent the prize name. EX 1st, 2nd, Winner, Champion, first runner, second runner
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Repersent the prize amount for that particular placement
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Repersnet the prize percentage for the winner
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
