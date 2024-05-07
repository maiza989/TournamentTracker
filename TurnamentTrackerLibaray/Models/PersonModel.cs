using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerLibaray.Models
{
    /// <summary>
    /// Represent one team member
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Repersent a team member first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Repersent a team member last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Repersent a team member email address for communcation
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Repersent a team member cell phone number for communcation
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
