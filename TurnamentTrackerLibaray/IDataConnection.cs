using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnamentTrackerLibaray;

namespace TournamentTrackerLibaray
{
    /// <summary>
    /// Repersent an interface for connecting data to a database
    /// </summary>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
