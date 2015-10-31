using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataQuest
{
    /// <summary>
    /// Base class of <see cref="ILocation"/>
    /// It`s can be <see cref="Grouping"/>
    /// </summary>
    [Serializable]
    public class Location : Grouping, ILocation
    {
        public HashSet<int> FoundFlags { get; set; }
        public string Name { get; set; }
        public Dictionary<GameFlags, IRoad> Branch { get; set; }
        public IRoad NextBranch(GameFlags flags)
        {
            var choise = Branch.Keys
                .FirstOrDefault(a => a.ImplementTo(flags));
            return choise != null ? Branch[choise] : Branch.Last().Value;
        }

        public IRoad DefaultBranch { get; set; }

        public GameEvent Events { get; set; }
        public List<string> Messages { get; set; }
        public List<string> Answers { get; set; }
    }
}
