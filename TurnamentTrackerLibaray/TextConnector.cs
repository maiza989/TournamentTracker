using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnamentTrackerLibaray;

namespace TournamentTrackerLibaray
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text file data saving.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
