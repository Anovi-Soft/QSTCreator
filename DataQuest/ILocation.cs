using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataQuest
{
    /// <summary>
    /// Interface for description GameLocations 
    /// </summary>
    public interface ILocation
    {
        /// <summary>
        /// Set of founded flags in this location 
        /// </summary>
        HashSet<int> FoundFlags { get; set; }

        /// <summary>
        /// Name Of this location
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Association current game flags with way
        /// </summary>
        Dictionary<GameFlags, IRoad> Branch { get; set; }

        /// <summary>
        /// Return the new way from current flags
        /// </summary>
        /// <param name="flags">Current user`s flags</param>
        /// <returns>New way</returns>
        IRoad NextBranch(GameFlags flags);

        /// <summary>
        /// Location events
        /// </summary>
        GameEvent Events { get; set; }
    }
}
