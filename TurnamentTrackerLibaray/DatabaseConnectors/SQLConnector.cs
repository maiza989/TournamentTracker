using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTrackerLibaray.Models;

namespace TournamentTrackerLibaray.DatabaseConnectors
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make the prize model method actaully save to the database
        /// <summary>
        /// Save a new prize to the database
        /// </summary>
        /// <param name="model"> The model information the prize represent</param>
        /// <returns> The prize information, which include the prize identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
