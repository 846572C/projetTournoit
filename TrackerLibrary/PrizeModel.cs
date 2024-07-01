using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents what the prize is for a given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numeric identifier for a place (2 for second place, etc..)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The friendly name for the place (second place, etc...)
        /// </summary>
        public int PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earn or zero if it is not used.
        /// </summary>
        public int PrizeAmount { get; set; }

        /// <summary>
        /// The number that represents the percentage of the overall take or zero
        /// if it is not used. The percentage is a fraction of one ( so 0.5 for 50%).
        /// </summary>
        public int PrizePercentage { get; set; }

    }
}
