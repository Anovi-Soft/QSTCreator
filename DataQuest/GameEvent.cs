using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataQuest
{
    /// <summary>
    /// Types of game events
    /// </summary>
    [Serializable, Flags]
    public enum GameEvent: ulong
    {
        None=0L,
        Dead=1L,
        Win=2L,
        EasterEggs=4L,
    }
}
