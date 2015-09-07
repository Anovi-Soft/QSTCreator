using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataQuest
{
    /// <summary>
    /// Pair of road length and target location
    /// </summary>
    public interface IRoad
    {
        /// <summary>
        /// Road length
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// Target location
        /// </summary>
        ILocation Target { get; set; }
        
    }
}
