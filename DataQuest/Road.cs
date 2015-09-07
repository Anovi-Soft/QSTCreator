using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataQuest
{
    /// <summary>
    /// Base class of <see cref="IRoad"/>
    /// </summary>
    [Serializable]
    public class Road: IRoad
    {
        public int Size { get; set; }
        public ILocation Target { get; set; }
    }
}
